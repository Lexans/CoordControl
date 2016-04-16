using System;
using System.Collections;
using NHibernate;
using NHibernate.Cfg;
using System.Collections.Generic;

namespace CoordControl.Data
{
    public static class NHibernateSessionManager
    {
        /// <summary>
        /// Путь к текущему файлу конфигурации.
        /// </summary>
        public static string SessionFactoryConfigPath { get; set; }
        
        /// <summary>
        /// Словарь уже созданных фабрик сессиий для файлов конфигурации.
        /// </summary>
        private static readonly Dictionary<string, ISessionFactory> _sessionFactories = new Dictionary<string, ISessionFactory>();

        /// <summary>
        /// Возвращает фабрику сессии по заданному файлу конфигурации.
        /// </summary>
        /// <param name="sessionFactoryConfigPath">Путь к файлу конфигурации.</param>
        /// <returns>Фабрика сессии.</returns>
        private static ISessionFactory GetSessionFactoryFor(string sessionFactoryConfigPath)
        {
            if (_sessionFactories.ContainsKey(sessionFactoryConfigPath))
                return _sessionFactories[sessionFactoryConfigPath];

            var cfg = new Configuration();
            cfg.Configure(sessionFactoryConfigPath);

            var sessionFactory = cfg.BuildSessionFactory();

            _sessionFactories.Add(sessionFactoryConfigPath, sessionFactory);

            return sessionFactory;
        }

        /// <summary>
        /// Возвращает сессию для текущего файла конфигурации SessionFactoryConfigPath.
        /// </summary>
        /// <returns></returns>
        public static ISession GetSession()
        {
            ISession session = GetSessionFactoryFor(SessionFactoryConfigPath).OpenSession();

            return session;
        }
    }
}