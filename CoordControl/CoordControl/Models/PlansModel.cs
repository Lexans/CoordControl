using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CoordControl.Core.Domains;
using CoordControl.Data.DAO;

namespace CoordControl.Models
{
    public class PlansModel
    {
        private RouteDAO rdao;
        private PlanDAO pdao;

        public PlansModel()
        {
            rdao = new RouteDAO();
            pdao = new PlanDAO();
        }

        public List<Plan> GetPlansByRoute(Route r)
        {
            return rdao.GetByID(r.ID).Plans.ToList();
        }

        public void DeletePlan(Plan p)
        {
            pdao.Delete(pdao.GetByID(p.ID));
        }

        public void SavePlan(Plan p)
        {
            pdao.SaveOrUpdateAndCommit(p);
        }


        public Plan GetById(long p)
        {
            return pdao.GetByID(p);
        }
    }
}
