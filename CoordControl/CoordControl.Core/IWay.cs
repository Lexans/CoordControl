using CoordControl.Core.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoordControl.Core
{
	/// <summary>
	/// Интерфейс для всех видов перегонов
	/// </summary>
	public interface IWay 
	{
		/// <summary>
		/// Получение первого участка перегона
		/// </summary>
		Region GetRegionFirst();

		/// <summary>
		/// Получение последнего участка перегона
		/// </summary>
		Region GetRegionLast();

		/// <summary>
		/// Перемещение ТП за интервал сканирования
		/// </summary>
		void RunSimulationStep();

        /// <summary>
        /// получение подхода,
        /// характеризующего параметры данного перегона
        /// </summary>
        Pass GetInfo();

	}
}

