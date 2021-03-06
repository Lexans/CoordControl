﻿using CoordControl.Core.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoordControl.Core
{
	/// <summary>
	/// Участок дискретизации
	/// </summary>
	public class Region
	{
		/// <summary>
		/// Длина участка
		/// </summary>
		public double Lenght { get; set; }

		/// <summary>
		/// Часть потока, находящаяся на данном
		/// участке
		/// </summary>
        private double _flowPart;
        public double DeltaFlowPartLast;
        public double FlowPartGeneral;
        public double FlowPart {
            get {
                return _flowPart; 
            }

            set {
                double val = (value > -0.01 && value < 0) ? 0 : value;

                DeltaFlowPartLast = val - _flowPart;
                _flowPart = val;

                if (DeltaFlowPartLast > 0)
                    FlowPartGeneral += DeltaFlowPartLast;
            }
        }

		/// <summary>
		/// Перегон, которому принадлежит данный участок
		/// </summary>
		public IWay Way { get; set; }

		/// <summary>
		/// Получение плотности
		/// потока на данном участке
		/// </summary>
		public virtual double GetDensity()
		{
            return FlowPart / Lenght;
		}

		/// <summary>
		/// скорость
		/// потока на данном участке
		/// 
		/// </summary>
        public double Velocity { get; set; }

		/// <summary>
		/// интенсивность
		/// потока на данном участке
		/// 
		/// </summary>
        public double GetIntensity() {
            double result;

            if (RouteEnvir.Instance.TimeCurrent != 0)
                result = FlowPartGeneral / (RouteEnvir.Instance.TimeCurrent / ModelConst.SEC_PER_HOUR);
            else
                result = 0;

            return result;
        }

		public Region(IWay way, double lenght):
            this()
		{
            Way = way;
            Lenght = lenght;
		}

        protected Region() {
            FlowPart = 0d;
        }

		/// <summary>
		/// Перемещение части потока
		/// с текущего региона на следующий
		/// с проверкой ограничений
		/// Возвращает реально перемещенную часть ТП
		/// </summary>
		public virtual double Move(Region nextRegion, double deltaFlowPart)
		{
            double resultDeltaFP = deltaFlowPart;

            //ограничение на количество имеющихся ТС
            //"остатки" ТС перемещаются на следующий регион
            if ((FlowPart - resultDeltaFP) < 0.5)
                resultDeltaFP = FlowPart;

            //ограничение на максимальное количество ТС на следюущем участке
            double FpNextMax = nextRegion.Lenght *
                nextRegion.Way.GetInfo().LinesCount /
                ModelConst.CAR_LENGTH;

            if (nextRegion.FlowPart + resultDeltaFP > FpNextMax)
                resultDeltaFP = FpNextMax - nextRegion.FlowPart;

            //перемещение части ТП
            nextRegion.FlowPart += resultDeltaFP;
            FlowPart -= resultDeltaFP;

            return resultDeltaFP;
		}

        /// <summary>
        /// Получение региона, предшествующего текущему
        /// </summary>
        /// <returns></returns>
        public Region GetRegionPrev() {
            if (Way is Way)
            {
                Way w = ((Way)Way);
                int i = w.Regions.IndexOf(this);
                if (i > 0)
                    return w.Regions[i - 1];
                else
                    return null;
            }
            else if (Way is WayEntry)
            {
                WayEntry w = ((WayEntry)Way);
                if (this == w.RegionLast)
                    return w.RegionBoundary;
                else
                    return null;
            }
            else if (Way is WayExit)
            {
                WayExit w = ((WayExit)Way);
                if (this == w.RegionBoundary)
                    return w.RegionFirst;
                else
                    return null;
            }
            else
                return null;
        }

	}
}

