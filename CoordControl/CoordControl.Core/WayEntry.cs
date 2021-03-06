﻿using CoordControl.Core.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoordControl.Core
{
	/// <summary>
	/// Входной перегон
	/// </summary>
	public sealed class WayEntry : IWay
	{
		/// <summary>
		/// Граничный участок, на котором
		/// происход появление новых ТС
		/// </summary>
		public Region RegionBoundary { get; set; }

		/// <summary>
		/// Участок входного перегона
		/// </summary>
		public Region RegionLast { get; set; }

		/// <summary>
		/// Параметры подхода перекрестка
		/// входного перегона
		/// </summary>
		public Pass EntityPass { get; set; }

        private static Random _random = new Random();

		/// <summary>
		/// Получение узла перекрестка, в
		/// который впадает данный входной перегон
		/// </summary>
		public NodeCross GetNextNodeCross()
		{
            return RouteEnvir.Instance.ListCross.First(
                (x) =>
                    x.GetTopEntryWay().Equals(this) ||
                    x.GetBottomEntryWay().Equals(this) ||
                    x.GetLeftEntryWay().Equals(this) ||
                    x.GetRightEntryWay().Equals(this)
                );
		}

		/// <summary>
		/// Получение первого участка перегона
		/// </summary>
		public Region GetRegionFirst()
		{
            return RegionBoundary;
		}

		/// <summary>
		/// Получение последнего участка перегона
		/// </summary>
		public Region GetRegionLast()
		{
            return RegionLast;
		}


		/// <summary>
		/// Перемещение ТП за интервал сканирования
		/// в районе входного перегона
		/// </summary>
		public void RunSimulationStep()
		{
            //перемещение с граниченого участка на поледний
            double avgDensity = RegionLast.GetDensity();

            double densityCoef = Way.CalcDensityCoef(GetInfo().LinesCount, GetInternalRoad().Speed);
            double velocity = (GetInternalRoad().Speed / ModelConst.SPEED_COEF) - densityCoef * avgDensity;

            double deltaFP = RegionBoundary.FlowPart / RegionLast.Lenght
                * velocity * RouteEnvir.Instance.TimeScan;

            RegionBoundary.Move(RegionLast, deltaFP);

            if (deltaFP != 0)
            {
                RegionBoundary.Velocity = velocity;
            }

            //появление ТП на граничном участке
            RegionBoundary.FlowPart += GetPuassonSample(
                EntityPass.Intensity / ModelConst.SEC_PER_HOUR * RouteEnvir.Instance.TimeScan
                );
		}


		/// <summary>
		/// Получение реализации случайной величины, распределенной по закону Пуассона
		/// </summary>
		/// <param name="lambda">Параметр распределения Пуассона</param>
		private int GetPuassonSample(double lambda)
		{
            double r = _random.NextDouble() * Math.Exp(lambda);

            double ps = 0;
            double psMax = Math.Exp(lambda);

            int s = 0;
            while ((ps < r) && (ps <= psMax))
            {
                ps += Math.Pow(lambda, (double)s) / Factorial(s);
                s++;
            }
            
            return s-1;
		}

        /// <summary>
        /// вычисление факториала
        /// </summary>
        private double Factorial(int n)
        {
            double res = 1;
            for (int i = 2; i <= n; i++)
                res *= i;

            return res;
        }

        /// <summary>
        /// получение информации о параметрах перегона
        /// </summary>
        /// <returns></returns>
        public Pass GetInfo()
        {
            return EntityPass;
        }

        public WayEntry(Pass pass)
        {
            EntityPass = pass;
            MakeRegions();
        }

        /// <summary>
        /// Получение перегона
        /// связанного с текущим входом
        /// </summary>
        public Road GetInternalRoad() {
            Cross cr = EntityPass.Cross;
            Road result;

            if (cr.RoadLeft != null && cr.RoadRight != null)
                result = (cr.RoadLeft.Speed > cr.RoadRight.Speed) ? cr.RoadLeft : cr.RoadRight;
            if (cr.RoadLeft == null)
                result = cr.RoadRight;
            else
                result = cr.RoadLeft;

            return result;
        }

        /// <summary>
        /// Создание участков
        /// </summary>
        private void MakeRegions()
        {
            double length = ((double)GetInternalRoad().Speed) / ModelConst.SPEED_COEF * RouteEnvir.Instance.TimeScan;
            RegionLast = new Region( this,
                length);
            RegionBoundary = new Region(this,
                length);
        }
    }
}

