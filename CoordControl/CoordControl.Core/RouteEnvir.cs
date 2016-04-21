using CoordControl.Core.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoordControl.Core
{
	/// <summary>
	/// Среда имитационного моделирования
	/// движения ТП на магистрали.
	/// Паттерн Одиночка
	/// </summary>
	public sealed class RouteEnvir
	{
		/// <summary>
		/// Магистраль, на которой происходит моделирование
		/// </summary>
        public Route EntityRoute { get; private set; }


        /// <summary>
        /// Моделируемая программа коориднации
        /// </summary>
        private Plan _plan;
        public Plan EntityPlan {
            get {
                return _plan;
            }

            set {
                _plan = value;
                EntityRoute = value.Route; 
                MakeEnrironment();
            }
        }

		/// <summary>
		/// Текущее модельное время
		/// </summary>
		public double TimeCurrent { get; set; }

		/// <summary>
		/// Интервал сканирования
		/// </summary>
		public double TimeScan { get; set; }

		/// <summary>
		/// список перегонов УДС
		/// </summary>
		public List<IWay> ListWays { get; set; }

		/// <summary>
		/// Список перекрестков-узлов УДС
		/// </summary>
		public List<NodeCross> ListCross { get; set; }

		/// <summary>
		/// Объект-одиночка
		/// </summary>
        private static RouteEnvir instance = null;
		public static RouteEnvir Instance {
            get
            {
                if (instance == null)
                    instance = new RouteEnvir();

                return instance;
            }
        }

		/// <summary>
		/// Перемещение ТП за интервал сканирования
		/// </summary>
		public void RunSimulationStep()
		{
			throw new System.NotImplementedException();
		}

		/// <summary>
		/// Сброс состояния класса-одиночки
		/// </summary>
		public void ResetInstance()
		{
            instance = null;
		}

		private RouteEnvir()
		{
            TimeCurrent = 0;
            TimeScan = 1;
		}

		/// <summary>
		/// Получение суммы приведенных средних задержек
		/// на всех перекрестках за заданный контрольный интервал.
		/// Приведение осуществляется по интенсивностям подходов
		/// </summary>
		/// <param name="int intervaNum">номер контрольного интервала (индекс в списке истории замеров средней задержки)</param>
		public double GetStatAvgDelay(int intervaNum)
		{
			throw new System.NotImplementedException();
		}

		/// <summary>
		/// Получение текущей средней задержки ТС
		/// </summary>
		public void GetStatAvgDelayCurrent()
		{
			throw new System.NotImplementedException();
		}

		/// <summary>
		/// Получение последней средней задержки ТС
		/// </summary>
		public void GetStatAvgDelayLast()
		{
			throw new System.NotImplementedException();
		}

		/// <summary>
		/// Получение величины контрольного интервала
		/// для измерения статистики магистрали
		/// </summary>
		public double CalcMeasureInterval()
		{
            return (double) (EntityRoute.CrossCount * EntityPlan.Cycle);
		}

        /// <summary>
        /// Получение полной длины магистрали
        /// </summary>
        public double CalcFullRouteLength()
        {
            double result = 0;

            foreach(NodeCross ndCr in ListCross)
                result += ndCr.CrossRegion.Lenght;

            foreach (IWay way in ListWays)
            {
                if (way is Way && ((Way)way).IsRightDirection)
                    result += ((Way)way).EntityRoad.Length;
            }

            NodeCross nodeCrossFirst = ListCross.First(
                (x) => x.EntityCross.Equals(EntityRoute.Crosses.First())
                );
            double entryWay = nodeCrossFirst.GetLeftEntryWay().GetRegionLast().Lenght;
            double exitWay = nodeCrossFirst.GetLeftExitWay().GetRegionFirst().Lenght;
            result += (entryWay > exitWay) ? entryWay : exitWay;

            NodeCross nodeCrossLast = ListCross.First(
                (x) => x.EntityCross.Equals(EntityRoute.Crosses.Last())
                );
            entryWay = nodeCrossLast.GetRightEntryWay().GetRegionLast().Lenght;
            exitWay = nodeCrossLast.GetRightExitWay().GetRegionFirst().Lenght;
            result += (entryWay > exitWay) ? entryWay : exitWay;

            return result;
        }

        /// <summary>
        /// Создание объектов перекрестков
        /// и перегонов, представляющих собой окружение
        /// </summary>
        private void MakeEnrironment()
        {
            ListWays = new List<IWay>();
            ListCross = new List<NodeCross>();


            foreach(Cross cr in EntityRoute.Crosses)
            {
                NodeCross nc = new NodeCross(cr);
                ListCross.Add(nc);
            }

            #region создание перегонов в прямом и обратном направлениях
            Cross cross = EntityRoute.Crosses.First();
            while(cross.RoadRight != null)
            {
                Road road = cross.RoadRight;
                Way way = new Way(road, true);
                way.CreateRegions();
                ListWays.Add(way);
                cross = road.CrossRight;
            }

            cross = EntityRoute.Crosses.Last();
            while (cross.RoadLeft != null)
            {
                Road road = cross.RoadLeft;
                Way way = new Way(road, false);
                way.CreateRegions();
                ListWays.Add(way);
                cross = road.CrossLeft;
            }
            #endregion

            #region создание входов и выходов крайних перекрестков
            Cross crossFirst = EntityRoute.Crosses.First();
            WayEntry wayEntryFirst = new WayEntry(crossFirst.PassLeft);
            ListWays.Add(wayEntryFirst);
            WayExit wayExitFirst = new WayExit(crossFirst.PassRight);
            ListWays.Add(wayExitFirst);

            Cross crossLast = EntityRoute.Crosses.Last();
            WayEntry wayEntryLast = new WayEntry(crossLast.PassRight);
            ListWays.Add(wayEntryLast);
            WayExit wayExitLast = new WayExit(crossLast.PassLeft);
            ListWays.Add(wayExitLast);
            #endregion

            #region создание верхиних и нижних входов и выходов для всех перекрестков
            foreach (Cross cr in EntityRoute.Crosses)
            {
                WayEntry wayEntryTop = new WayEntry(cr.PassTop);
                ListWays.Add(wayEntryTop);
                WayExit wayExitTop = new WayExit(cr.PassBottom);
                ListWays.Add(wayExitTop);

                WayEntry wayEntryBot = new WayEntry(cr.PassBottom);
                ListWays.Add(wayEntryBot);
                WayExit wayExitBot = new WayExit(cr.PassTop);
                ListWays.Add(wayExitBot);
            }
            #endregion

        }

	}
}

