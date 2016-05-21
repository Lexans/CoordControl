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
        event EventHandler CalcImitRightWayClick;
        event EventHandler CalcImitLeftWayClick;
        event EventHandler CalcImitSumClick;
        event EventHandler CalcMoveTimeCorrectClick;
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
        
        public event EventHandler CalcMoveTimeCorrectClick;

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
            DialogResult dr = MessageBox.Show("Вы действительно хотите удалить программу координации?", "Удалить программу координации", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(DeleteClick != null && dr == System.Windows.Forms.DialogResult.Yes)
                DeleteClick(this, EventArgs.Empty);
        }

        private void toolStripButtonView_Click(object sender, EventArgs e)
        {
            if (ViewClick != null) ViewClick(this, EventArgs.Empty);
        }

        private void аналитическийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CalcAnalytClick != null) CalcAnalytClick(this, EventArgs.Empty);
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
            просмотрToolStripMenuItem.Enabled = isSelected;
        }

        private void FormPlans_Load(object sender, EventArgs e)
        {
            CheckElementsState();
        }

        private void просмотрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ViewClick != null) ViewClick(this, EventArgs.Empty);
        }

        private void безКоррекцииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CalcMoveTimeClick != null) CalcMoveTimeClick(this, EventArgs.Empty);
        }

        private void сКоррекциейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CalcMoveTimeCorrectClick != null) CalcMoveTimeCorrectClick(this, EventArgs.Empty);
        }





        public event EventHandler CalcImitRightWayClick;

        public event EventHandler CalcImitLeftWayClick;

        public event EventHandler CalcImitSumClick;

        private void оптимизацияПрямогоНаправленияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CalcImitRightWayClick != null)
                CalcImitRightWayClick(this, EventArgs.Empty);
        }

        private void обратноеНаправлениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CalcImitLeftWayClick != null)
                CalcImitLeftWayClick(this, EventArgs.Empty);
        }

        private void обаНаправленияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CalcImitSumClick != null)
                CalcImitSumClick(this, EventArgs.Empty);
        }

        private void dataGridViewCoordProgs_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dataGridViewCoordProgs.Rows[e.RowIndex].Height = 36;
        }
    }
}
