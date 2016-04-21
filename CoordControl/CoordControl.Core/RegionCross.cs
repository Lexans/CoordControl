using CoordControl.Core.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoordControl.Core
{
	/// <summary>
	/// Участок перекрестка
	/// </summary>
	public sealed class RegionCross : Region
	{
        /// <summary>
        /// Перекресток, для которого создается регион
        /// </summary>
        public NodeCross CrossNode { get; set; }

        /// <summary>
        /// Ширина участка, метры
        /// </summary>
        public double Width { get; private set; }
        
        /// <summary>
        /// ширина верхней половины
        /// </summary>
        public double WidthTop; 

		/// <summary>
		/// Часть потока, которая едет
		/// к левому выходу
		/// </summary>
		public double ToLeftFlowPart { get; set; }

		/// <summary>
		/// Часть потока, которая едет
		/// к правому выходу
		/// </summary>
		public double ToRightFlowPart { get; set; }

		/// <summary>
		/// Часть потока, которая едет
		/// к верхнему выходу
		/// </summary>
		public double ToTopFlowPart { get; set; }

		/// <summary>
		/// Часть потока, которая едет к нижнему выходу
		/// 
		/// </summary>
		public double ToBottomFlowPart { get; set; }

        public RegionCross(NodeCross nc)
        {
            CrossNode = nc;
            CalcSizes();
        }

        /// <summary>
        /// вычисление ширины и длины участка перекрестка
        /// </summary>
        private void CalcSizes()
        {
            Pass entryRightPass = CrossNode.EntityCross.PassRight;
            Pass exitLeftPass = (CrossNode.EntityCross.RoadLeft != null) ?
                CrossNode.EntityCross.RoadLeft.CrossLeft.PassRight : CrossNode.EntityCross.PassRight;
            Pass widthMax = ((entryRightPass.LineWidth * entryRightPass.LinesCount
               > exitLeftPass.LineWidth * exitLeftPass.LinesCount)
               ? entryRightPass : exitLeftPass);
            WidthTop = widthMax.LinesCount * widthMax.LineWidth;
            Width = WidthTop;

            Pass entryLeftPass = CrossNode.EntityCross.PassLeft;
            Pass exitRightPass = (CrossNode.EntityCross.RoadRight != null) ?
                CrossNode.EntityCross.RoadRight.CrossRight.PassLeft : CrossNode.EntityCross.PassLeft;
            widthMax = ((entryLeftPass.LineWidth * entryLeftPass.LinesCount
               > exitRightPass.LineWidth * exitRightPass.LinesCount)
               ? entryLeftPass : exitRightPass);
            Width += widthMax.LineWidth * widthMax.LinesCount;

            #region вычисление длины участка перекрестка
            Pass entryTopPass = CrossNode.EntityCross.PassTop;
            Lenght = entryTopPass.LinesCount * entryTopPass.LineWidth;
            Pass entryBottomPass = CrossNode.EntityCross.PassBottom;
            Lenght += entryBottomPass.LinesCount * entryBottomPass.LineWidth;
            #endregion
        }

	}
}

