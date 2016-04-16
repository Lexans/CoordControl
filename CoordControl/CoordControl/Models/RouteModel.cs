using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using CoordControl.Core.Domains;
using CoordControl.Data.DAO;

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
                    if (i < r.CrossCount)
                    {
                        Road road = new Road();
                        road.Length = _rand.Next(100, 1000);
                        road.Speed = 80;
                        road.CrossLeft = cr;

                        if (i == crCountReal && crCountReal > 0)
                            r.Crosses[i - 1].RoadRight = road;
                        else
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
                    //интенсивность самого левого перекрестка
                    if (i == 0)
                        passLeft.Intensity = _rand.Next(300, 700);

                    cr.PassLeft = passLeft;
                    #endregion

                    #region правый подход
                    Pass passRight = newPass();
                    passRight.CrossRightPass = cr;

                    //интенсивность самого правого перекерстка
                    if (i == r.CrossCount - 1)
                        passRight.Intensity = _rand.Next(300, 700);

                    cr.PassRight = passRight;
                    #endregion

                    #region верхний подход
                    Pass passTop = newPass();
                    passTop.CrossTopPass = cr;
                    passTop.Intensity = _rand.Next(300, 700);

                    cr.PassTop = passTop;
                    #endregion

                    #region нижний подход
                    Pass passBottom = newPass();
                    passBottom.CrossBottomPass = cr;
                    passBottom.Intensity = _rand.Next(300, 700);

                    cr.PassBottom = passBottom;
                    #endregion

                    r.Crosses.Add(cr);
                }

                IntensityCalc(r);
            }
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
            p.DirectPart = _rand.Next(70, 100);
            p.RightPart = _rand.Next(0, 100 - p.DirectPart);
            p.LeftPart = 100 - p.DirectPart - p.RightPart;
            p.LineWidth = 3.5;
            p.LinesCount = _rand.Next(2, 4);

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
