using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using CoordControl.Core.Domains;
using CoordControl.Data.DAO;

namespace CoordControl.Models
{
    class PlanEditModel
    {
        private PlanDAO _dao;
        private Random _rand;

        public PlanEditModel()
        {
            _dao = new PlanDAO();
            _rand = new Random();
        }

        public void Save(Plan p)
        {
            _dao.SaveOrUpdateAndCommit(p);
        }

    }
}
