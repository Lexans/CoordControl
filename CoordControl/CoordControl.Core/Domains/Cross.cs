using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoordControl.Core.Domains
{
    public class Cross : DomainObject
    {
        public string StreetName { get; set; }

        public ISet<CrossPlan> PlanOfCrosses { get; set; }

        public Route Route { get; set; }
        public Pass PassLeft { get; set; }
        public Pass PassRight { get; set; }
        public Pass PassTop { get; set; }
        public Pass PassBottom { get; set; }
        public Road RoadLeft { get; set; }
        public Road RoadRight { get; set; }

        public override string ToString()
        {
            return StreetName;
        }
    }
}
