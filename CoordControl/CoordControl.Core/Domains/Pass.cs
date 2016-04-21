using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoordControl.Core.Domains
{
    public class Pass : DomainObject
    {
        public int Intensity { get; set; }
        public int LinesCount { get; set; }
        public double LineWidth { get; set; }
        public int LeftPart { get; set; }
        public int DirectPart { get; set; }
        public int RightPart { get; set; }

        public Cross Cross {
            get {
                if(CrossLeftPass != null)
                    return CrossLeftPass;
                else if (CrossRightPass!=null)
                    return CrossRightPass;
                else if (CrossTopPass!=null)
                    return CrossTopPass;
                else if (CrossBottomPass!=null)
                    return CrossBottomPass;
                else
                    return null;
            }
        }

        public Cross CrossLeftPass { get; set; }
        public Cross CrossRightPass { get; set; }
        public Cross CrossTopPass { get; set; }
        public Cross CrossBottomPass { get; set; }
    }
}
