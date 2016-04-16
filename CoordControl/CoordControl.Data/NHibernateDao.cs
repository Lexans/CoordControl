using System;
using System.Collections.Generic;
using System.Linq;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Linq;
using NHibernate.Tool.hbm2ddl;

namespace CoordControl.Data
{
    /// <summary>
    /// Базовый класс доступа к данным, использующий Nhibernate.
    /// </summary>
    /// <typeparam name="T">Тип данных.</typeparam>
    /// <typeparam name="IdT">Тип идентификатора данных.</typeparam>
    public class NHibernateDao<T>
    {
        /// <summary>
        /// Представление текущей сессии.
        /// </summary>
        protected ISession NHibernateSession
        {
            get { return NHibernateSessionManager.GetSession(); }
        }

        /// <summary>
        /// Создает схему базы данных.
        /// </summary>
        public static void UpdateSchema()
        {
            var cfg = new Configuration();
            cfg.Configure(NHibernateSessionManager.SessionFactoryConfigPath);

            try
            {
                CreateSchema(cfg);
            }
            catch (Exception)
            {
                DropSchema(cfg);
                CreateSchema(cfg);
            }
        }

        /// <summary>
        /// Получение экземпляра сущности по id.
        /// </summary>
        public T GetByID(long id)
        {
            using (ISession session = NHibernateSession)
            {
                return (T)session.Load(typeof(T), id);
            }
        }

        /// <summary>
        /// Получение всех экземпляров сущности из БД.
        /// </summary>
        public List<T> GetAll()
        {
            using (ISession session = NHibernateSession)
            {
                return session.Query<T>().ToList<T>();
            }
        }


        /// <summary>
        /// Сохранение новой сущности в БД, если сущеости с таким ID нет. Если ID == 0, то генерируется.
        /// Обновление сущности, если сущность с этим ID уже существует.
        /// </summary>
        /// <param name="entity">Созхраняемая сущность.</param>
        /// <returns>Сохраненнная сущность.</returns>
        public T SaveOrUpdateAndCommit(T entity)
        {
            using (ISession session = NHibernateSession)
            {
                using (ITransaction t = session.BeginTransaction())
                {
                    session.SaveOrUpdate(entity);
                    t.Commit();
                    return entity;
                }
            }
        }

        /// <summary>
        /// Удаляет сущность.
        /// </summary>
        /// <param name="entity">Сущность для удаления.</param>
        public virtual void Delete(T entity)
        {
            using (ISession session = NHibernateSession)
            {
                using (ITransaction t = session.BeginTransaction())
                {
                    session.Delete(entity);
                    t.Commit();
                }
            }
        }


        private static void CreateSchema(Configuration cfg)
        {
            new SchemaExport(cfg).Create(true, true);
        }

        private static void DropSchema(Configuration cfg)
        {
            new SchemaExport(cfg).Drop(true, true);
        }
    }
}