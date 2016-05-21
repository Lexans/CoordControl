using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CoordControl.Core.Domains;


namespace CoordControl.Core
{
    public enum PlanCalculatorWay
    {
        Direct,
        Reverse,
        Sum
    }

	public sealed class PlanCalculatorImit : PlanCalculator
	{

        public PlanCalculatorWay OptimizationWay = PlanCalculatorWay.Sum;

        protected override void CalcPhaseShifts(Plan p)
		{
            int n = p.CrossPlans.Count;
            double[] tc = new double[n - 1];

            for (int i = 0; i < n - 1; i++)
                tc[i] = 0;

            _plan = p;

            findMinVector(DelaySum, 0, p.Cycle - 1, 0, tc);

            for (int i = 1; i < n; i++)
                p.CrossPlans.First(x => (x.Cross.Position == i)).PhaseOffset = (int)xMin[i - 1];
        }


        private Plan _plan;
        private double DelaySum(double[] tc)
        {
            int n = _plan.CrossPlans.Count;

            for (int i = 1; i < n; i++)
                _plan.CrossPlans.First(x => (x.Cross.Position == i)).PhaseOffset = (int)tc[i - 1];

            RouteEnvir.Instance.ResetInstance();
            RouteEnvir.Instance.EntityPlan = _plan;

            for (int i = 0; i < RouteEnvir.Instance.CalcMeasureInterval(); i++)
            {
                RouteEnvir.Instance.RunSimulationStep();

            }
            
            double result = 0;

            switch(OptimizationWay)
            {
                case PlanCalculatorWay.Direct:
                    result = RouteEnvir.Instance.DelaysDirect[0];
                    break;
                case PlanCalculatorWay.Reverse:
                    result = RouteEnvir.Instance.DelaysReverse[0];
                    break;
                case PlanCalculatorWay.Sum:
                    result = RouteEnvir.Instance.DelaysDirect[0] + RouteEnvir.Instance.DelaysReverse[0];
                    break;
            }

            return result;
        }

        private double zMin;
        private double[] xMin;
        private void findMinVector(funcVector fv, double minX, double maxX, int i, double[] xCur)
        {

            double[] xCurrent = (double[])xCur.Clone();
            if (i == 0)
            {
                zMin = fv(xCurrent);
                xMin = (double[])xCurrent.Clone();
            }

            for (double xi = minX; xi <= maxX; xi++)
            {
                xCurrent[i] = xi;

                double z = fv(xCurrent);
                if (z < zMin)
                {
                    zMin = z;
                    xMin = (double[])xCurrent.Clone();
                }

                if (i < (xCurrent.Count() - 1))
                    findMinVector(fv, minX, maxX, i + 1, xCurrent);
            }
        }
	}
}

