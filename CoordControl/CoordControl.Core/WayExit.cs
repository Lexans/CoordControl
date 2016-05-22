using CoordControl.Core.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoordControl.Core
{
	/// <summary>
	/// Выходной перегон
	/// </summary>
	public sealed class WayExit : IWay
	{
		/// <summary>
		/// Участок выходного перегона
		/// </summary>
		public Region RegionFirst { get; set; }

		/// <summary>
		/// Граничный участок, на котором
		/// происходит 'исчезание' ТС
		/// </summary>
		public Region RegionBoundary { get; set; }

		/// <summary>
		/// Параметры выходного перегона
        /// (подход, противоположный стороне выхода)
		/// </summary>
		public Pass EntityPass { get; set; }

		/// <summary>
		/// Получение первого участка перегона
		/// </summary>
		public Region GetRegionFirst()
		{
            return RegionFirst;
        }

		/// <summary>
		/// Получение последнего участка перегона
		/// </summary>
		public Region GetRegionLast()
		{
            return RegionBoundary;
        }

		/// <summary>
		/// Перемещение ТП за интервал сканирования
		/// </summary>
		public void RunSimulationStep()
		{
            //перемещение с граниченого участка на поледний
            double avgDensity = RegionFirst.GetDensity();

            double densityCoef = Way.CalcDensityCoef(GetInfo().LinesCount, GetInternalRoad().Speed);
            double velocity = (GetInternalRoad().Speed / ModelConst.SPEED_COEF) - densityCoef * avgDensity;

            double deltaFP = RegionFirst.FlowPart / RegionBoundary.Lenght
                * velocity * RouteEnvir.Instance.TimeScan;

            RegionFirst.Move(RegionBoundary, deltaFP);

            if (deltaFP != 0)
            {
                RegionFirst.Velocity = velocity;
            }

            //появление ТП на граничном участке
            RegionBoundary.FlowPart = 0;
		}


		public WayExit(Pass pass)
		{
            EntityPass = pass;
            MakeRegions();
		}


        /// <summary>
        /// Получение перегона
        /// связанного с текущим входом
        /// </summary>
        public Road GetInternalRoad()
        {
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
            RegionFirst = new Region(this,
                length);
            RegionBoundary = new Region(this,
                length);
        }


        /// <summary>
        /// получения информации о параметрах выходного перегона
        /// </summary>
        public Pass GetInfo()
        {
            return EntityPass;
        }
    }
}

