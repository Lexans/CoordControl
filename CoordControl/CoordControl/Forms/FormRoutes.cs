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
    public interface IFormRoutes
    {
        List<Route> RouteList { set; }
        Route SelectedRoute { get; }

        event EventHandler PlansButtonClick;
        event EventHandler EditClick;
        event EventHandler AddClick;
        event EventHandler DeleteClick;
        event EventHandler HelpClick;
        event EventHandler AboutClick;
    }

    public partial class FormRoutes : Form, IFormRoutes
    {
        public FormRoutes()
        {
            InitializeComponent();
        }



        #region экранирование данных
        public List<Route> RouteList
        {
            set {
                routeBindingSource.DataSource = value;
                routeBindingSource.ResetBindings(false);
            }
        }

        public Route SelectedRoute
        {
            get {
                return (Route)routeBindingSource.Current;
            }
        }
        #endregion


        #region проброс событий
        public event EventHandler PlansButtonClick;

        public event EventHandler EditClick;

        public event EventHandler AddClick;

        public event EventHandler DeleteClick;

        public event EventHandler HelpClick;

        public event EventHandler AboutClick;
        

        private void buttonPlans_Click(object sender, EventArgs e)
        {
            if (PlansButtonClick != null)
            {
                Hide();
                PlansButtonClick(this, EventArgs.Empty);
                Show();
            }
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AddClick != null) AddClick(this, EventArgs.Empty);
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (EditClick != null) EditClick(this, EventArgs.Empty);
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Вы действительно хотите удалить магистраль?", "Удалить магистраль", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DeleteClick != null && dr == System.Windows.Forms.DialogResult.Yes)
                DeleteClick(this, EventArgs.Empty);
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (HelpClick != null) HelpClick(this, EventArgs.Empty);
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AboutClick != null) AboutClick(this, EventArgs.Empty);
        }
        #endregion


        #region логика формы
        private void dataGridViewRoutes_CurrentCellChanged(object sender, EventArgs e)
        {
            CheckElementsState();
        }

        #endregion

        private void FormRoutes_Load(object sender, EventArgs e)
        {
            CheckElementsState();
        }

        private void CheckElementsState()
        {
            bool isSelected = (SelectedRoute != null);

            buttonPlans.Enabled = isSelected;
            изменитьToolStripMenuItem.Enabled = isSelected;
            удалитьToolStripMenuItem.Enabled = isSelected;
        }

        private void dataGridViewRoutes_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dataGridViewRoutes.Rows[e.RowIndex].Height = 36;
        }

    }
}
