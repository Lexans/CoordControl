using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CoordControl.Core.Domains;


namespace CoordControl.Core
{
    public delegate double func(double x);
    public delegate double funcVector(double[] x);


	public sealed class PlanCalculatorAnalytic : PlanCalculator
	{
        protected override void CalcPhaseShifts(Plan p)
        {
            int n = p.CrossPlans.Count;
            double[] tc = new double[n-1];

            for(int i = 0; i < n-1; i++)
                tc[i] = 0;

            _plan = p;

            findMinVector(DelaySum, 0, p.Cycle-1, 0, tc);

            for (int i = 1; i < n; i++)
                p.CrossPlans.First(x => (x.Cross.Position == i)).PhaseOffset = (int)xMin[i-1];
        }


        private Plan _plan;
        private double DelaySum(double[] tc)
        {
            double result = 0d;
            int n = tc.Count();

            for(int i = 0; i < n; i++)
            {
                if (i == n - 1)
                    result += DelayDirect(_plan, i+1, tc[i]);
                else
                    result += (DelayDirect(_plan, i + 1, tc[i]) +
                        DelayReverse(_plan, i + 1, tc[i+1]));
            }

            return result;
        }

        private double DelayDirect(Plan plan, int i, double tci)
        {
            //программа координации i-го перекрестка
            CrossPlan cp = plan.CrossPlans.First(x => (x.Cross.Position == i));

            int tkri = cp.P2MainInterval;
            double Ipi = CalcMaxFlow(cp.Cross.PassLeft) / 3600d;
            double Ii = cp.Cross.PassLeft.Intensity / 3600d;
            double T = (double)plan.Cycle;


            int ai =
                (int) findMin((ax) =>
                    (1d / Ipi * Ii * Integrate((t) => (t - tci), 0, ax) - ax + tkri),
                    1, (double) cp.P1MainInterval);

            double result =
                Integrate((t) =>
                    Ii * (t - tci) * (tkri + 1d/Ipi * Ii * Integrate((tau) => tau - tci, 0, t)),
                    0, ai) / (Ii * T);
            
            return result;
        }


        private double DelayReverse(Plan plan, int i, double tci1)
        {
            CrossPlan cpi = plan.CrossPlans.First(x => (x.Cross.Position == i));
            CrossPlan cpi1 = plan.CrossPlans.First(x => (x.Cross.Position == i+1));

            int tkri = cpi.P2MainInterval;
            double Ii_ = cpi.Cross.PassRight.Intensity / 3600d;
            double T = (double) plan.Cycle;
            double Ipi_ = CalcMaxFlow(cpi.Cross.PassRight) / 3600d;

            int ai_ =
                (int)findMin((ax_) =>
                    (1d / Ipi_ * Ii_ * Integrate((t) => (t - tci1), 0, ax_) - ax_ + tkri),
                    1, (double)cpi.P1MainInterval);

            double result =
                Integrate((t) =>
                    Ii_ * (t - tci1) * (tkri + 1d / Ipi_ * Ii_ * Integrate((tau) => tau - tci1, 0, t)),
                    0, ai_);


            /*
            int ai_ =
                (int)findMin((ax_) =>
                    (1d / Ipi_ * Ii_ * Integrate((t) => (t - T + tci1), 0, ax_) - ax_ + tkri),
                    1, (double)cpi.P1MainInterval);

            double result =
                Integrate((t) =>
                    Ii_ * (t - T + tci1) * (tkri + 1d / Ipi_ * Ii_ * Integrate((tau) => tau - T + tci1, 0, t) - t),
                    0, ai_) / (Ii_ * T);
            */

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
		
		
		//нахождение минимума функции
        private double findMin(func f, double start, double end)
        {
            double ymin = f(start);
            double result = double.NaN;

            for (double x = start+1; x <= end; x++)
            {
                double y = f(x);
                if (y < ymin)
                {
                    ymin = y;
                    result = x;
                }
            }

            return result;
        }
		
		
        private double Integrate(func f, double start, double end)
        {
            double result = 0d;
            double step = 1;
            double fx = 1;

            double curX = start;
            do
            {
                fx = f(curX);
                result += fx * step;
                curX += step;
            }
            while (curX <= end);

            return result; 
        }
	}
}

