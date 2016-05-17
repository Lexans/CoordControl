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
    public interface IFormStatistic
    {
        double DelayDirect { set; }
        double DelayReverse { set; }
        double DelaySum { set; }

        double MeasurePeriod { set; }

        void SetMeasureHistory(List<double> DelaysDirect, List<double> DelaysReverse, List<double> DelaysSum);
        void AddMeasureHistory(double DelayDirect, double DelayReverse, double DelaySum);

        void SetMx(double MxDirect, double MxReverse, double MxSum);

        void SetDx(double DxDirect, double DxReverse, double DxSum);

        void FormClose();

        event EventHandler FormClosing;
    }


    public partial class FormStatistic : Form, IFormStatistic
    {
        public FormStatistic()
        {
            InitializeComponent();
        }

        public double DelayDirect
        {
            set {
                numericUpDownDirect.Value = (decimal)value;
            }
        }

        public double DelayReverse
        {
            set {
                numericUpDownReverse.Value = (decimal)value;
            }
        }

        public double DelaySum
        {
            set {
                numericUpDownSum.Value = (decimal)value;
            }
        }

        public double MeasurePeriod
        {
            set
            {
                labelMeasurePeriod.Text = "(измерения каждые " + NumFormat(value, 0) + " сек)";
            }
        }

        private string NumFormat(double num, int decPlaces = 2)
        {
            string decPattern = "";
            for (int i = 0; i < decPlaces; i++)
                decPattern += "#";

            return String.Format("{0:0." + decPattern + "}", num);
        }

        public void SetMeasureHistory(List<double> DelaysDirect, List<double> DelaysReverse, List<double> DelaysSum)
        {
            ListView.ListViewItemCollection items = listViewHistory.Items;
            items.Clear();

            for (int i = 0; i < DelaysDirect.Count; i++)
                items.Add(
                    new ListViewItem( new String[] {
                        (i+1).ToString(), NumFormat(DelaysDirect[i]),  NumFormat(DelaysReverse[i]),  NumFormat(DelaysSum[i])
                    })
                    );
        }

        public void AddMeasureHistory(double DelayDirect, double DelayReverse, double DelaySum)
        {
            listViewHistory.Items.Add(
                new ListViewItem(new String[] {
                        (listViewHistory.Items.Count + 1).ToString(),
                        NumFormat(DelayDirect),  NumFormat(DelayReverse),  NumFormat(DelaySum)
                    })
                );
        }

        public void SetMx(double MxDirect, double MxReverse, double MxSum)
        {
            listViewNumChars.Items[0] = new ListViewItem(new String[] { "Мат. ожидание",
                        NumFormat(MxDirect),  NumFormat(MxReverse),  NumFormat(MxSum)
                    });
        }

        public void SetDx(double DxDirect, double DxReverse, double DxSum)
        {
            listViewNumChars.Items[1] = new ListViewItem(new String[] { "Дисперсия",
                        NumFormat(DxDirect),  NumFormat(DxReverse),  NumFormat(DxSum)
                    });
        }


        public new event EventHandler FormClosing;


        private void FormStatistic_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (FormClosing != null)
                FormClosing(this, EventArgs.Empty);
        }


        public void FormClose()
        {
            this.Close();
        }
    }
}
