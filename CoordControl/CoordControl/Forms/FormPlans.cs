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
    public interface IFormPlans
    {
        List<Plan> PlanList { set; }
        Plan SelectedPlan { get; }
        String TitleForm { get;  set; }

        event EventHandler ModelingButtonClick;
        event EventHandler EditClick;
        event EventHandler DeleteClick;
        event EventHandler ViewClick;

        event EventHandler CalcAnalytClick;
        event EventHandler CalcImitClick;
        event EventHandler CalcSimpleClick;
        event EventHandler CalcMoveTimeClick;
        event EventHandler CalcWithoutShiftsClick;

    }

    public partial class FormPlans : Form, IFormPlans
    {
        public FormPlans()
        {
            InitializeComponent();
        }


        #region экранирование данных
        public List<Plan> PlanList
        {
            set
            {
                planBindingSource.DataSource = value;
                planBindingSource.ResetBindings(false);
            }
        }

        public Plan SelectedPlan
        {
            get {
                if (planBindingSource.Count > 0)
                    return (Plan)planBindingSource.Current;
                else
                    return null;
            }
        }

        public string TitleForm
        {
            set { this.Text = value; }
            get { return this.Text; }
        }
        #endregion

        #region проброс событий
        public event EventHandler ModelingButtonClick;

        public event EventHandler EditClick;

        public event EventHandler DeleteClick;

        public event EventHandler ViewClick;

        public event EventHandler CalcAnalytClick;

        public event EventHandler CalcImitClick;
        
        public event EventHandler CalcSimpleClick;

        public event EventHandler CalcMoveTimeClick;

        public event EventHandler CalcWithoutShiftsClick;
        

        private void buttonModeling_Click(object sender, EventArgs e)
        {
            if (ModelingButtonClick != null) ModelingButtonClick(this, EventArgs.Empty);
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (EditClick != null) EditClick(this, EventArgs.Empty);
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DeleteClick != null) DeleteClick(this, EventArgs.Empty);

        }

        private void toolStripButtonView_Click(object sender, EventArgs e)
        {
            if (ViewClick != null) ViewClick(this, EventArgs.Empty);
        }

        private void аналитическийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CalcAnalytClick != null) CalcAnalytClick(this, EventArgs.Empty);
        }

        private void имитационныйЭкспериментToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CalcImitClick != null) CalcImitClick(this, EventArgs.Empty);
        }

        private void простойМетодToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CalcSimpleClick != null) CalcSimpleClick(this, EventArgs.Empty);
        }

        private void поВремениПроездаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CalcMoveTimeClick != null) CalcMoveTimeClick(this, EventArgs.Empty);
        }

        private void безСдвиговToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CalcWithoutShiftsClick != null) CalcWithoutShiftsClick(this, EventArgs.Empty);
        }
        #endregion


        #region логика формы
        private void dataGridViewCoordProgs_CurrentCellChanged(object sender, EventArgs e)
        {
            CheckElementsState();
        }
        #endregion


        private void CheckElementsState()
        {
            bool isSelected = (SelectedPlan != null);

            buttonModeling.Enabled = isSelected;
            изменитьToolStripMenuItem.Enabled = isSelected;
            удалитьToolStripMenuItem.Enabled = isSelected;
            toolStripButtonView.Enabled = isSelected;
        }

        private void FormPlans_Load(object sender, EventArgs e)
        {
            CheckElementsState();
        }



    }
}
