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

    public interface IFormRegionProp
    {
        double FlowPart { set; }
        double Speed { set; }
        double Intensity { set; }
        double Density { set; }
        string RegionNum { set; }
        double RegionLength { set; }
        double RegionWidth { set; }
        string WayType { set; }
        int LinesCount { set; }
        string WayLength { set; }
        string CrossLeft { set; }
        string CrossRight { set; }
        string MovingDirect { set; }

        event EventHandler FormClosing;

        void FormClose();
        void FormActivate();
    }

    public partial class FormRegionProp : Form, IFormRegionProp
    {
        public FormRegionProp()
        {
            InitializeComponent();
        }


        public double FlowPart
        {
            set {
                listViewProp.Items[0].SubItems[1].Text = NumFormat(value, 2) + " авт";
            }
        }

        public double Speed
        {
            set
            {
                listViewProp.Items[1].SubItems[1].Text = NumFormat(value, 2) + " км/ч";
            }
        }

        public double Intensity
        {
            set
            {
                listViewProp.Items[2].SubItems[1].Text = NumFormat(value, 2) + " авт/ч";
            }
        }

        public double Density
        {
            set {
                listViewProp.Items[3].SubItems[1].Text = NumFormat(value, 2) + " авт/м";
            }
        }

        public string WayType
        {
            set
            {
                listViewProp.Items[7].SubItems[1].Text = value;
            }
        }

        public string RegionNum
        {
            set
            {
                listViewProp.Items[4].SubItems[1].Text = value;
            }
        }

        public string CrossLeft
        {
            set
            {
                //listViewProp.Items[11].SubItems[1].Text = value;
            }
        }

        public string CrossRight
        {
            set
            {
               //listViewProp.Items[12].SubItems[1].Text = value;
            }
        }

        public string MovingDirect
        {
            set
            {
                listViewProp.Items[8].SubItems[1].Text = value;
            }
        }

        public new event EventHandler FormClosing;
        private void FormRegionProp_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (FormClosing != null)
                FormClosing(this, EventArgs.Empty);
        }

        public void FormClose()
        {
            this.Close();
        }

        public void FormActivate()
        {
            Activate();
        }


        private string NumFormat(double num, int decPlaces = 2)
        {
            string decPattern = "";
            for (int i = 0; i < decPlaces; i++)
                decPattern += "#";

            return String.Format("{0:0." + decPattern + "}", num);
        }



        public double RegionLength
        {
            set {
                listViewProp.Items[5].SubItems[1].Text = NumFormat(value, 2) + " м";
            }
        }

        //TODO: перенести участок в перегон
        public double RegionWidth
        {
            set
            {
                listViewProp.Items[6].SubItems[1].Text = NumFormat(value, 2) + " м";
            }
        }

        public int LinesCount
        {
            set
            {
                string s = "";
                if (value != 0)
                    s = value.ToString();

                listViewProp.Items[9].SubItems[1].Text = s;

            }
        }

        public string WayLength
        {
            set
            {
                listViewProp.Items[10].SubItems[1].Text = value + " м";
            }
        }
    }
}
