using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoordControl.Core.Domains;

namespace CoordControl.Core
{
    public sealed class PlanCalculatorWithoutShifts : PlanCalculator
    {
        protected override void CalcPhaseShifts(Plan p)
        {
            foreach (CrossPlan crP in p.CrossPlans)
            {
                    crP.PhaseOffset = 0;
            }
        }

    }
}
