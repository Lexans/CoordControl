using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoordControl.Forms;
using CoordControl.Models;
using CoordControl.Core.Domains;

namespace CoordControl.Presenters
{
    class PlanViewPresenter
    {
        private IFormPlanView _view;
        private PlanViewModel _model;
        private Plan _plan;

        public PlanViewPresenter(IFormPlanView view, PlanViewModel model, Plan plan)
        {
            _view = view;
            _model = model;
            _plan = plan;

            ShowDocument();
            _view.PlanTitle = _plan.Title;
            _view.DocumentSave += _view_DocumentSave;
        }

        void _view_DocumentSave(object sender, EventArgs e)
        {
            _model.SaveDoc((String)sender, _view.Document);
        }

        private void ShowDocument()
        {
            String str = global::CoordControl.Properties.Resources.PlanDocHeader;
            str += @"<title id='title'>"+_plan.Title+@"</title></head><body>";
            str += @"<h1>Программа координированного управления на участке магистрали по улице «"+_plan.Route.StreetName+
                "» от пересечения с улицей «" + _plan.Route.Crosses.First().StreetName + "» до улицы «"
                + _plan.Route.Crosses.Last().StreetName + "»</h1>";

            int n = _plan.Route.Crosses.Count();
            for(int i = 0; i < n; i++)
            {
                CrossPlan cp = (CrossPlan) _plan.CrossPlans.First(
                    (x) => x.Cross.Position == i
                    );

                str += @"<h2>Перекресток " + (i+1).ToString() + " (улица «"+cp.CrossName+"»)</h2>";
                str += @"<p>Сдвиг фаз: "+cp.PhaseOffset.ToString()+" сек</p>";

                str += "<table cellspacing='0'>" +
            "<tr><th rowspan='2'><font color='white'>.</font></th><th rowspan='2'>График включения сигналов</th><th colspan='4'>Длительность, сек</th></tr>" +
            "<tr><th>t<sub>з</sub></th><th>t<sub>ж</sub></th><th>t<sub>к</sub></th><th>t<sub>кж</sub></th></tr>" +
            "<tr><td>Главная улица</td><td align='center'>";

                str += "<div class = 'light-box' id = 'graph-box' style='width:"+(_plan.Cycle * 7).ToString()+"px'>";
                str += "<div class = 'light-box' id = 'green-box' style='width:"+(cp.P1MainInterval * 7).ToString()+"px'></div>";
                str += "<div class = 'light-box' id = 'yellow-box' style='width:" + (cp.P1MediateInterval * 7).ToString() + "px'></div>";
                str += "<div class = 'light-box' id = 'red-box' style='width:" + (cp.P2MainInterval * 7).ToString() + "px'></div>";
                str += "<div class = 'light-box' id = 'yellowred-box' style='width:" + (cp.P2MediateInterval * 7).ToString() + "px'></div>";
                str += "</div></td>";

                str += "<td>" + (cp.P1MainInterval).ToString() + "</td><td>" + (cp.P1MediateInterval).ToString() +
                    "</td><td>" + (cp.P2MainInterval).ToString() + "</td><td>" + (cp.P2MediateInterval).ToString() + "</td>";

                str += "</tr><tr><td>Второстепенная улица</td><td align='center'>";
                str += "<div class = 'light-box' id = 'graph-box' style='width:" + (_plan.Cycle * 7).ToString() + "px'>";
                str += "<div class = 'light-box' id = 'red-box' style='width:" + (cp.P1MainInterval * 7).ToString() + "px'></div>";
                str += "<div class = 'light-box' id = 'yellowred-box' style='width:" + (cp.P1MediateInterval * 7).ToString() + "px'></div>";
                str += "<div class = 'light-box' id = 'green-box' style='width:" + (cp.P2MainInterval * 7).ToString() + "px'></div>";
                str += "<div class = 'light-box' id = 'yellow-box' style='width:" + (cp.P2MediateInterval * 7).ToString() + "px'></div>";
                str += "</div></td>";

                str += "<td>" + (cp.P2MainInterval).ToString() + "</td><td>" + (cp.P2MediateInterval).ToString() +
                    "</td><td>" + (cp.P1MainInterval).ToString() + "</td><td>" + (cp.P1MediateInterval).ToString() + "</td>";
                str += "</tr></table> ";
            }

            str += "</body></html>";

            _view.Document = str;
        }
    }
}
