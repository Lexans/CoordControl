using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CoordControl.Core.Domains;

namespace CoordControl.Forms
{
    public interface IFormPlanEdit
    {
        string PlanName { get; set; }
        int Cycle { get; set; }
        IList<Cross> CrossList { set; }
        Cross SelectedCross { get; }

        CrossPlan CrossPlanViewed { get; set; }
        int PhaseOffset { get; set; }
        int P1MainInterval { get; set; }
        int P1MidInterval { get; set; }
        int P2MainInterval { get; set; }
        int P2MidInterval { get; set; }

        void ComboBoxRefreshItems();
        event EventHandler SaveButtonClick;
        event EventHandler CrossListSelected;
        event EventHandler CycleChanged;
    }


    public partial class FormPlanEdit : Form, IFormPlanEdit
    {
        public FormPlanEdit()
        {
            InitializeComponent();
        }

        #region экранирование полей
        public string PlanName
        {
            get
            {
                return textBoxPlanName.Text;
            }
            set
            {
                textBoxPlanName.Text = value;
            }
        }

        public int Cycle
        {
            get
            {
                return (int)numericUpDownCycle.Value;
            }
            set
            {
                numericUpDownCycle.Value = value;
            }
        }

        public IList<Cross> CrossList
        {
            set
            {
                crossBindingSource.DataSource = value;
                crossBindingSource.ResetBindings(false);
            }
        }

        public Cross SelectedCross
        {
            get { 
                return (Cross)comboBoxCrosses.SelectedItem;
            }
        }

        private CrossPlan crossPlan;
        public CrossPlan CrossPlanViewed
        {
            get
            {
                crossPlan.PhaseOffset = PhaseOffset;
                crossPlan.P1MainInterval = P1MainInterval;
                crossPlan.P2MainInterval = P2MainInterval;
                crossPlan.P1MediateInterval = P1MidInterval;
                crossPlan.P2MediateInterval = P2MidInterval;
                return crossPlan;
            }
            set
            {
                SetOffsetEnable();
                crossPlan = value;
                PhaseOffset = crossPlan.PhaseOffset;
                P1MainInterval= crossPlan.P1MainInterval;
                P2MainInterval = crossPlan.P2MainInterval;
                P1MidInterval = crossPlan.P1MediateInterval;
                P2MidInterval = crossPlan.P2MediateInterval; 
            }
        }

        public int PhaseOffset
        {
            get
            {
                return (int)numericUpDownOffset.Value;
            }
            set
            {
                numericUpDownOffset.Value = value;
            }
        }

        public int P1MainInterval
        {
            get
            {
                return (int)numericUpDownP1MainInterval.Value;
            }
            set
            {
                numericUpDownP1MainInterval.Value = value;
            }
        }

        public int P1MidInterval
        {
            get
            {
                return (int)numericUpDownP1MidInterval.Value;
            }
            set
            {
                numericUpDownP1MidInterval.Value = value;
            }
        }

        public int P2MainInterval
        {
            get
            {
                return (int)numericUpDownP2MainInterval.Value;
            }
            set
            {
                numericUpDownP2MainInterval.Value = value;
            }
        }

        public int P2MidInterval
        {
            get
            {
                return (int)numericUpDownP2MidInterval.Value;
            }
            set
            {
                numericUpDownP2MidInterval.Value = value;
            }
        }
        #endregion

        #region проброс событий
        public event EventHandler SaveButtonClick;

        public event EventHandler CrossListSelected;

        private void comboBoxCrosses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CrossListSelected != null) CrossListSelected(this, EventArgs.Empty);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (SaveButtonClick != null) SaveButtonClick(this, EventArgs.Empty);
        }

        public event EventHandler CycleChanged;
        private void numericUpDownCycle_ValueChanged(object sender, EventArgs e)
        {
            if (CycleChanged != null) CycleChanged(this, EventArgs.Empty);
        }
        #endregion

        public void ComboBoxRefreshItems()
        {
            int selIndx = comboBoxCrosses.SelectedIndex;
            crossBindingSource.ResetBindings(false);

            if (selIndx < comboBoxCrosses.Items.Count)
                comboBoxCrosses.SelectedIndex = selIndx;
        }

        private void numericUpDownP1MainInterval_ValueChanged(object sender, EventArgs e)
        {
            int value = Cycle - P1MainInterval - P1MidInterval - P2MidInterval;
            if (value < 7)
            {
                P1MainInterval += value - 7;
            }
            else
                P2MainInterval = value;
        }

        private void numericUpDownP2MainInterval_ValueChanged(object sender, EventArgs e)
        {
            int value = Cycle - P2MainInterval - P1MidInterval - P2MidInterval;
            if (value < 7)
            {
                P2MainInterval += value - 7;
            }
            else
                P1MainInterval = value;
        }

        private void numericUpDownP1MidInterval_ValueChanged(object sender, EventArgs e)
        {
            int value = Cycle - P2MainInterval - P1MidInterval - P2MidInterval;
            if (value < 7)
            {
                MessageBox.Show("Длительность основного такта должна быть больше 7", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                P1MidInterval += value - 7;
            }
            else
                P1MainInterval = value;
        }

        private void numericUpDownP2MidInterval_ValueChanged(object sender, EventArgs e)
        {
            int value = Cycle - P1MainInterval - P1MidInterval - P2MidInterval;
            if (value < 7)
            {
                MessageBox.Show("Длительность основного такта должна быть больше 7", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                P2MidInterval += value - 7;
            }
            else
                P2MainInterval = value;
        }

        private void SetOffsetEnable() {
                numericUpDownOffset.Enabled = (SelectedCross.Position != 0);
        }

    }
}
