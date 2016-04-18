using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoordControl.Core.Domains;

namespace CoordControl.Core
{
    public sealed class PlanCalculatorSimple : PlanCalculator
    {
        protected override void CalcPhaseShifts(Plan p)
        {
            foreach (CrossPlan crP in p.CrossPlans)
            {
                if (crP.Cross.RoadLeft != null)
                    crP.PhaseOffset = (int)(
                        1.2 *
                        (crP.Cross.RoadLeft.Length / ((double)crP.Cross.RoadLeft.Speed / 3.6) ) - 5.0
                        );
                else
                    crP.PhaseOffset = 0;
            }
        }

    }
}
