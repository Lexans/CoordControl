using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoordControl.Core.Domains;

namespace CoordControl.Core
{
    public sealed class PlanCalculatorMoveTime : PlanCalculator
    {
        protected override void CalcPhaseShifts(Plan p)
        {
            foreach (CrossPlan crP in p.CrossPlans)
            {
                if (crP.Cross.RoadLeft != null)
                    crP.PhaseOffset = (int)Math.Ceiling(
                        (CalcLengthRoadWithCross(crP.Cross) / ((double)crP.Cross.RoadLeft.Speed / ModelConst.SPEED_COEF))
                        );
                else
                    crP.PhaseOffset = 0;
            }
        }

    }
}
