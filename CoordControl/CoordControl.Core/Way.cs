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
		/// Общая задержка всех ТС за текущий цикл в сек
		/// Равна количеству ТС стоящих на подходе к перекрестку,
		/// умноженное на интервал сканирования
		/// </summary>
		public double StatDelay { get; set; }

		/// <summary>
		/// Количество ТС, проехваших перекересток
		/// за текущий контрольный интевал времени
		/// (единица измерения: автомобиль приведенный)
		/// </summary>
		public double StatCarMoved { get; set; }

		/// <summary>
		/// история средних задержек за контрольный период времени
		/// контрольный период времени = цикл * количество перекрестков
		/// Единица измерения: сек/авт
		/// </summary>
		public List<double> StatAvgDelays { get; set; }

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
            return Regions.First();
		}

		/// <summary>
		/// Получение последнего участка перегона
		/// </summary>
		public Region GetRegionLast()
		{
            return Regions.Last();
        }

		/// <summary>
		/// Перемещение ТП за интервал сканирования
		/// в районе внутреннего перегона
		/// </summary>
		public void RunSimulationStep()
		{
			throw new System.NotImplementedException();
		}

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
            StatDelay = StatCarMoved = 0;
            StatAvgDelays = new List<double>();
		}


        /// <summary>
        /// Создание участков данного перегона
        /// </summary>
        public void CreateRegions()
        {
            double lengthMin = ((double)EntityRoad.Speed) /3.6 * RouteEnvir.Instance.TimeScan;
            int RegionsN = (int) Math.Floor((double)EntityRoad.Length / lengthMin);
            double length = (double)EntityRoad.Length / (double)RegionsN;

            Regions = new List<Region>();
            for (int i = 0; i < RegionsN; i++)
                Regions.Add(
                    new Region(this, length)
                    );
        }
    }
}

