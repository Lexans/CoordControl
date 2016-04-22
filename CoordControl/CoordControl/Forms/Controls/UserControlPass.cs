using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoordControl.Forms.Controls
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
                numericUpDownLeftPart.ValueChanged -= numericUpDownDirectPart_ValueChanged;
                numericUpDownLeftPart.Value = value;
                numericUpDownLeftPart.ValueChanged += numericUpDownDirectPart_ValueChanged;
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
                numericUpDownDirectPart.ValueChanged -= numericUpDownDirectPart_ValueChanged;
                numericUpDownDirectPart.Value = value;
                numericUpDownDirectPart.ValueChanged += numericUpDownDirectPart_ValueChanged;
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
                numericUpDownRightPart.ValueChanged -= numericUpDownRightPart_ValueChanged;
                numericUpDownRightPart.Value = value;
                numericUpDownRightPart.ValueChanged += numericUpDownRightPart_ValueChanged;
            }
        }


        public bool IsIntensityReadOnly
        {
            set
            {
                numericUpDownIntensity.Enabled = !value;
            }
            get
            {
                return !numericUpDownIntensity.Enabled;
            }
        }

        public UserControlPass()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDownLeftPart_ValueChanged(object sender, EventArgs e)
        {
            decimal rightValue = 100 - numericUpDownDirectPart.Value - numericUpDownLeftPart.Value;

            if (rightValue < 0)
            {
                MessageBox.Show("Сумма частей должна равняться 100", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                numericUpDownLeftPart.Value += rightValue; 
            }
            else
                numericUpDownRightPart.Value = rightValue;
        }

        private void numericUpDownRightPart_ValueChanged(object sender, EventArgs e)
        {

            decimal leftValue = 100 - numericUpDownDirectPart.Value - numericUpDownRightPart.Value;

            if (leftValue < 0)
            {
                MessageBox.Show("Сумма частей должна равняться 100", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                numericUpDownRightPart.Value += leftValue; 
            }
            else
                numericUpDownLeftPart.Value = leftValue;
        }

        private void numericUpDownDirectPart_ValueChanged(object sender, EventArgs e)
        {
            decimal rightValue = (100 - numericUpDownDirectPart.Value -
                numericUpDownLeftPart.Value);

            if (rightValue < 0)
            {
                MessageBox.Show("Сумма частей должна равняться 100", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                numericUpDownDirectPart.Value += rightValue; 
            }
            else
                numericUpDownRightPart.Value = rightValue;

        }

        private void numericUpDownLinesN_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownIntensity.Enabled)
            {
                numericUpDownIntensity.Minimum = 300 * numericUpDownLinesN.Value;
                numericUpDownIntensity.Maximum = 700 * numericUpDownLinesN.Value;
            }
            else
            {
                numericUpDownIntensity.Maximum = 10000;
                numericUpDownIntensity.Minimum = 0;
            }
            
        }
    }
}
