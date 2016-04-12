using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoordControl
{
    public partial class UserControlPass : UserControl
    {
        public string Title
        {
            set
            {
                groupBoxPassName.Text = value;
            }
            get
            {
                return groupBoxPassName.Text;
            }
        }


        public int Intensity
        {
            get
            {
                return (int) numericUpDownIntensity.Value;
            }
            set
            {
                numericUpDownIntensity.Value = value;
            }
        }

        public int LineCount
        {
            get
            {
                return (int)numericUpDownLinesN.Value;
            }
            set
            {
                numericUpDownLinesN.Value = value;
            }
        }


        public double LineWidth
        {
            get
            {
                return (double)numericUpDownLineWidth.Value;
            }
            set
            {
                numericUpDownLineWidth.Value = (decimal)value;
            }
        }

        public int LeftPart
        {
            get
            {
                return (int)numericUpDownLeftPart.Value;
            }
            set
            {
                numericUpDownLeftPart.Value = value;
            }
        }

        public int DirectPart
        {
            get
            {
                return (int)numericUpDownDirectPart.Value;
            }
            set
            {
                numericUpDownDirectPart.Value = value;
            }
        }

        public int RightPart
        {
            get
            {
                return (int)numericUpDownRightPart.Value;
            }
            set
            {
                numericUpDownRightPart.Value = value;
            }
        }


        public bool IsReadOnly
        {
            set
            {
                numericUpDownIntensity.ReadOnly = value;
                numericUpDownLinesN.ReadOnly = value;
                numericUpDownLineWidth.ReadOnly = value;
            }
            get
            {
                return numericUpDownIntensity.ReadOnly;
            }
        }

        public UserControlPass()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
