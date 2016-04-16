using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoordControl.Core.Domains
{
    public class Route : DomainObject
    {
        public string StreetName { get; set; }
        public int CrossCount { get; set; }

        public IList<Cross> Crosses { get; set; }
        public ISet<Plan> Plans { get; set; }

        public string Title {
            get {
                return this.ToString();
            }
        }

        public override string ToString()
        {
            return StreetName + " (от ул. " + Crosses.First().StreetName + " до ул. " + Crosses.Last().StreetName + ")";
        }
    }
}
