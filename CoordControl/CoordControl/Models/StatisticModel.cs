using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoordControl.Core;

namespace CoordControl.Models
{
    public class StatisticModel
    {
        /// <summary>
        /// Измерения задержек магистрали в прямом направлении
        /// </summary>
        public List<double> DelaysDirect {
            get
            {
                return RouteEnvir.Instance.DelaysDirect;
            }
        }

        /// <summary>
        /// Измерения задержек магистрали в обратном направлении
        /// </summary>
        public List<double> DelaysReverse
        {
            get
            {
                return RouteEnvir.Instance.DelaysReverse;
            }
        }

        /// <summary>
        /// Измерения задержек магистрали в обеих направлениях
        /// </summary>
        public List<double> DelaysSum
        {
            get
            {
                List<double> result = new List<double>();

                for (int i = 0; i < DelaysDirect.Count; i++)
                    result.Add(DelaysDirect[i] + DelaysReverse[i]);

                return result;
            }
        }

        public double CurrentDirect {
            get
            {
                return RouteEnvir.Instance.GetStatAvgDelayCurrent(true);
            }
        }
        public double CurrentReverse {
            get
            {
                return RouteEnvir.Instance.GetStatAvgDelayCurrent(false);
            }
        }
        public double CurrentSum
        {
            get
            {
                return CurrentDirect + CurrentReverse;
            }
        }


        public StatisticModel()
        {
        }

        public double CalcMx(List<double> list) {
            double result = 0;
            if (list.Count > 0)
                result = list.Sum() / (double)list.Count;

            return result;
        }

        public double CalcDx(List<double> list) {
            double result = 0;
            if (list.Count > 1) {
                double MX = CalcMx(list);
                result = 1d / (list.Count - 1) * list.Sum((xi) => Math.Pow((xi - MX), 2));
            }

            return result;
        }

        public double GetMeasurePeriod()
        {
            return RouteEnvir.Instance.CalcMeasureInterval();
        }

    }
}
