using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CoordControl.Core.Domains;
using CoordControl.Data.DAO;

namespace CoordControl.Models
{
    public class RoutesModel
    {
        private RouteDAO dao;

        public RoutesModel()
        {
            dao = new RouteDAO();
        }

        public List<Route> GetRoutes()
        {
            return dao.GetAll();
        }

        public void DeleteRoute(Route r)
        {
            dao.Delete(r);
        }

    }
}
