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

        string WayType { set; }
        int RegionNum { set; }
        string CrossLeft { set; }
        string CrossRight { set; }
        string MovingDirect { set; }

        event EventHandler FormClosing;

        void FormClose();
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
                listViewProp.Items[0].SubItems[0].Text = NumFormat(value, 2);
            }
        }

        public double Speed
        {
            set
            {
                listViewProp.Items[1].SubItems[0].Text = NumFormat(value, 2);
            }
        }

        public double Intensity
        {
            set
            {
                listViewProp.Items[2].SubItems[0].Text = NumFormat(value, 2);
            }
        }

        public string WayType
        {
            set
            {
                listViewProp.Items[3].SubItems[0].Text = value;
            }
        }

        public int RegionNum
        {
            set
            {
                listViewProp.Items[4].SubItems[0].Text = value.ToString();
            }
        }

        public string CrossLeft
        {
            set
            {
                listViewProp.Items[5].SubItems[0].Text = value;
            }
        }

        public string CrossRight
        {
            set
            {
                listViewProp.Items[6].SubItems[0].Text = value;
            }
        }

        public string MovingDirect
        {
            set
            {
                listViewProp.Items[7].SubItems[0].Text = value;
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


        private string NumFormat(double num, int decPlaces = 2)
        {
            string decPattern = "";
            for (int i = 0; i < decPlaces; i++)
                decPattern += "#";

            return String.Format("{0:0." + decPattern + "}", num);
        }




    }
}
