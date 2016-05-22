using CoordControl.Core.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoordControl.Core
{
	/// <summary>
	/// Внутренний перегон в одном направлении движения
	/// </summary>
	public sealed class Way : IWay
	{
		/// <summary>
		/// Участки перегона
		/// </summary>
		public List<Region> Regions { get; set; }

		/// <summary>
		/// Информация о перегоне
		/// </summary>
		public Road EntityRoad { get; set; }

		/// <summary>
		/// Равен истине если направление движения слева направо
		/// </summary>
		public bool IsRightDirection { get; set; }


		/// <summary>
		/// Получение узла перекерестка,
		/// следующего после последнего участка перегона
		/// </summary>
		public NodeCross GetNextNodeCross()
		{
            return RouteEnvir.Instance.ListCross.First(
                (x) =>
                    (IsRightDirection) && x.GetLeftEntryWay().Equals(this)
                    || (!IsRightDirection) && x.GetRightEntryWay().Equals(this)
                );
		}

		/// <summary>
		/// Получение первого участка перегона
		/// </summary>
		public Region GetRegionFirst()
		{
            return Regions[0];
		}

		/// <summary>
		/// Получение последнего участка перегона
		/// </summary>
		public Region GetRegionLast()
		{
            return Regions.Last();
        }

        /// <summary>
        /// Расчет коэффициента, определяющего замедление ТС
        /// вследствие понижения манев-ренности ТС при повышении плотности ТП
        /// </summary>
        /// <returns></returns>
        public static double CalcDensityCoef(int lineCount, double maxSpeed)
        {
            double densityMax = (1.0 / ModelConst.CAR_LENGTH * lineCount);
            double densityCoef = (maxSpeed / ModelConst.SPEED_COEF / 2.0) / densityMax;

            return densityCoef;
        }

		/// <summary>
		/// Перемещение ТП за интервал сканирования
		/// в районе внутреннего перегона
		/// </summary>
		public void RunSimulationStep()
		{
            for (int i = Regions.Count-2; i >= 0; i--)
            {
                double avgDensity = (Regions[i+1].FlowPart
                    + Regions[i].FlowPart + ((i > 0) ? Regions[i-1].FlowPart : 0)) /
                    (Regions[i+1].Lenght + ((i > 0) ? Regions[i-1].Lenght : 0) + Regions[i].Lenght);

                double densityCoef = Way.CalcDensityCoef(GetInfo().LinesCount, EntityRoad.Speed);
                double velocity = (EntityRoad.Speed / ModelConst.SPEED_COEF) - densityCoef * avgDensity;
                

                //часть ТП, перемещаемая с региона i на i+1
                double deltaFP = Regions[i].FlowPart / Regions[i + 1].Lenght
                    * velocity * RouteEnvir.Instance.TimeScan;

                double RealDeltaFP = Regions[i].Move(Regions[i + 1], deltaFP);

                if (RealDeltaFP != 0)
                    Regions[i+1].Velocity = velocity;
                else
                    Regions[i+1].Velocity = 0;
            }
		}


        /// <summary>
        /// получении входа к перекерестку
        /// соответвующего концу перегона
        /// содержит информацию о данном перегоне
        /// </summary>
        /// <returns></returns>
        public Pass GetInfo()
        {
            if (IsRightDirection)
                return EntityRoad.CrossRight.PassLeft;
            else
                return EntityRoad.CrossLeft.PassRight;
        }

		public Way(Road road, bool isRightDirection)
		{
            EntityRoad = road;
            IsRightDirection = isRightDirection;
		}


        /// <summary>
        /// Создание участков данного перегона
        /// </summary>
        public void CreateRegions()
        {
            double lengthMin = ((double)EntityRoad.Speed) / ModelConst.SPEED_COEF * RouteEnvir.Instance.TimeScan;
            int RegionsN = (int) Math.Floor((double)EntityRoad.Length / lengthMin);
            double length = (double)EntityRoad.Length / (double)RegionsN;

            Regions = new List<Region>();
            for (int i = 0; i < RegionsN; i++)
            {
                Region newRegion = new Region(this, length);
                Regions.Add(
                    newRegion
                    );
            }

        }
    }
}

