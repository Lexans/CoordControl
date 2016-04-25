using CoordControl.Core.Domains;
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
		public double FlowPart { get; set; }

		/// <summary>
		/// Признак остановки двжиения. Если во время очередной
		/// итерации не произошло измненение части ТП на данном участке,
		/// то считается что все ТС стоят на данном участке.
		/// </summary>
		public bool IsStopMode { get; set; }

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

        //TODO: настроить расчет интенсивности по времени моделировния, а не мгновенной
		/// <summary>
		/// интенсивность
		/// потока на данном участке
		/// 
		/// </summary>
        public double Intensity { get; set; }

		public Region(IWay way, double lenght):
            this()
		{
            Way = way;
            Lenght = lenght;
		}

        protected Region() {
            FlowPart = 0d;
            IsStopMode = false;
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
            if (FlowPart < deltaFlowPart)
                resultDeltaFP = FlowPart;

            //ограничение на максимальное количество ТС на следюущем участке
            double FpNextMax = nextRegion.Lenght *
                nextRegion.Way.GetInfo().LinesCount /
                6.0;
            double FpNext = nextRegion.FlowPart + resultDeltaFP;
            if (FpNext > FpNextMax)
                resultDeltaFP -= (FpNext - FpNextMax);


            //"остатки" ТС перемещаются на следующий регион
            if ((FlowPart - resultDeltaFP) < 0.5 &&
                (nextRegion.FlowPart + FlowPart) < FpNextMax)
                resultDeltaFP = FlowPart;


            //перемещение части ТП
            nextRegion.FlowPart += resultDeltaFP;
            FlowPart -= resultDeltaFP;

            return resultDeltaFP;
		}

	}
}

