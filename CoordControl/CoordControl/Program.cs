using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


using CoordControl.Forms;
using CoordControl.Models;
using CoordControl.Presenters;

namespace CoordControl
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            Data.NHibernateSessionManager.SessionFactoryConfigPath = "NHibernate.SQLite.config";

            //Data.NHibernateDao<int>.UpdateSchema();


            FormRoutes form = new FormRoutes();
            RoutesModel model = new RoutesModel();
            RoutesPresenter presenter = new RoutesPresenter(form, model);            

            Application.Run(form);
        }
    }
}
