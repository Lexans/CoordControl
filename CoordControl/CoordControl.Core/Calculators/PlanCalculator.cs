using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CoordControl.Core.Domains;

namespace CoordControl.Core
{
	public abstract class PlanCalculator
	{
		public PlanCalculator()
		{
		}

        /// <summary>
        /// расчет цикла регулирования на локальном перекерестке.
        /// должны быть рассчитаны промежуточные интервалы
        /// </summary>
        /// <param name="crP">план координации перекрестка</param>
        /// <returns>длительность цикла регулирования</returns>
		private int CalcCycle(CrossPlan crP)
		{
			int Cycle = (int) (
                (1.5 * (crP.P1MediateInterval + crP.P2MediateInterval) + 5.0)
                / (1 - (CalcPhaseCoef(crP.Cross, 1) + CalcPhaseCoef(crP.Cross, 2)))
            );

            if (Cycle < 25)
                Cycle = 25;
            else if(Cycle > 70)
                Cycle = 70;

            return Cycle;
		}


        /// <summary>
        /// расчет величин сдвигов фаз на каждом перекрестке магистрали
        /// </summary>
        /// <param name="p"></param>
        protected abstract void CalcPhaseShifts(Plan p);


        protected double CalcLengthRoadWithCross(Cross cr) {
            double Lenght = cr.RoadLeft.Length;
            Pass entryTopPass = cr.RoadLeft.CrossLeft.PassTop;
            Lenght += entryTopPass.LinesCount * entryTopPass.LineWidth;
            Pass entryBottomPass = cr.RoadLeft.CrossLeft.PassBottom;
            Lenght += entryBottomPass.LinesCount * entryBottomPass.LineWidth;

            return Lenght;
        }

        /// <summary>
        /// расчет потока насыщения на подходе
        /// </summary>
        /// <param name="p">подход, на котором расчитывается поток насыщения</param>
        /// <returns>величина потока насыщения</returns>
		public static int CalcMaxFlow(Pass p)
		{
            int maxFlow = 0;
            double width = p.LinesCount * p.LineWidth;

            if (width >= 3 && width <= 5.1)
            {
                if (width <= 3.3)
                    maxFlow = (int)(1850 + (25 / 0.3) * (width - 3));
                else if (width <= 3.5)
                    maxFlow = (int)(1875 + (50 / 0.2) * (width - 3.3));
                else if (width <= 3.6)
                    maxFlow = (int)(1920 + (30 / 0.1) * (width - 3.5));
                else if (width <= 3.75)
                    maxFlow = (int)(1950 + (20 / 0.15) * (width - 3.6));
                else if (width <= 4.2)
                    maxFlow = (int)(1970 + (105 / 0.45) * (width - 3.75));
                else if (width <= 4.8)
                    maxFlow = (int)(2075 + (400 / 0.6) * (width - 4.2));
                else if (width <= 5.1)
                    maxFlow = (int)(2475 + (225 / 0.3) * (width - 4.8));
            }
            else if (width <= 18)
                maxFlow = (int)(525.0 * width);
            else
                throw new Exception("Ширина проезжей часть должна быть в пределах от 3 до 18");

            if ((p.LeftPart + p.RightPart) > 10)
                maxFlow = (int)(maxFlow * 100.0 / (p.DirectPart + 1.75 * p.LeftPart + 1.25 * p.RightPart));

            return maxFlow;
		}

        /// <summary>
        /// расчет полной программы координации на магистрали
        /// </summary>
        /// <param name="r">магистраль для расчета программы координации</param>
        /// <returns>расчитанная программа координации</returns>
		public virtual Plan CalcFullPlan(Route r)
		{
            Plan p = new Plan();
            p.Route = r;
  
            p.CrossPlans = new HashSet<CrossPlan>();
            foreach(Cross cr in r.Crosses)
            {
                CrossPlan crP = new CrossPlan();
                crP.Plan = p;
                crP.Cross = cr;

                CalcMediateIntervals(crP);
                p.CrossPlans.Add(crP);
            }

            CalcCycle(p);
            foreach(CrossPlan crP in p.CrossPlans)
                CalcMainIntervals(crP);

            CalcPhaseShifts(p);

            return p;
		}

        /// <summary>
        /// расчет цикла регулирования, общего для всеё магистали
        /// должны быть расчитаны переходные интервалы
        /// </summary>
        /// <param name="plan">программа координации магисрали</param>
		private void CalcCycle(Plan plan)
		{
            int routeCycle = 25;
            foreach (CrossPlan crP in plan.CrossPlans)
            {
                int crCycle =  CalcCycle(crP);
                if (crCycle > routeCycle)
                    routeCycle = crCycle;
            }

            plan.Cycle = routeCycle;
		}


        /// <summary>
        /// расчет длительности основных тактов. должны быть расчитаны цикл и промежуточные интервалы
        /// </summary>
        /// <param name="crPlan">план перекрестка, на котором расчитваются основные такты</param>
		private void CalcMainIntervals(CrossPlan crPlan)
		{
            int cycle = crPlan.Plan.Cycle;
            int mediateIntervals =
                crPlan.P1MediateInterval + crPlan.P2MediateInterval;
            double phaseCoefSum = CalcPhaseCoef(crPlan.Cross, 1) + CalcPhaseCoef(crPlan.Cross, 2);

            crPlan.P1MainInterval = (int) (
                (cycle - mediateIntervals) /
                phaseCoefSum * CalcPhaseCoef(crPlan.Cross, 1)
                );

            if (crPlan.P1MainInterval < 7) crPlan.P1MainInterval = 7;

            crPlan.P2MainInterval = cycle - mediateIntervals - crPlan.P1MainInterval;
        }

        /// <summary>
        /// расчет длительности промежуточных интервалов
        /// </summary>
        /// <param name="cp"></param>
		private void CalcMediateIntervals(CrossPlan cp)
		{
            double velosity;
            Cross cr = cp.Cross;

            if(cr.RoadLeft != null)
                velosity = cr.RoadLeft.Speed;
            else if(cr.RoadRight != null)
                velosity = cr.RoadRight.Speed;
            else
                velosity = (cr.RoadRight.Speed + cr.RoadLeft.Speed) / 2;

            double lenRoadVertical = (cr.PassTop.LinesCount * cr.PassTop.LineWidth)
                + (cr.PassTop.LinesCount * cr.PassTop.LineWidth);
            double lenRoadHorisont = (cr.PassLeft.LinesCount * cr.PassLeft.LineWidth)
                + (cr.PassRight.LinesCount * cr.PassRight.LineWidth);


            int p1MediateCar = (int)(velosity / (7.2 * 3.5) + ModelConst.SPEED_COEF * (lenRoadVertical + ModelConst.CAR_LENGTH) / velosity);
            int p1MediatePedestrian = (int)(lenRoadHorisont / (4 * 1.3));
            int p1Mediate = (p1MediateCar > p1MediatePedestrian) ? p1MediateCar : p1MediatePedestrian;
            if (p1Mediate > 8)
                p1Mediate = 8;
            else if (p1Mediate < 3)
                p1Mediate = 3;
            cp.P1MediateInterval = p1Mediate;


            int p2MediateCar = (int)(velosity / (7.2 * 3.5) + ModelConst.SPEED_COEF * (lenRoadHorisont + ModelConst.CAR_LENGTH) / velosity);
            int p2MediatePedestrian = (int)(lenRoadVertical / (4 * 1.3));
            int p2Mediate = (p2MediateCar > p2MediatePedestrian) ? p2MediateCar : p2MediatePedestrian;
            if (p2Mediate > 8)
                p2Mediate = 8;
            else if (p2Mediate < 3)
                p2Mediate = 3;
            cp.P2MediateInterval = p2Mediate;
        }


        /// <summary>
        /// расчет фазового коэффеициента
        /// </summary>
        /// <param name="cr">перекресток, на котором рассчитваются фазовые коэффициенты</param>
        /// <param name="phaseNum">номер фазы</param>
        /// <returns>значение фазового коэффициента</returns>
		private double CalcPhaseCoef(Cross cr, int phaseNum)
		{
            double result = 0;
            double y1, y2;

            switch (phaseNum)
            {
                case 1:
                    y1 = cr.PassLeft.Intensity / (double) CalcMaxFlow(cr.PassLeft);
                    y2 = cr.PassRight.Intensity / (double) CalcMaxFlow(cr.PassRight);
                    result = (y1 > y2) ? y1 : y2;
                    break;
                case 2:
                    y1 = cr.PassTop.Intensity / (double) CalcMaxFlow(cr.PassTop);
                    y2 = cr.PassBottom.Intensity / (double) CalcMaxFlow(cr.PassBottom);
                    result = (y1 > y2) ? y1 : y2;
                    break;
                
                default:
                    throw new Exception("Номер фазы должен быть 1 или 2");
            }

            return result;
		}



	}
}

