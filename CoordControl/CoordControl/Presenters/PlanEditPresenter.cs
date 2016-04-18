using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CoordControl.Models;
using CoordControl.Forms;
using CoordControl.Core.Domains;

namespace CoordControl.Presenters
{
    class PlanEditPresenter
    {
        private readonly IFormPlanEdit _view;
        private readonly PlanEditModel _model;

        private Plan _plan;

        public PlanEditPresenter(IFormPlanEdit view, PlanEditModel model, Plan plan)
        {
            _model = model;
            _plan = plan;
            _view = view;
            PlanFill();

            _view.SaveButtonClick += _view_SaveButtonClick;
            _view.CrossListSelected += _view_CrossListSelected;
            _view.CycleChanged += _view_CycleChanged;
        }

        void _view_CycleChanged(object sender, EventArgs e)
        {
            int cycleIncrement = _view.Cycle - _plan.Cycle;

            if (cycleIncrement > 0) {
                while (cycleIncrement < 0)
                {
                    foreach (CrossPlan c in _plan.CrossPlans)
                    {
                        if (c.P1MainInterval < 60)
                            c.P1MainInterval++;
                        else if (c.P2MainInterval < 60)
                            c.P2MainInterval++;
                        else if (c.P1MediateInterval < 8)
                            c.P1MediateInterval ++;
                        else if (c.P2MediateInterval < 8)
                            c.P2MediateInterval++;
                    }

                    cycleIncrement--;
                }
            }
            else if (cycleIncrement < 0)
            {
                while (cycleIncrement < 0)
                {
                    foreach (CrossPlan c in _plan.CrossPlans) {
                        if (c.P1MainInterval > 7)
                            c.P1MainInterval--;
                        else if (c.P2MainInterval > 7)
                            c.P2MainInterval--;
                        else if (c.P1MediateInterval > 3)
                            c.P1MediateInterval--;
                        else if (c.P2MediateInterval > 3)
                            c.P2MediateInterval--;
                    }
                    
                    cycleIncrement++;
                }
            }

            _plan.Cycle = _view.Cycle;

            PlanFill();
        }

        void _view_CrossListSelected(object sender, EventArgs e)
        {
            //сохранение плана перекрестка в куче
            CrossPlan cp = _view.CrossPlanViewed;

            //отображение нового плана перекретска
            _view.CrossPlanViewed = _plan.CrossPlans.First((x) => x.Cross == _view.SelectedCross);
        }

        void _view_SaveButtonClick(object sender, EventArgs e)
        {
            CrossPlan cp = _view.CrossPlanViewed;

            _plan.Title = _view.PlanName;
            _plan.Cycle = _view.Cycle;

            _model.Save(_plan);
        }


        private void PlanFill() {
            _view.PlanName = _plan.Title;
            _view.Cycle = _plan.Cycle;

            _view.CrossList = _plan.Route.Crosses;
            _view.CrossPlanViewed = _plan.CrossPlans.First((x) => x.Cross == _view.SelectedCross);
        }



    }
}
