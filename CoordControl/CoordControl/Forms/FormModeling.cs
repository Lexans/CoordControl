using CoordControl.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoordControl.Forms
{
    public enum RegionViewParam : int
    {
        FlowPart,
        Intensity,
        Velocity,
        Density
    }

    public enum LightPosition: int
    {
        Top,
        Bottom,
        Left,
        Right
    }

    public enum ArrowDirection : int
    {
        Top,
        Bottom,
        Left,
        Right
    }

    public interface IFormModeling
    {
        double CanvasHeight { set; get; }

        double CanvasWidth { set;  get; }

        Point CanvasClickPoint { get; }

        double ModelingTime { set; }

        double RegionDensity { set; }

        double RegionFlowPart { set; }

        double RegionIntensity { set; }

        double RegionVelocity { set; }

        double DrawScale { get; }

        string TitleForm { get; set; }

        Size FormSize { get; }

        RegionViewParam RegionViewParam { get; set; }

        event EventHandler CanvasClick;

        event EventHandler ModelingResetClick;

        event EventHandler ModelingTimerTick;

        event EventHandler PanelNeedPaint;

        event EventHandler ScaleChanged;

        event EventHandler FormLoad;

        event EventHandler FormClosed;

        event EventHandler FormSizeChanged;

        event EventHandler StatShow;

        void DrawRectangle(Color color, RectangleF rect);

        void DrawRegion(Color color, RectangleF rect, ArrowDirection arrDirect);

        /// <param name="angle">угол поворота картинки</param>
        void DrawPicture(Point p, RotateFlipType angle, Image img);

        void DrawLight(RectangleF p, LightPosition pos, LightState state);

        void RedrawCanvas();

        void DrawStreetName(PointF p, String text);

        void TimerStop();
    }


    public partial class FormModeling : Form, IFormModeling
    {
        public FormModeling()
        {
            InitializeComponent();
            comboBoxViewParam.SelectedIndex = 0;
            timer.Interval = 1000-trackBarModelingSpeed.Value;
        }


        #region экранирование элементов
        public double CanvasHeight
        {
            get {
                return panelCanvas.Height;
            }
            set
            {
                panelCanvas.AutoScrollMinSize = new Size(panelCanvas.AutoScrollMinSize.Width, (int)value);
            }
        }

        public double CanvasWidth
        {
            get {
                return panelCanvas.AutoScrollMinSize.Width;
            }
            set
            {
                panelCanvas.AutoScrollMinSize = new Size((int)value, panelCanvas.AutoScrollMinSize.Height);
            }
        }

        public string TitleForm
        {
            set { this.Text = value; }
            get { return this.Text; }
        }


        Point _pointLastClicked;
        public Point CanvasClickPoint
        {
            get
            {
                return _pointLastClicked;
            }
        }

        public double ModelingTime
        {
            set
            {
                toolStripStatusLabelCurrentTime.Text = String.Format("{0:0.##}", value);
            }
        }

        public double RegionDensity
        {
            set {
                numericUpDownRegionDensity.Value = (decimal) value;
            }
        }

        public double RegionFlowPart
        {
            set { numericUpDownRegionFlowPart.Value = (decimal)value; }
        }

        public double RegionIntensity
        {
            set { numericUpDownRegionIntensity.Value = (decimal)value; }
        }

        public double RegionVelocity
        {
            set { numericUpDownRegionVelocity.Value = (decimal)value; }
        }

        public RegionViewParam RegionViewParam
        {
            get
            {
                RegionViewParam result;
                switch ((string)comboBoxViewParam.SelectedItem)
                {
                    case "Интенсивность":
                        result = RegionViewParam.Intensity;
                        break;
                    case "Плотность":
                        result = RegionViewParam.Density;
                        break;
                    case "Часть потока":
                        result = RegionViewParam.FlowPart;
                        break;
                    case "Скорость":
                        result = RegionViewParam.Velocity;
                        break;
                    default:
                        result = RegionViewParam.Intensity;
                        break;
                }

                return result;
            }
            set
            {
                string result;
                switch (value)
                {
                    case RegionViewParam.Intensity:
                        result = "Интенсивность";
                        break;
                    case RegionViewParam.Density:
                        result = "Плотность";
                        break;
                    case RegionViewParam.FlowPart:
                        result = "Часть потока";
                        break;
                    case RegionViewParam.Velocity:
                        result = "Скорость";
                        break;
                    default:
                        result = "Интенсивность";
                        break;
                }

                comboBoxViewParam.SelectedItem = result;
            }
        }

        public Size FormSize
        {
            get { return this.Size; }
        }

        public double DrawScale
        {
            get
            {
                return trackBarScale.Value / 10.0;
            }
        }

        #endregion

        #region проброс событий
        public event EventHandler CanvasClick;

        public event EventHandler ModelingResetClick;

        public event EventHandler ModelingTimerTick;

        public event EventHandler PanelNeedPaint;

        public event EventHandler FormLoad;

        public event EventHandler ScaleChanged;

        public event EventHandler FormSizeChanged;

        public event EventHandler StatShow;

        public new event EventHandler FormClosed;



        private void FormModeling_SizeChanged(object sender, EventArgs e)
        {
            if (FormSizeChanged != null) FormSizeChanged(this, EventArgs.Empty);
            panelCanvas.Refresh();
        }

        private void panelCanvas_MouseClick_1(object sender, MouseEventArgs e)
        {
            _pointLastClicked = new Point(
                -panelCanvas.AutoScrollPosition.X + e.X,
                -panelCanvas.AutoScrollPosition.Y + e.Y);

            if (CanvasClick != null) CanvasClick(this, EventArgs.Empty);
        }

        private void toolStripButtonReset_Click(object sender, EventArgs e)
        {
            TimerStop();
            if (ModelingResetClick != null) ModelingResetClick(this, EventArgs.Empty);

        }

        private void toolStripButtonStart_Click(object sender, EventArgs e)
        {
            if (timer.Enabled)
            {
                TimerStop();
            }
            else
            {
                toolStripButtonStart.Text = "Пауза";
                timer.Start();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (ModelingTimerTick != null) ModelingTimerTick(this, EventArgs.Empty);
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            if (ModelingTimerTick != null) ModelingTimerTick(this, EventArgs.Empty);
        }

        Graphics gr;
        private void panelCanvas_Paint_1(object sender, PaintEventArgs e)
        {
            e.Graphics.TranslateTransform(panelCanvas.AutoScrollPosition.X, panelCanvas.AutoScrollPosition.Y);
            gr = e.Graphics;

            if (PanelNeedPaint != null) PanelNeedPaint(this, EventArgs.Empty);
        }


        private void FormModeling_Load(object sender, EventArgs e)
        {
            if (FormLoad != null) FormLoad(this, EventArgs.Empty);
        }


        private void trackBarScale_ValueChanged(object sender, EventArgs e)
        {
            if (ScaleChanged != null) ScaleChanged(this, EventArgs.Empty);
            panelCanvas.Refresh();
        }
        private void buttonStatShow_Click(object sender, EventArgs e)
        {
            if (StatShow != null) StatShow(this, e);
        }
        #endregion

        #region методы формы
        public void DrawRectangle(Color color, RectangleF rect)
        {
            gr.FillRectangle(new SolidBrush(color), rect);
            Rectangle rectInt = new Rectangle((int)rect.X, (int)rect.Y, (int)rect.Width, (int)rect.Height);
            gr.DrawRectangle(Pens.Black, rectInt);
        }

        public void DrawRegion(Color color, RectangleF rect, ArrowDirection arrDirect)
        {
            DrawRectangle(color, rect);
            Pen p = new Pen(Color.Black, 1);

            GraphicsPath capPath = new GraphicsPath();
            float arrorLen = (float)(2 * DrawScale);
            capPath.AddLine(-arrorLen, -arrorLen, 0, 0);
            capPath.AddLine(0, 0, arrorLen, -arrorLen);
            p.CustomEndCap = new System.Drawing.Drawing2D.CustomLineCap(null, capPath);

            PointF Left = new PointF(
                (int)(rect.Left + rect.Width * 0.2),
                (int)(rect.Top + rect.Height * 0.5)
                );
            PointF Right = new PointF(
                (int)(rect.Right - rect.Width * 0.2),
                (int)(rect.Top + rect.Height * 0.5)
                );

            PointF Top = new PointF(
                (int)(rect.Left + rect.Width * 0.5),
                (int)(rect.Top + rect.Height * 0.2)
                );
            PointF Bottom = new PointF(
                (int)(rect.Left + rect.Width * 0.5),
                (int)(rect.Top + rect.Height * 0.8)
                );

            switch (arrDirect)
            {
                case ArrowDirection.Right:
                    gr.DrawLine(p, Left, Right);
                    break;
                case ArrowDirection.Left:
                    gr.DrawLine(p, Right, Left);
                    break;
                case ArrowDirection.Top:
                    gr.DrawLine(p, Bottom, Top);
                    break;
                case ArrowDirection.Bottom:
                    gr.DrawLine(p, Top, Bottom);
                    break;
            }

        }

        public void DrawPicture(Point p, RotateFlipType angle, Image img)
        {
            img.RotateFlip(angle);
            gr.DrawImageUnscaled(img, p);
        }

        public void DrawLight(RectangleF p, LightPosition pos, LightState state)
        {

            Brush brush;
            switch (state)
            {
                case LightState.Green:
                    brush = new SolidBrush(Color.Green);
                    break;
                case LightState.Red:
                    brush = new SolidBrush(Color.Red);
                    break;
                case LightState.Yellow:
                    brush = new SolidBrush(Color.Yellow);
                    break;
                case LightState.YellowRed:
                    brush = new SolidBrush(Color.Orange);
                    break;
                default:
                    brush = new SolidBrush(Color.White);
                    break;
            }

            int angle = 0;
            switch(pos)
            {
                case LightPosition.Top:
                    angle = 0;
                    break;
               case LightPosition.Bottom:
                    angle = 180;
                    break;
               case LightPosition.Left:
                    angle = 270;
                    break;
               case LightPosition.Right:
                    angle = 90;
                    break;
            }

            int w = (int)(p.Width);
            int h = (int)(p.Height);

            gr.FillPie(brush, (int)p.X, (int)p.Y, w, h, angle, 180);
            gr.DrawPie(Pens.Black, (int)p.X, (int)p.Y, w, h, angle, 180);
        }

        public void DrawStreetName(PointF p, String text) {
            Font drawFont = new Font("Arial", (int) (6 * DrawScale));
            SolidBrush drawBrush = new SolidBrush(System.Drawing.Color.Black);

            StringFormat drawFormat = new StringFormat(StringFormatFlags.DirectionVertical);
            gr.DrawString(text, drawFont, drawBrush, p.X, p.Y, drawFormat);
        }

        #endregion


        private void panelCanvas_Scroll(object sender, ScrollEventArgs e)
        {
            panelCanvas.Invalidate();
        }


        public void RedrawCanvas()
        {
            panelCanvas.Refresh();
        }

        private void trackBarModelingSpeed_ValueChanged(object sender, EventArgs e)
        {
            timer.Interval = 1000 - trackBarModelingSpeed.Value;
        }

        private void FormModeling_FormClosing(object sender, FormClosingEventArgs e)
        {
        }


        public void TimerStop()
        {
            timer.Stop();
            toolStripButtonStart.Text = "Старт";
        }

        private void FormModeling_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            timer.Stop();
            if (FormClosed != null)
                FormClosed(this, EventArgs.Empty);
        }

    }
}
