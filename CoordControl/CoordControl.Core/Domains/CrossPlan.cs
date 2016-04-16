using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoordControl.Core.Domains
{
    public class CrossPlan : DomainObject
    {
        public int P1MainInterval { get; set; }
        public int P1MediateInterval { get; set; }
        public int P2MainInterval { get; set; }
        public int P2MediateInterval { get; set; }
        public int PhaseOffset { get; set; }

        public Plan Plan { get; set; }
        public Cross Cross { get; set; }

        public override int GetHashCode()
        {
            int hashCode = 0;
            hashCode = hashCode ^ Plan.GetHashCode() ^ Cross.GetHashCode();
            return hashCode;
        }

        public override bool Equals(object obj)
        {
            var toCompare = obj as CrossPlan;
            if (toCompare == null)
            {
                return false;
            }
            return (this.GetHashCode() != toCompare.GetHashCode());
        }   
    }
}
