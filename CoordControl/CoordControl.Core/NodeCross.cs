﻿using CoordControl.Core.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoordControl.Core
{
	/// <summary>
	/// Перекресток как узел УДС
	/// </summary>
	public sealed class NodeCross
	{
		/// <summary>
		/// Участок перекрестка
		/// </summary>
		public RegionCross CrossRegion { get; set; }

		/// <summary>
		/// Перекресток узла
		/// </summary>
		public Cross EntityCross { get; set; }

		/// <summary>
		/// Получение левого входного перегона
		/// </summary>
		public IWay GetLeftEntryWay()
		{
            return RouteEnvir.Instance.ListWays.First(
                (x) =>
                    ((x is Way) && ((Way)x).IsRightDirection
                        && ((Way)x).EntityRoad.CrossRight != null && (((Way)x).EntityRoad.CrossRight.ID == EntityCross.ID))

                    ||
                    ((x is WayEntry) && (((WayEntry)x).EntityPass.CrossLeftPass != null)
                    && (((WayEntry)x).EntityPass.CrossLeftPass.ID == EntityCross.ID))
                );
		}

		/// <summary>
		/// Получение левого выходного перегона
		/// </summary>
		public IWay GetLeftExitWay()
		{
            return RouteEnvir.Instance.ListWays.First(
                    (x) =>
                        ((x is Way) && !((Way)x).IsRightDirection
                        && ((Way)x).EntityRoad.CrossRight != null && (((Way)x).EntityRoad.CrossRight.ID == EntityCross.ID))
                        ||
                        ((x is WayExit) && (((WayExit)x).EntityPass.CrossRightPass != null)
                        && (((WayExit)x).EntityPass.CrossRightPass.ID == EntityCross.ID))
                    );
        }

		/// <summary>
		/// Получение правого входного перегона
		/// 
		/// </summary>
		public IWay GetRightEntryWay()
		{
            return RouteEnvir.Instance.ListWays.First(
                            (x) =>
                                ((x is Way) && !((Way)x).IsRightDirection
                                    && ((Way)x).EntityRoad.CrossLeft != null && (((Way)x).EntityRoad.CrossLeft.ID == EntityCross.ID))

                                ||
                                ((x is WayEntry) && (((WayEntry)x).EntityPass.CrossRightPass != null)
                                && (((WayEntry)x).EntityPass.CrossRightPass.ID == EntityCross.ID))
                            );
        }

		/// <summary>
		/// Получение правого выходного перегона
		/// </summary>
		public IWay GetRightExitWay()
		{
            return RouteEnvir.Instance.ListWays.First(
                    (x) =>
                        ((x is Way) && ((Way)x).IsRightDirection
                        && ((Way)x).EntityRoad.CrossLeft != null && (((Way)x).EntityRoad.CrossLeft.ID == EntityCross.ID))
                        ||
                        ((x is WayExit) && (((WayExit)x).EntityPass.CrossLeftPass != null)
                        && (((WayExit)x).EntityPass.CrossLeftPass.ID == EntityCross.ID))
                    );
		}

		/// <summary>
		/// Получение верхнего входного перегона
		/// </summary>
		public IWay GetTopEntryWay()
		{
            return RouteEnvir.Instance.ListWays.First(
                (x) =>
                    ((x is WayEntry) && (((WayEntry)x).EntityPass.CrossTopPass != null)
                    && (((WayEntry)x).EntityPass.CrossTopPass.ID == EntityCross.ID))
                );
        }

		/// <summary>
		/// Получение верхнего выходного перегона
		/// 
		/// </summary>
		public IWay GetTopExitWay()
		{
            return RouteEnvir.Instance.ListWays.First(
                (x) =>
                    ((x is WayExit) && (((WayExit)x).EntityPass.CrossBottomPass != null)
                    && (((WayExit)x).EntityPass.CrossBottomPass.ID == EntityCross.ID))
                );
		}

		/// <summary>
		/// Получение нижнего входного перегона
		/// </summary>
		public IWay GetBottomEntryWay()
		{
            return RouteEnvir.Instance.ListWays.First(
                (x) =>
                    ((x is WayEntry) && (((WayEntry)x).EntityPass.CrossBottomPass != null)
                    && (((WayEntry)x).EntityPass.CrossBottomPass.ID == EntityCross.ID))
                );
		}

		/// <summary>
		/// Получение нижнего выходного перегона
		/// </summary>
		public IWay GetBottomExitWay()
		{
            return RouteEnvir.Instance.ListWays.First(
                (x) =>
                    ((x is WayExit) && (((WayExit)x).EntityPass.CrossTopPass != null)
                    && (((WayExit)x).EntityPass.CrossTopPass.ID == EntityCross.ID))
                );
		}

		/// <summary>
		/// Получение плана текущего перекрестка
		/// </summary>
		public CrossPlan GetCrossPlan()
		{
			return RouteEnvir.Instance.EntityPlan.CrossPlans.First(
                (x) => (x.Cross != null) && (x.Cross.ID == EntityCross.ID)
                );
		}

        /// <summary>
        /// расчет сдвига фаз относительно нулевого перекрестка
        /// </summary>
        /// <returns></returns>
        public int CalcPhaseOffset()
        {
            int result = 0;
            List<CrossPlan> cps = RouteEnvir.Instance.EntityPlan.CrossPlans.ToList();
            foreach (CrossPlan cp in cps)
            {
                if (cp.Cross.Position <= EntityCross.Position)
                    result += cp.PhaseOffset;
            }

            return result;
        }

        /// <summary>
        /// Расчет скорости на второстепенной улице
        /// как максимальная скорость среди
        /// левого и правого перегона
        /// </summary>
        /// <returns></returns>
        private double CalcVerticalSpeed() {
            double result = 0;
            IWay leftEntry = GetLeftEntryWay();
            if(leftEntry is Way)
                result = ((Way)leftEntry).EntityRoad.Speed;

            IWay rightEntry = GetRightEntryWay();
            if ((rightEntry is Way) && ((Way)rightEntry).EntityRoad.Speed > result)
                result = ((Way)rightEntry).EntityRoad.Speed;

            return result;
        }


        /// <summary>
        /// Перемещение ТП с перегона на перекресток
        /// </summary>
        /// <param name="wFrom">перегон, с которого происходит перемещение</param>
        /// <param name="speed">скорость перемещения</param>
        /// <returns>Фактически перемещенная часть ТП</returns>
        private double MoveToCross(IWay wFrom, double speed, bool isHorisontal)
        {
            double avgDensity = wFrom.GetRegionLast().GetDensity();
            double densityCoef = Way.CalcDensityCoef(wFrom.GetInfo().LinesCount, speed);
            double velocity = CalcSpeedCoef() * ((speed / 3.6) - densityCoef * avgDensity);

            double deltaFP = wFrom.GetRegionLast().FlowPart / ((isHorisontal) ? CrossRegion.Lenght : CrossRegion.Width)
                * velocity * RouteEnvir.Instance.TimeScan;

            deltaFP = CrossRegion.MoveToCross(wFrom.GetRegionLast(), deltaFP);
            wFrom.GetRegionLast().Velocity = velocity;
            CrossRegion.Intensity += (deltaFP / RouteEnvir.Instance.TimeScan) * 3600;

            return deltaFP;
        }


        /// <summary>
        /// Перемещение ТП с перекрестка на перегон
        /// </summary>
        /// <param name="wTo">перегон, на который идет перемещение</param>
        /// <param name="flowPartSource">часть пототка перекрестка</param>
        /// <param name="speed">максимальная скорость перемещения</param>
        /// <param name="isHorisontal">горизонтальная ли улица для перемещения</param>
        /// <returns>Фактически перемещенная часть ТП</returns>
        private double MoveFromCross(IWay wTo, ref double flowPartSource, double speed, bool isHorisontal)
        {
            double avgDensity = CrossRegion.GetDensity();
            double densityCoef = Way.CalcDensityCoef(wTo.GetInfo().LinesCount, speed);
            double velocity = ((speed / 3.6) - densityCoef * avgDensity);
            double deltaFP = flowPartSource / ((isHorisontal) ? CrossRegion.Lenght : CrossRegion.Width)
                * velocity * RouteEnvir.Instance.TimeScan;

            deltaFP = CrossRegion.MoveFromCross(wTo.GetRegionFirst(), ref flowPartSource, deltaFP);

            wTo.GetRegionFirst().Velocity = velocity;
            CrossRegion.Intensity += (deltaFP / RouteEnvir.Instance.TimeScan) * 3600;

            return deltaFP;
        }


        /// <summary>
		/// Перемещение ТП за интервал сканирования: части ТП забираются с подходов
        /// части ТП перемещаются
		/// </summary>
        public void RunSimulationStep()
        {
            CrossRegion.Intensity = 0;

            //перемещение ТП с перекрестка на выходные перегоны
            IWay leftExit = GetLeftExitWay();
            double leftExitSpeed = 80;
            if (leftExit is Way)
                leftExitSpeed = ((Way)leftExit).EntityRoad.Speed;
            else if (leftExit is WayExit)
                leftExitSpeed = ((WayExit)leftExit).GetInternalRoad().Speed;

            MoveFromCross(leftExit, ref CrossRegion.ToLeftFlowPart, leftExitSpeed, true);

            IWay rightExit = GetLeftExitWay();
            double rightExitSpeed = 80;
            if (rightExit is Way)
                rightExitSpeed = ((Way)rightExit).EntityRoad.Speed;
            else if (rightExit is WayExit)
                rightExitSpeed = ((WayExit)rightExit).GetInternalRoad().Speed;

            MoveFromCross(leftExit, ref CrossRegion.ToRightFlowPart, rightExitSpeed, true);

            IWay topExit = GetTopExitWay();
            MoveFromCross(topExit, ref CrossRegion.ToTopFlowPart, CalcVerticalSpeed(), false);
            
            IWay botExit = GetBottomExitWay();
            MoveFromCross(botExit, ref CrossRegion.ToBottomFlowPart, CalcVerticalSpeed(), false);

            //перемещение с перегонов на перекресток
            if (GetLightStateFirst() == LightState.Green || GetLightStateFirst() == LightState.YellowRed)
            {
                IWay leftWay = GetLeftEntryWay();
                double leftSpeed = 80;
                if(leftWay is Way)
                    leftSpeed = ((Way)leftWay).EntityRoad.Speed;
                else if(leftWay is WayEntry)
                    leftSpeed = ((WayEntry)leftWay).GetInternalRoad().Speed;


                double deltaFP = MoveToCross(leftWay, leftSpeed, true);
                CrossRegion.ToRightFlowPart += deltaFP * leftWay.GetInfo().DirectPart / 100.0;
                CrossRegion.ToBottomFlowPart += deltaFP * leftWay.GetInfo().RightPart / 100.0;
                CrossRegion.ToTopFlowPart += deltaFP * leftWay.GetInfo().LeftPart / 100.0;

                IWay rightWay = GetRightEntryWay();
                double rightSpeed = 80;

                if (rightWay is Way)
                    rightSpeed = ((Way)rightWay).EntityRoad.Speed;
                else if (leftWay is WayEntry)
                    rightSpeed = ((WayEntry)rightWay).GetInternalRoad().Speed;

                deltaFP = MoveToCross(rightWay, rightSpeed, true);
                CrossRegion.ToLeftFlowPart += deltaFP * rightWay.GetInfo().DirectPart / 100.0;
                CrossRegion.ToTopFlowPart += deltaFP * rightWay.GetInfo().RightPart / 100.0;
                CrossRegion.ToBottomFlowPart += deltaFP * rightWay.GetInfo().LeftPart / 100.0;
            }
            else if (GetLightStateSecond() == LightState.Green || GetLightStateSecond() == LightState.YellowRed)
            {
                IWay way = GetTopEntryWay();
                double deltaFP = MoveToCross(way, CalcVerticalSpeed(), false);
                CrossRegion.ToBottomFlowPart += deltaFP * way.GetInfo().DirectPart / 100.0;
                CrossRegion.ToLeftFlowPart += deltaFP * way.GetInfo().RightPart / 100.0;
                CrossRegion.ToRightFlowPart += deltaFP * way.GetInfo().LeftPart / 100.0;

                way = GetBottomEntryWay();
                deltaFP = MoveToCross(way, CalcVerticalSpeed(), false);
                CrossRegion.ToTopFlowPart += deltaFP * way.GetInfo().DirectPart / 100.0;
                CrossRegion.ToRightFlowPart += deltaFP * way.GetInfo().RightPart / 100.0;
                CrossRegion.ToLeftFlowPart += deltaFP * way.GetInfo().LeftPart / 100.0;
            }
        }

        /// <summary>
        /// Коэффициент уменьшения скорости на начале зеленого
        /// и на желтом сигнале светофора
        /// </summary>
        /// <returns></returns>
        private double CalcSpeedCoef() {
            LightState light1 = GetLightStateFirst();
            LightState light2 = GetLightStateSecond();

            double speedCoef = 1;

            if (light1 == LightState.Yellow || light2 == LightState.Yellow)
                speedCoef = 0.5;
            else
            {
                if(GreenTime > 6.0)
                    speedCoef = 1.0;
                else
                    speedCoef = GreenTime / 6.0;
            }

            return speedCoef;
        }


		/// <summary>
		/// Получение состояния светофоров первой группы
		/// (разрешает движение по магистральной улице во время первого такта)
		/// </summary>
        private double GreenTime;
		public LightState GetLightStateFirst()
		{
            double timeOfCycle = (RouteEnvir.Instance.TimeCurrent + CalcPhaseOffset())
                % RouteEnvir.Instance.EntityPlan.Cycle;
            CrossPlan cp = GetCrossPlan();

            int t;
            if (timeOfCycle <= (t = cp.P1MainInterval))
            {
                GreenTime = timeOfCycle;
                return LightState.Green;
            }
            else if (timeOfCycle <= (t += cp.P1MediateInterval))
                return LightState.Yellow;
            else if (timeOfCycle <= (t += cp.P2MainInterval))
                return LightState.Red;
            else
                return LightState.YellowRed;
		}

		/// <summary>
		/// Получение состояния светофоров второй группы
		/// (разрешает движение по второстепенной улице во время второго такта)
		/// </summary>
		public LightState GetLightStateSecond()
		{
            double timeOfCycle = (RouteEnvir.Instance.TimeCurrent + CalcPhaseOffset()) % RouteEnvir.Instance.EntityPlan.Cycle;
            CrossPlan cp = GetCrossPlan();

            int t;
            if (timeOfCycle <= (t = cp.P1MainInterval))
                return LightState.Red;
            else if (timeOfCycle <= (t += cp.P1MediateInterval))
                return LightState.YellowRed;
            else if (timeOfCycle <= (t += cp.P2MainInterval))
            {
                GreenTime = timeOfCycle - cp.P1MediateInterval - cp.P1MainInterval;
                return LightState.Green;
            }
            else
                return LightState.Yellow;
        }

		public NodeCross(Cross cross)
		{
            EntityCross = cross;
            CrossRegion = new RegionCross(this); 
		}

	}
}
