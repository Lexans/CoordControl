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
        public double ToLeftFlowPart;

		/// <summary>
		/// Часть потока, которая едет
		/// к правому выходу
		/// </summary>
        public double ToRightFlowPart;

		/// <summary>
		/// Часть потока, которая едет
		/// к верхнему выходу
		/// </summary>
        public double ToTopFlowPart;

		/// <summary>
		/// Часть потока, которая едет к нижнему выходу
		/// 
		/// </summary>
        public double ToBottomFlowPart;

        public RegionCross(NodeCross nc)
        {
            CrossNode = nc;
            CalcSizes();
        }


        /// <summary>
        /// Перемещение части ТП с последнего региона
        /// на перекресток
        /// </summary>
        /// <param name="regionFrom">последний регион перегона</param>
        /// <param name="deltaFlowPart">часть ТП, которую необходимо переместить</param>
        /// <returns>реально перемещенную часть ТП с учетом ограничений</returns>
        public double MoveToCross(Region regionFrom, double deltaFlowPart)
        {
            double resultDeltaFP = deltaFlowPart;

            //ограничение на количество имеющихся ТС
            if (regionFrom.FlowPart < deltaFlowPart)
                resultDeltaFP = regionFrom.FlowPart;

            //ограничение на максимальное количество ТС на участке перекрестка
            double FpNextMax = Lenght *
                (Width / 3.5) /
                6.0;
            double FpNext = FlowPart + resultDeltaFP;
            if (FpNext > FpNextMax)
                resultDeltaFP -= (FpNext - FpNextMax);


            //"остатки" ТС перемещаются на следующий регион
            if ((regionFrom.FlowPart - resultDeltaFP) < 0.5 &&
                (regionFrom.FlowPart + FlowPart) < FpNextMax)
                resultDeltaFP = FlowPart;


            //перемещение части ТП
            FlowPart += resultDeltaFP;
            regionFrom.FlowPart -= resultDeltaFP;

            return resultDeltaFP;
        }



        /// <summary>
        /// Перемещение части ТП с перекрестка
        /// на некоторый перегон
        /// </summary>
        /// <param name="regionTo">Регион, на который перемещается</param>
        /// <param name="flowPartSource">Часть ТП перекрестка</param>
        /// <param name="deltaFlowPart">часть ТП для перемещения</param>
        /// <returns>Фактически перемещенная часть ТП</returns>
        public double MoveFromCross(Region regionTo, ref double flowPartSource, double deltaFlowPart)
        {
            double resultDeltaFP = deltaFlowPart;

            //ограничение на количество имеющихся ТС
            if (flowPartSource < deltaFlowPart)
                resultDeltaFP = flowPartSource;

            //ограничение на максимальное количество ТС на следующем участке
            double FpNextMax = regionTo.Lenght * regionTo.Way.GetInfo().LinesCount / 6.0;
            double FpNext = regionTo.FlowPart + resultDeltaFP;
            if (FpNext > FpNextMax)
                resultDeltaFP -= (FpNext - FpNextMax);


            //"остатки" ТС перемещаются на следующий регион
            if ((flowPartSource - resultDeltaFP) < 0.5 &&
                (flowPartSource + regionTo.FlowPart) < FpNextMax)
                resultDeltaFP = flowPartSource;


            //перемещение части ТП
            regionTo.FlowPart += resultDeltaFP;
            FlowPart -= resultDeltaFP;
            flowPartSource -= resultDeltaFP;

            return resultDeltaFP;
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

