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

            _view.CalcMoveTimeCorrectClick += _view_CalcSimpleClick;
            _view.CalcMoveTimeClick += _view_CalcMoveTimeClick;
            _view.CalcWithoutShiftsClick += _view_CalcWithoutShiftsClick;
            _view.CalcAnalytClick += _view_CalcAnalytClick;
            _view.CalcImitRightWayClick += _view_CalcImitRightWayClick;
            _view.CalcImitLeftWayClick += _view_CalcImitLeftWayClick;
            _view.CalcImitSumClick += _view_CalcImitSumClick;

            _view.ModelingButtonClick += _view_ModelingButtonClick;

            _view.ViewClick += _view_ViewClick;
        }

        void _view_ViewClick(object sender, EventArgs e)
        {
            FormPlanView fpv = new FormPlanView();
            
            PlanViewModel pvm = new PlanViewModel();
            PlanViewPresenter pvp = new PlanViewPresenter(fpv, pvm, _model.GetById(_view.SelectedPlan.ID));
            fpv.ShowDialog();
        }

        void _view_CalcImitSumClick(object sender, EventArgs e)
        {
            PlanCalculator pc = new PlanCalculatorImit();
            Plan p = pc.CalcFullPlan(currentRoute);
            currentRoute.Plans.Add(p);

            p.Title = "Имитационная модель (оба направления)";
            _model.SavePlan(p);

            _view.PlanList = _model.GetPlansByRoute(currentRoute);
        }

        void _view_CalcImitLeftWayClick(object sender, EventArgs e)
        {
            PlanCalculatorImit pc = new PlanCalculatorImit();
            pc.OptimizationWay = PlanCalculatorWay.Reverse;

            Plan p = pc.CalcFullPlan(currentRoute);
            currentRoute.Plans.Add(p);

            p.Title = "Имитационная модель (обратное направление)";
            _model.SavePlan(p);

            _view.PlanList = _model.GetPlansByRoute(currentRoute);
        }

        void _view_CalcImitRightWayClick(object sender, EventArgs e)
        {
            PlanCalculatorImit pc = new PlanCalculatorImit();
            pc.OptimizationWay = PlanCalculatorWay.Direct;

            Plan p = pc.CalcFullPlan(currentRoute);
            currentRoute.Plans.Add(p);

            p.Title = "Имитационная модель (прямое направление)";
            _model.SavePlan(p);

            _view.PlanList = _model.GetPlansByRoute(currentRoute);
        }


        void _view_CalcAnalytClick(object sender, EventArgs e)
        {
            PlanCalculator pc = new PlanCalculatorAnalytic();
            Plan p = pc.CalcFullPlan(currentRoute);
            currentRoute.Plans.Add(p);

            p.Title = "Аналитическая модель";
            _model.SavePlan(p);

            _view.PlanList = _model.GetPlansByRoute(currentRoute);
        }

        void _view_CalcWithoutShiftsClick(object sender, EventArgs e)
        {
            PlanCalculator pc = new PlanCalculatorWithoutShifts();
            Plan p = pc.CalcFullPlan(currentRoute);
            currentRoute.Plans.Add(p);

            p.Title = "Без сдвигов фаз";
            _model.SavePlan(p);

            _view.PlanList = _model.GetPlansByRoute(currentRoute);
        }

        void _view_CalcMoveTimeClick(object sender, EventArgs e)
        {
            PlanCalculator pc = new PlanCalculatorMoveTime();
            Plan p = pc.CalcFullPlan(currentRoute);
            currentRoute.Plans.Add(p);

            p.Title = "По времени проезда";
            _model.SavePlan(p);

            _view.PlanList = _model.GetPlansByRoute(currentRoute);
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

            p.Title = "По времени проезда (с коррекцией)";
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
