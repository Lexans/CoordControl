using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoordControl.Forms
{
    public partial class FormStatGraphics : Form
    {
        private int mesureCount;

        public FormStatGraphics(List<double> delaysDirect, List<double> delaysReverse)
        {
            InitializeComponent();
            mesureCount = delaysDirect.Count();

            for (int i = 0; i < mesureCount; i++)
                chart.Series[0].Points.AddXY(i + 1, delaysDirect[i]);

            for (int i = 0; i < mesureCount; i++)
                chart.Series[1].Points.AddXY(i + 1, delaysReverse[i]);

            for (int i = 0; i < mesureCount; i++)
                chart.Series[2].Points.AddXY(i + 1, delaysDirect[i] + delaysReverse[i]);
        }

        public void AddPoint(double delayDirectValue, double delaysReverseValue, double delaysSumValue)
        {
            mesureCount++;
            chart.Series[0].Points.AddXY(mesureCount, delayDirectValue);
            chart.Series[1].Points.AddXY(mesureCount, delaysReverseValue);
            chart.Series[2].Points.AddXY(mesureCount, delaysSumValue);            
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
