using CoordControl.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

using CoordControl.Core.Domains;
using CoordControl.Core;


namespace CoordControl.Presenters
{
	public sealed class ModelingPresenter
	{

		private IFormModeling _view { get; set; }

        /// <summary>
        /// позиции отображения регионов
        /// </summary>
        public Dictionary<CoordControl.Core.Region, RectangleF> RegionsView { get; set; }

        public Dictionary<CoordControl.Core.RegionCross, RectangleF> RegionsCrossView { get; set; }

        public Dictionary<NodeCross, List<RectangleF>> CrossLights1 { get; set; }

        public Dictionary<NodeCross, List<RectangleF>> CrossLights2 { get; set; }

        private CoordControl.Core.Region _selectedRegion { get; set; }

		/// <summary>
		/// Вычисление масштаба (пикс/метр)
		/// </summary>
		private double СalcScale()
		{
            return _view.DrawScale;
		}

         public ModelingPresenter(IFormModeling view, Plan plan)
         {
             _view = view;
             RouteEnvir.Instance.EntityPlan = plan;

             _view.PanelNeedPaint += _view_PanelNeedPaint;
             _view.ScaleChanged += _view_ScaleChanged;
             _view.CanvasClick += _view_CanvasClick;
             _view.FormSizeChanged += _view_FormSizeChanged;

             _view.ModelingStartClick += _view_ModelingStartClick;
         }

         void _view_ModelingStartClick(object sender, EventArgs e)
         {
             RouteEnvir.Instance.RunSimulationStep();
         }

         void _view_FormSizeChanged(object sender, EventArgs e)
         {
             CalcGeometries();
         }

         void _view_CanvasClick(object sender, EventArgs e)
         {
             Point p = _view.CanvasClickPoint;

             CoordControl.Core.Region _selectedRegion = null;

             KeyValuePair<CoordControl.Core.Region, RectangleF> entry = 
                 (KeyValuePair<CoordControl.Core.Region, RectangleF>)
                 RegionsView.FirstOrDefault((x) =>
                     x.Value.Left < p.X && p.X < x.Value.Right && p.Y > x.Value.Top && p.Y < x.Value.Bottom);
                 _selectedRegion = entry.Key;

             if(entry.Key != null)
             {
                 _selectedRegion = entry.Key;
             }
             else
             {
                 KeyValuePair<CoordControl.Core.RegionCross, RectangleF> entryCross = 
                 (KeyValuePair<CoordControl.Core.RegionCross, RectangleF>)
                 RegionsCrossView.FirstOrDefault((x) =>
                     x.Value.Left < p.X && p.X < x.Value.Right && p.Y > x.Value.Top && p.Y < x.Value.Bottom);
                 _selectedRegion = (CoordControl.Core.Region) entryCross.Key;
             }

             if(_selectedRegion != null)
             {
                 _view.RegionDensity = _selectedRegion.GetDensity();
                 _view.RegionIntensity = _selectedRegion.Intensity;
                 _view.RegionVelocity = _selectedRegion.Velocity;
                 _view.RegionFlowPart = _selectedRegion.FlowPart;
             }

         }

         void _view_ScaleChanged(object sender, EventArgs e)
         {
             CalcGeometries();
         }


         void _view_PanelNeedPaint(object sender, EventArgs e)
         {
             DrawGeometries();
         }

         //TODO: реализовать цвета участков в зависимости от значения выбранного параметра

         //отрисовка всех объектов
         double lengthReal;
         private void DrawGeometries()
         {
             if (lengthReal == 0)
                 lengthReal = RouteEnvir.Instance.CalcFullRouteLength();

             _view.CanvasWidth = lengthReal * СalcScale();


             foreach (KeyValuePair<NodeCross, List<RectangleF>> entry in CrossLights1)
             {
                 _view.DrawLight(entry.Value[0], LightPosition.Left, entry.Key.GetLightStateFirst());
                 _view.DrawLight(entry.Value[1], LightPosition.Right, entry.Key.GetLightStateFirst());
             }

             foreach (KeyValuePair<NodeCross, List<RectangleF>> entry in CrossLights2)
             {
                 _view.DrawLight(entry.Value[0], LightPosition.Top, entry.Key.GetLightStateSecond());
                 _view.DrawLight(entry.Value[1], LightPosition.Bottom, entry.Key.GetLightStateSecond());
             }

             Color colDefault = Color.Gray;
             foreach (KeyValuePair<CoordControl.Core.Region, RectangleF> entry in RegionsView)
             {
                 ArrowDirection direct = ArrowDirection.Right;

                 if (entry.Key.Way is WayExit)
                 {
                     WayExit wExit = (WayExit)entry.Key.Way;
                     if (wExit.EntityPass.CrossTopPass != null)
                     {
                         RectangleF rectExit = entry.Value;
                         PointF p = new PointF(
                             (float)(rectExit.Left + rectExit.Width*0.2),
                             (float)(rectExit.Bottom + rectExit.Height*0.2)
                             );
                         _view.DrawStreetName(p, wExit.EntityPass.Cross.StreetName);
                     }
                 }

                 if (entry.Key.Way is Way)
                 {
                     if (((Way)entry.Key.Way).IsRightDirection)
                         direct = ArrowDirection.Right;
                     else
                         direct = ArrowDirection.Left;
                 }
                 else if (entry.Key.Way is WayExit)
                {
                    WayExit wExit = (WayExit)entry.Key.Way;
                    if(wExit.EntityPass.CrossTopPass != null)
                        direct = ArrowDirection.Bottom;
                    else if(wExit.EntityPass.CrossBottomPass != null)
                        direct = ArrowDirection.Top;
                    else if(wExit.EntityPass.CrossLeftPass != null)
                        direct = ArrowDirection.Right;
                    else if(wExit.EntityPass.CrossRightPass != null)
                        direct = ArrowDirection.Left;
                }
                 else if (entry.Key.Way is WayEntry)
                 {
                     WayEntry wEntry = (WayEntry)entry.Key.Way;
                     if (wEntry.EntityPass.CrossTopPass != null)
                         direct = ArrowDirection.Bottom;
                     else if (wEntry.EntityPass.CrossBottomPass != null)
                         direct = ArrowDirection.Top;
                     else if (wEntry.EntityPass.CrossLeftPass != null)
                         direct = ArrowDirection.Right;
                     else if (wEntry.EntityPass.CrossRightPass != null)
                         direct = ArrowDirection.Left;
                 }

                 _view.DrawRegion(colDefault, entry.Value, direct);
             }

             foreach (KeyValuePair<CoordControl.Core.RegionCross, RectangleF> entry in RegionsCrossView)
             {
                 _view.DrawRectangle(colDefault, entry.Value);
             }

         }

        /// <summary>
        /// вычисление позиций всех объектов
        /// </summary>
        private void CalcGeometries() {
            CrossLights1 = new Dictionary<NodeCross, List<RectangleF>>();
            CrossLights2 = new Dictionary<NodeCross, List<RectangleF>>();

            RegionsView = new Dictionary<Core.Region, RectangleF>();
            RegionsCrossView = new Dictionary<RegionCross, RectangleF>();

            double scaleX = СalcScale();
            double scaleY = scaleX * 1;

            #region положение крайнего левого подхода
            RectangleF rectEntryLeft = new RectangleF();
            rectEntryLeft.X = 0;
            rectEntryLeft.Y = (float)_view.CanvasHeight / 2.0f;

            NodeCross firstNC = RouteEnvir.Instance.ListCross.First(
                (x) => x.EntityCross.Equals(RouteEnvir.Instance.EntityRoute.Crosses.First())
                );

            WayEntry firstEntry = (WayEntry)firstNC.GetLeftEntryWay();
            Pass infoEntry = firstEntry.GetInfo();
            rectEntryLeft.Height = (float)(infoEntry.LineWidth * infoEntry.LinesCount * scaleY);
            rectEntryLeft.Width = (float)(firstEntry.RegionLast.Lenght * scaleX);

            RegionsView[firstEntry.RegionLast] = rectEntryLeft;
            #endregion

            #region положение крайнего левого выхода
            RectangleF rectExitLeft = new RectangleF();
            rectExitLeft.X = 0;
            WayExit firstExit = (WayExit)firstNC.GetLeftExitWay();
            Pass infoExit = firstExit.GetInfo();
            rectExitLeft.Height = (float)(infoExit.LineWidth * infoExit.LinesCount * scaleY);
            rectExitLeft.Width = (float)(firstExit.RegionFirst.Lenght * scaleX);
            rectExitLeft.Y = (float)_view.CanvasHeight / 2.0f - rectExitLeft.Height;

            RegionsView[firstExit.RegionFirst] = rectExitLeft;
            #endregion

            #region положение участков перекрестков и перегонов в прямом и обратном направлении
            NodeCross currentNc = firstNC;
            RectangleF rectCrossRegion;
            while(true) {
                //вычисление прямоугольника участка перекрестка
                rectCrossRegion = new RectangleF();
                rectCrossRegion.X = rectEntryLeft.Right;
                rectCrossRegion.Y = ((float)_view.CanvasHeight / 2.0f) - (float)(currentNc.CrossRegion.WidthTop * scaleY);
                rectCrossRegion.Width = (float) (currentNc.CrossRegion.Lenght * scaleX);
                rectCrossRegion.Height = (float)(currentNc.CrossRegion.Width * scaleY);
                RegionsCrossView[currentNc.CrossRegion] = rectCrossRegion;

                #region вычисление позиций светофоров
                float sizeLight = (float)(7 * scaleX);
                List<RectangleF> light1Positions = new List<RectangleF>();
                RectangleF lightLeft = new RectangleF(
                    (float)(rectCrossRegion.X - sizeLight * 1.2),
                    (float)(rectCrossRegion.Bottom + sizeLight * 0.2),
                    (float)(sizeLight),
                    (float)(sizeLight)
                    );
                light1Positions.Add(lightLeft);
                RectangleF lightRight = new RectangleF(
                    (float)(rectCrossRegion.Right + sizeLight * 0.2),
                    (float)(rectCrossRegion.Top - sizeLight * 1.2),
                    (float)(sizeLight),
                    (float)(sizeLight)
                    );
                light1Positions.Add(lightRight);
                CrossLights1[currentNc] = light1Positions;

                List<RectangleF> light2Positions = new List<RectangleF>();
                RectangleF lightTop = new RectangleF(
                    (float)(rectCrossRegion.X - sizeLight * 1.2),
                    (float)(rectCrossRegion.Top - sizeLight * 1.2),
                    (float)(sizeLight),
                    (float)(sizeLight)
                    );

                light2Positions.Add(lightTop);
                RectangleF lightBottom = new RectangleF(
                    (float)(rectCrossRegion.Right + sizeLight * 0.2),
                    (float)(rectCrossRegion.Bottom + sizeLight * 0.2),
                    (float)(sizeLight),
                    (float)(sizeLight)
                    );
                light2Positions.Add(lightBottom);
                CrossLights2[currentNc] = light2Positions;
                #endregion

                //отрисовка верхнего подхода
                RectangleF rectTopEntry = new RectangleF();
                WayEntry topEntry = (WayEntry)currentNc.GetTopEntryWay();
                rectTopEntry.Height = (float)(topEntry.GetRegionLast().Lenght * scaleY);
                rectTopEntry.Width = (float) (topEntry.GetInfo().LinesCount * topEntry.GetInfo().LineWidth * scaleX);
                rectTopEntry.Y = (float)(rectCrossRegion.Top - rectTopEntry.Height);
                rectTopEntry.X = rectCrossRegion.Left;
                RegionsView[topEntry.GetRegionLast()] = rectTopEntry;

                //верхнего выхода
                RectangleF rectTopExit = new RectangleF();
                WayExit topExit = (WayExit)currentNc.GetTopExitWay();
                rectTopExit.Height = (float)(topExit.GetRegionFirst().Lenght * scaleY);
                rectTopExit.Width = (float)(topExit.GetInfo().LinesCount * topExit.GetInfo().LineWidth * scaleX);
                rectTopExit.Y = (float)(rectCrossRegion.Top - rectTopExit.Height);
                rectTopExit.X = rectCrossRegion.Right - rectTopExit.Width;
                RegionsView[topExit.GetRegionLast()] = rectTopExit;


                //отрисовка нижнего подхода
                RectangleF rectBotEntry = new RectangleF();
                WayEntry botEntry = (WayEntry)currentNc.GetBottomEntryWay();
                rectBotEntry.Height = (float)(botEntry.GetRegionLast().Lenght * scaleY);
                rectBotEntry.Width = (float)(botEntry.GetInfo().LinesCount * botEntry.GetInfo().LineWidth * scaleX);
                rectBotEntry.Y = (float)(rectCrossRegion.Bottom);
                rectBotEntry.X = rectCrossRegion.Right - rectBotEntry.Width;
                RegionsView[botEntry.GetRegionLast()] = rectBotEntry;

                //нижнего выхода
                RectangleF rectBotExit = new RectangleF();
                WayExit botExit = (WayExit)currentNc.GetBottomExitWay();
                rectBotExit.Height = (float)(botExit.GetRegionFirst().Lenght * scaleY);
                rectBotExit.Width = (float)(botExit.GetInfo().LinesCount * botExit.GetInfo().LineWidth * scaleX);
                rectBotExit.Y = (float)(rectCrossRegion.Bottom);
                rectBotExit.X = rectCrossRegion.Left;
                RegionsView[botExit.GetRegionLast()] = rectBotExit;

                if (currentNc.GetRightExitWay() is WayExit)
                    break;

                //цикл отрисовки участков перегона в прямом направлении
                RectangleF rectCrossRegionReverseLast = rectCrossRegion;
                RectangleF rectCrossRegionLast = rectCrossRegion;
                Way wayInternal = (Way)currentNc.GetRightExitWay();
                List<CoordControl.Core.Region> regionsWayInternal = (wayInternal).Regions;
                for(int i = 0; i < regionsWayInternal.Count; i++)
                {
                    RectangleF rectWayRegionRigthDirect = new RectangleF();
                    rectWayRegionRigthDirect.X = rectCrossRegionLast.Right;
                    rectWayRegionRigthDirect.Y = (float)_view.CanvasHeight / 2.0f;

                    Pass wayInternalInfo = wayInternal.GetInfo();
                    rectWayRegionRigthDirect.Height = (float)(wayInternalInfo.LinesCount * wayInternalInfo.LineWidth * scaleY);
                    rectWayRegionRigthDirect.Width = (float)(regionsWayInternal[i].Lenght * scaleX);

                    RegionsView[regionsWayInternal[i]] = rectWayRegionRigthDirect;

                    rectCrossRegionLast = rectWayRegionRigthDirect;
                    rectEntryLeft = rectWayRegionRigthDirect;
                }


                
                //переход к следующему перекрестку
                currentNc = wayInternal.GetNextNodeCross();

                //цикл отрисовка участков перегона в обратном направлении
                Way wayInternalReverse = (Way)currentNc.GetLeftExitWay();
                List<CoordControl.Core.Region> regionsWayInternalReverse = (wayInternalReverse).Regions;
                for (int i = regionsWayInternalReverse.Count-1; i >= 0; i--)
                {
                    RectangleF rectWayRegionRigthReverse = new RectangleF();
                    rectWayRegionRigthReverse.X = rectCrossRegionReverseLast.Right;
                    rectWayRegionRigthReverse.Y = (float)_view.CanvasHeight / 2.0f;

                    Pass wayInternalReverseInfo = wayInternalReverse.GetInfo();
                    rectWayRegionRigthReverse.Height = (float)(wayInternalReverseInfo.LinesCount * wayInternalReverseInfo.LineWidth * scaleY);
                    rectWayRegionRigthReverse.Width = (float)(regionsWayInternalReverse[i].Lenght * scaleX);
                    rectWayRegionRigthReverse.Y -= rectWayRegionRigthReverse.Height;

                    RegionsView[regionsWayInternalReverse[i]] = rectWayRegionRigthReverse;

                    rectCrossRegionReverseLast = rectWayRegionRigthReverse;
                }

            }
            #endregion

            #region положение крайнего правого подхода
            RectangleF rectEntryRight = new RectangleF();
            rectEntryRight.X = rectCrossRegion.Right;

            NodeCross lastNC = RouteEnvir.Instance.ListCross.Last(
                (x) => x.EntityCross.Equals(RouteEnvir.Instance.EntityRoute.Crosses.Last())
                );

            WayEntry lastEntry = (WayEntry)lastNC.GetRightEntryWay();
            Pass infoEntryLast = lastEntry.GetInfo();
            rectEntryRight.Height = (float)(infoEntryLast.LineWidth * infoEntryLast.LinesCount * scaleY);
            rectEntryRight.Width = (float)(lastEntry.RegionLast.Lenght * scaleX);

            rectEntryRight.Y = (float)_view.CanvasHeight / 2.0f - rectEntryRight.Height;

            RegionsView[lastEntry.RegionLast] = rectEntryRight;
            #endregion

            #region положение крайнего левого выхода
            RectangleF rectExitLast = new RectangleF();
            rectExitLast.X = rectCrossRegion.Right;
            WayExit lastExit = (WayExit)lastNC.GetRightExitWay();
            Pass infoExitLast = lastExit.GetInfo();
            rectExitLast.Height = (float)(infoExitLast.LineWidth * infoExitLast.LinesCount * scaleY);
            rectExitLast.Width = (float)(lastExit.RegionFirst.Lenght * scaleX);
            rectExitLast.Y = (float)_view.CanvasHeight / 2.0f;

            RegionsView[lastExit.RegionFirst] = rectExitLast;
            #endregion

        }



	}
}

