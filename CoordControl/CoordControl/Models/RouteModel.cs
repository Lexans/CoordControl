using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using CoordControl.Core.Domains;
using CoordControl.Data.DAO;
using CoordControl.Core;

namespace CoordControl.Models
{
    class RouteModel
    {
        private RouteDAO _dao;
        private Random _rand;

        public RouteModel()
        {
            _dao = new RouteDAO();
            _rand = new Random();
        }

        public void Save(Route route) {
            _dao.SaveOrUpdateAndCommit(route);
        }


        /// <summary>
        /// создает новую магистраль из 2 перекрестков
        /// и генерирует значения всех полей
        /// </summary>
        /// <returns></returns>
        public Route NewRoute()
        {
            Route r = new Route();
            r.StreetName = "";
            r.CrossCount = 2;
            r.Crosses = new List<Cross>();

            FixCrossCount(r);

            return r;   
        }


        /// <summary>
        /// досоздает новые перекрестки или убирает с конца,
        /// в случае если фактическое значение не совпадает с CrossCount
        /// </summary>
        /// <param name="r"></param>
        public void FixCrossCount(Route r) {
            int crCountReal = r.Crosses.Count;

            if (crCountReal > r.CrossCount) { //удаление лишних
                Cross lastCrs = r.Crosses[r.CrossCount - 1];
                lastCrs.RoadRight = null;
                
                for(int i = r.CrossCount; i < crCountReal; i++)
                    r.Crosses.Remove(r.Crosses.Last());

                IntensityCalc(r);
            }
            else if (crCountReal < r.CrossCount) //добавление новых
            {
                for (int i = crCountReal; i < r.CrossCount; i++)
                {
                    Cross cr = new Cross();
                    cr.StreetName = "Перекресток " + (i+1);
                    cr.Route = r;

                    #region создание объектов-перегонов
                    if (i < (r.CrossCount))
                    {
                        Road road = newRoad();
                        road.CrossLeft = cr;
                        cr.RoadRight = road;

                        if (crCountReal > 0)
                        {
                            if(r.Crosses[i - 1].RoadRight == null) {
                                Road road2 = newRoad();
                                road2.CrossLeft = r.Crosses[i - 1];
                                r.Crosses[i - 1].RoadRight = road2;
                            }
                            r.Crosses[i - 1].RoadRight.CrossRight = cr;
                        }

                        cr.RoadRight = road;
                    }
                    else
                        cr.RoadRight = null;

                    if (i > 0)
                    {
                        Road road = r.Crosses[i - 1].RoadRight;
                        cr.RoadLeft = road;
                        road.CrossRight = cr;
                    }
                    else
                        cr.RoadLeft = null;

                    #endregion

                    #region левый подход
                    Pass passLeft = newPass();
                    passLeft.CrossLeftPass = cr;
                    cr.PassLeft = passLeft;
                    #endregion

                    #region правый подход
                    Pass passRight = newPass();
                    passRight.CrossRightPass = cr;
                    cr.PassRight = passRight;
                    #endregion

                    #region верхний подход
                    Pass passTop = newPass();
                    passTop.CrossTopPass = cr;
                    cr.PassTop = passTop;
                    #endregion

                    #region нижний подход
                    Pass passBottom = newPass();
                    passBottom.CrossBottomPass = cr;
                    cr.PassBottom = passBottom;
                    #endregion

                    r.Crosses.Add(cr);
                    crCountReal++;
                }

                IntensityCalc(r);
                r.Crosses[r.CrossCount - 1].RoadRight = null;
            }
        }


        private Road newRoad()
        {
            Road road = new Road();

#if (DEBUG)
            road.Length = _rand.Next(100, 1000);
#else
                        road.Length = 300;
#endif
            road.Speed = (int)ModelConst.SPEED_DEFAULT;

            return road;
        }

        /// <summary>
        /// создование нового подхода
        /// со случайными пераметрами
        /// (кроме перекрестка, количества полос, интенсивностей)
        /// </summary>
        /// <returns></returns>
        private Pass newPass()
        {
            Pass p = new Pass();
            
#if (DEBUG)
            p.DirectPart = _rand.Next(70, 100);
            p.RightPart = _rand.Next(0, 100 - p.DirectPart);
            p.LeftPart = 100 - p.DirectPart - p.RightPart;
            p.LinesCount = _rand.Next(2, 4);
            for (int j = 0; j < p.LinesCount; j++)
                p.Intensity += _rand.Next(300, 700);
#else
            p.DirectPart = 80;
            p.RightPart = 15;
            p.LeftPart = 5;
            p.LinesCount = 3;
            p.Intensity = 1500;
#endif
            p.LineWidth = ModelConst.LINE_WIDTH_DEFAULT;

            return p;
        }


        /// <summary>
        /// согласованный пересчет интенсивностей на перекрестках
        /// в соответствии с интенсивностями узлов и частями потока
        /// </summary>
        /// <param name="r"></param>
        public void IntensityCalc(Route r)
        {
            
            IList<Cross> crs = r.Crosses;

            #region интенсивности подходов прямого направления движения
            for (int i = 1; i < crs.Count; i++)
            {
                Cross prevCrs = crs[i - 1];
                crs[i].PassLeft.Intensity = (int)(
                    (prevCrs.PassLeft.DirectPart / 100d) * (double)prevCrs.PassLeft.Intensity +
                    (prevCrs.PassTop.LeftPart / 100d) * (double)prevCrs.PassTop.Intensity +
                    (prevCrs.PassBottom.RightPart / 100d) * (double)prevCrs.PassBottom.Intensity
                    );
            }
            #endregion

            #region интенсивности подходов обратного направления движения
            for (int i = crs.Count - 2; i >= 0; i--)
            {
                Cross nextCrs = crs[i + 1];
                crs[i].PassRight.Intensity = (int)(
                    (nextCrs.PassRight.DirectPart / 100d) * (double)nextCrs.PassRight.Intensity +
                    (nextCrs.PassTop.RightPart / 100d) * (double)nextCrs.PassTop.Intensity +
                    (nextCrs.PassBottom.LeftPart / 100d) * (double)nextCrs.PassBottom.Intensity
                    );
            }
            #endregion
        }

    }
}
