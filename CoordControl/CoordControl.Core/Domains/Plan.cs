using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoordControl.Core.Domains
{
    public class Plan : DomainObject
    {
        public string Title { get; set; }
        public int Cycle { get; set; }

        public ISet<CrossPlan> CrossPlans { get; set; }

        public Route Route { get; set; }

        public override string ToString()
        {
            return Title;
        }
    }
}
