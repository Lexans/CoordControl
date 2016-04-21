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
		/// Получение скорости
		/// потока на данном участке
		/// 
		/// </summary>
		public virtual double GetVelocity()
		{
            return 81;
        }

		/// <summary>
		/// Получение интенсивности
		/// потока на данном участке
		/// 
		/// </summary>
		public virtual double GetIntensity()
		{
            return 1050;
        }

		public Region(IWay way, double lenght)
		{
            Way = way;
            Lenght = lenght;
		}

        protected Region() {
        
        }

		/// <summary>
		/// Перемещение части потока
		/// с текущего региона на следующий
		/// с проверкой ограничений
		/// Возвращает реально перемещенную часть ТП
		/// </summary>
		public virtual double Move(Region nextRegion, double deltaFlowPart)
		{
			throw new System.NotImplementedException();
		}

	}
}

