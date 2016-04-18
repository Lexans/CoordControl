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
    public interface IFormRoute
    {
        string StreetName { get; set; }
        int CrossCount { get; set; }
        bool CrossCountReadOnly { get; set; }
        IList<Cross> CrossList { set; }
        Cross Cross { get; set; }
        Cross SelectedCross { get; }
        String CrossStreetName { get; set; }
        Pass LeftPass { get; set; }
        Pass RightPass { get; set; }
        Pass TopPass { get; set; }
        Pass BottomPass { get; set; }
        Road RightRoad { get; set; }

        String FormTitle { set; } 

        void ComboBoxRefreshItems();

        event EventHandler SaveButtonClick;
        event EventHandler CrossCountChanged;
        event EventHandler CrossListSelected;
    }

    public partial class FormRoute : Form, IFormRoute
    {
        public FormRoute()
        {
            InitializeComponent();
            textBoxStreetNameMagistral.Text = " ";
        }


        #region экранирование полей
        public string StreetName
        {
            get
            {
                return textBoxStreetNameMagistral.Text;
            }
            set
            {
                textBoxStreetNameMagistral.Text = value;
            }
        }

        public int CrossCount
        {
            get
            {
                return (int) numericUpDownCrossCount.Value;
            }
            set
            {
                numericUpDownCrossCount.Value = value;
            }
        }

        public string FormTitle
        {
            set { this.Text = value; }

        }


        public bool CrossCountReadOnly
        {
            get
            {
                return numericUpDownCrossCount.ReadOnly;
            }
            set
            {
                numericUpDownCrossCount.ReadOnly = value;
            }
        }


        public IList<Cross> CrossList
        {
            set {
                crossBindingSource.DataSource = value;
                crossBindingSource.ResetBindings(false);
            }
        }

        public Cross SelectedCross
        {
            get
            {
               return (Cross) comboBoxCrosses.SelectedItem;
            }
        }

        private Cross cross;
        public Cross Cross
        {
            get {
                cross.PassBottom = BottomPass;
                cross.PassTop = TopPass;
                cross.PassLeft = LeftPass;
                cross.PassRight = RightPass;
                cross.StreetName = CrossStreetName;
                if (cross.RoadRight != null)
                {
                    RightRoad = cross.RoadRight;
                }

                return cross;
            }
            set
            {
                cross = value;
                SetIntensityReadonly();

                BottomPass = value.PassBottom;
                TopPass = value.PassTop;
                LeftPass = value.PassLeft;
                RightPass = value.PassRight;
                CrossStreetName = value.StreetName;
                if (value.RoadRight != null)
                {
                    numericUpDownRoadLength.Value = cross.RoadRight.Length;
                    numericUpDownRoadSpeed.Value = cross.RoadRight.Speed;
                }
            }
        }

        public string CrossStreetName
        {
            get
            {
                return textBoxStreetNameCross.Text;
            }
            set
            {
                textBoxStreetNameCross.Text = value;
            }
        }



        #region подходы
        private Pass leftPass;
        public Pass LeftPass
        {
            get
            {
                FromControlToPass(userControlPassLeft, leftPass);
                return leftPass;
            }
            set
            {
                leftPass = value;
                FromPassToControl(leftPass, userControlPassLeft);
            }
        }

        private Pass rightPass;
        public Pass RightPass
        {
            get
            {
                FromControlToPass(userControlPassRight, rightPass);
                return rightPass;
            }
            set
            {
                rightPass = value;
                FromPassToControl(rightPass, userControlPassRight);
            }
        }

        private Pass topPass;
        public Pass TopPass
        {
            get
            {
                FromControlToPass(userControlPassUp, topPass);
                return topPass;
            }
            set
            {
                topPass = value;
                FromPassToControl(topPass, userControlPassUp);
            }
        }

        private Pass bottomPass;

        public Pass BottomPass
        {
            get
            {
                FromControlToPass(userControlPassDown, bottomPass);
                return bottomPass;
            }
            set
            {
                bottomPass = value;
                FromPassToControl(bottomPass, userControlPassDown);
            }
        }

        private void FromControlToPass(UserControlPass ucp, Pass ps)
        {
            ps.DirectPart = ucp.DirectPart;
            ps.RightPart = ucp.RightPart;
            ps.LeftPart = ucp.LeftPart;

            ps.LinesCount = ucp.LineCount;
            ps.LineWidth = ucp.LineWidth;
            ps.Intensity = ucp.Intensity;
        }


        private void FromPassToControl(Pass ps, UserControlPass ucp)
        {
            ucp.DirectPart = ps.DirectPart;
            ucp.RightPart = ps.RightPart;
            ucp.LeftPart = ps.LeftPart;

            ucp.LineCount = ps.LinesCount;
            ucp.LineWidth = ps.LineWidth;
            ucp.Intensity = ps.Intensity;
        }
        #endregion

        private Road rightRoad;
        public Road RightRoad
        {
            get
            {
                rightRoad.Length = (int)numericUpDownRoadLength.Value;
                rightRoad.Speed = (int)numericUpDownRoadSpeed.Value;
                return rightRoad;
            }
            set
            {
                rightRoad = value;
                numericUpDownRoadLength.Value = rightRoad.Length;
                numericUpDownRoadSpeed.Value = rightRoad.Speed;
            }
        }
        #endregion

        #region проброс событий
        public event EventHandler SaveButtonClick;

        public event EventHandler CrossCountChanged;

        public event EventHandler CrossListSelected;

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (SaveButtonClick != null) SaveButtonClick(this, EventArgs.Empty);
        }

        private void comboBoxCrosses_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetIntensityReadonly();
            if (CrossListSelected != null) CrossListSelected(this, EventArgs.Empty);
        }

        private void numericUpDownCrossCount_ValueChanged(object sender, EventArgs e)
        {
            if (CrossCountChanged != null) CrossCountChanged(this, EventArgs.Empty);
        }
        #endregion

        #region код формы

        public void ComboBoxRefreshItems()
        {
            int selIndx = comboBoxCrosses.SelectedIndex;
            crossBindingSource.ResetBindings(false);

            if (selIndx < comboBoxCrosses.Items.Count)
                comboBoxCrosses.SelectedIndex = selIndx;
        }

        private void SetIntensityReadonly()
        {
            
            int pos = comboBoxCrosses.Items.IndexOf(cross);
            int count = comboBoxCrosses.Items.Count;

            userControlPassLeft.IsIntensityReadOnly = (pos != 0);
            userControlPassRight.IsIntensityReadOnly = (pos != (count - 1));

            groupBoxRoad.Visible = (pos != (count - 1));
        }

        private void textBoxStreetNameCross_TextChanged(object sender, EventArgs e)
        {
            ComboBoxRefreshItems();
            CheckSaveButtonEnable();
        }
        #endregion

        private void textBoxStreetNameMagistral_TextChanged(object sender, EventArgs e)
        {
            CheckSaveButtonEnable();
        }

        private void CheckSaveButtonEnable()
        {
            if (String.IsNullOrWhiteSpace(textBoxStreetNameMagistral.Text))
            {
                buttonSave.Enabled = false;
                errorProvider1.SetError(textBoxStreetNameMagistral, "пустое значение");
                return;
            }
            else
            {
                errorProvider1.SetError(textBoxStreetNameMagistral, null);
                buttonSave.Enabled = true;
            }

            if (String.IsNullOrWhiteSpace(textBoxStreetNameCross.Text))
            {
                comboBoxCrosses.Enabled = false;
                buttonSave.Enabled = false;
                errorProvider1.SetError(textBoxStreetNameCross, "пустое значение");
            }
            else
            {
                errorProvider1.SetError(textBoxStreetNameCross, null);
                comboBoxCrosses.Enabled = true;
                buttonSave.Enabled = true;
            }
        }

    }
}
