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

    public interface IFormPlanView
    {
        string Document { set; get; }

        string PlanTitle { set; }

        event EventHandler DocumentSave;
    }

    public partial class FormPlanView : Form, IFormPlanView
    {
        public FormPlanView()
        {
            InitializeComponent();
        }


        public string Document
        {
            set {
                webBrowser1.DocumentText = value;
            }

            get
            {
                return webBrowser1.DocumentText;
            }
        }

        private string _planTitle;
        public string PlanTitle
        {
            set {
                _planTitle = value;
                Text += " «" + _planTitle + "»";
                saveFileDialog1.FileName = _planTitle;
            }
        }

        public event EventHandler DocumentSave;

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = saveFileDialog1.ShowDialog();

            if (dr == DialogResult.OK)
            {
                if (DocumentSave != null)
                    DocumentSave((object)saveFileDialog1.FileName, EventArgs.Empty);
            }
        }


    }
}
