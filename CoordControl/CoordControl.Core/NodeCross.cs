using CoordControl.Core.Domains;
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
		/// Получение состояния светофоров первой группы
		/// (разрешает движение по магистральной улице во время первого такта)
		/// </summary>
		public LightState GetLightStateFirst()
		{
            double timeOfCycle = (RouteEnvir.Instance.TimeCurrent + CalcPhaseOffset()) % RouteEnvir.Instance.EntityPlan.Cycle;
            CrossPlan cp = GetCrossPlan();

            int t;
            if (timeOfCycle <= (t = cp.P1MainInterval))
                return LightState.Green;
            else if (timeOfCycle <= (t += cp.P1MediateInterval))
                return LightState.Yellow;
            else if (timeOfCycle <= (t += cp.P2MainInterval))
                return LightState.Red;
            else
                return LightState.Yellow;
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
                return LightState.Yellow;
            else if (timeOfCycle <= (t += cp.P2MainInterval))
                return LightState.Green;
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

