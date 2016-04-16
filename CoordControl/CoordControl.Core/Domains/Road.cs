using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoordControl.Core.Domains
{
    public class Road : DomainObject
    {
        public int Length { get; set; }
        public int Speed { get; set; }

        public Cross CrossLeft { get; set; }
        public Cross CrossRight { get; set; }
    }
}
