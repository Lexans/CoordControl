using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoordControl.Core;

namespace CoordControl.Models
{
    public class RegionPropModel
    {
        //TODO: добавить модели всех параметров и согласовать с формой и презентором, добавить единицы измерения
        public string GetWayType(Region reg) {
            IWay w = reg.Way;
            string result = "";

            if (reg is RegionCross)
                result = "Перекресток ("+((RegionCross)reg).CrossNode.EntityCross.StreetName + ")";
            else if (w is WayEntry)
                result = "Входной перегон";
            else if (w is WayExit)
                result = "Выходной перегон";
            else if (w is Way)
                result = "Внутрений перегон";

            return result;
        }

        public string GetRegionNum(Region reg)
        {
            IWay w = reg.Way;
            string result = "1";

            if (w != null && w is Way)
                result = (((Way)reg.Way).Regions.IndexOf(reg)).ToString()
                    + " из " + (((Way)reg.Way).Regions).Count.ToString();
            else if (w != null && w is WayEntry)
                result = "крайний";

            return result;
        }

        public string GetLeftCrossName(Region reg)
        {
            IWay w = reg.Way;
            string result = "";

            if (reg is RegionCross)
            {
                IWay leftWay = ((RegionCross)reg).CrossNode.GetLeftExitWay();
                if (leftWay is Way)
                    result = ((Way)leftWay).EntityRoad.CrossLeft.StreetName;
            }
            else if (w is Way)
                result = ((Way)w).EntityRoad.CrossLeft.StreetName;

            return result;
        }

        public string GetRightCrossName(Region reg)
        {
            IWay w = reg.Way;
            string result = "";

            if (reg is RegionCross)
            {
                IWay rightWay = ((RegionCross)reg).CrossNode.GetRightExitWay();
                if (rightWay is Way)
                    result = ((Way)rightWay).EntityRoad.CrossRight.StreetName;
            }
            else if (w is Way)
                result = ((Way)w).EntityRoad.CrossRight.StreetName;

            return result;
        }


        public string GetWayDirection(Region reg)
        {
            IWay w = reg.Way;
            string result = "";


            if (w is Way)
            {
                Way wInternal = (Way)w;
                if (wInternal.IsRightDirection)
                    result = "прямо";
                else
                    result = "обратно";
            }

            return result;
        }

        public int GetLinesCount(Region reg)
        {
            IWay w = reg.Way;
            int result = 0;

            if (!(reg is RegionCross))
                result = reg.Way.GetInfo().LinesCount;

            return result;
        }

        public string GetWayLength(Region reg)
        {
            IWay w = reg.Way;
            string result =  "";

            if (reg is RegionCross)
                result = String.Format("{0:0.##}", ((RegionCross)reg).Lenght);
            else if (w is Way)
                result = ((Way)reg.Way).EntityRoad.Length.ToString();

            return result;
        }

        public double GetRegionLength(Region reg)
        {
            return reg.Lenght;
        }

        public double GetRegionWidth(Region reg)
        {
            double result = 0;
            if (reg is RegionCross)
                result = ((RegionCross)reg).Width;
            else
                result = reg.Way.GetInfo().LinesCount * reg.Way.GetInfo().LineWidth;

            return result;
        }
    }
}
