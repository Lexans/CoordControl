using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CoordControl.Core.Domains;
using CoordControl.Forms;
using CoordControl.Models;
using System.Windows.Forms;
using CoordControl.Core;

namespace CoordControl.Presenters
{
    public class PlansPresenter
    {
        private readonly IFormPlans _view;
        private readonly PlansModel _model;

        private Route currentRoute;

        public PlansPresenter(IFormPlans view, PlansModel model, Route r)
        {
            _view = view;
            _model = model;
            currentRoute = r;
            _view.PlanList = _model.GetPlansByRoute(r);
            _view.TitleForm += " «" + currentRoute.StreetName + "»";

            _view.EditClick += _view_EditClick;
            _view.DeleteClick += _view_DeleteClick;

            _view.CalcSimpleClick += _view_CalcSimpleClick;

            _view.ModelingButtonClick += _view_ModelingButtonClick;
        }

        void _view_ModelingButtonClick(object sender, EventArgs e)
        {
            FormModeling form = new FormModeling();
            ModelingPresenter presenter = new ModelingPresenter(form, _model.GetById(_view.SelectedPlan.ID));

             form.ShowDialog();

        }

        void _view_CalcSimpleClick(object sender, EventArgs e)
        {
            PlanCalculator pc = new PlanCalculatorSimple();
            Plan p = pc.CalcFullPlan(currentRoute);
            currentRoute.Plans.Add(p);

            p.Title = "Простой метод расчета";
            _model.SavePlan(p);

            _view.PlanList = _model.GetPlansByRoute(currentRoute);
        }

        void _view_DeleteClick(object sender, EventArgs e)
        {
            _model.DeletePlan(_view.SelectedPlan);
            _view.PlanList = _model.GetPlansByRoute(currentRoute);
        }

        void _view_EditClick(object sender, EventArgs e)
        {
           FormPlanEdit form = new FormPlanEdit();
           PlanEditModel model = new PlanEditModel();
           PlanEditPresenter presenter =
               new PlanEditPresenter(form, model, _model.GetById(_view.SelectedPlan.ID));

            if (form.ShowDialog() == DialogResult.OK)
                _view.PlanList = _model.GetPlansByRoute(currentRoute);
        }


    }

}
