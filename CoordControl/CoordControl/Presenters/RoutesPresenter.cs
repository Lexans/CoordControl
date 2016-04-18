using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CoordControl.Core.Domains;
using CoordControl.Forms;
using CoordControl.Models;
using System.Windows.Forms;

namespace CoordControl.Presenters
{
    public class RoutesPresenter
    {
        private readonly IFormRoutes _view;
        private readonly RoutesModel _model;

        public RoutesPresenter(IFormRoutes view, RoutesModel model)
        {
            _view = view;
            _model = model;
            _view.RouteList = _model.GetRoutes();

            _view.AddClick += _view_AddClick;
            _view.EditClick += _view_EditClick;
            _view.DeleteClick += _view_DeleteClick;
            _view.AboutClick += _view_AboutClick;

            _view.PlansButtonClick += _view_PlansButtonClick;
        }

        void _view_AboutClick(object sender, EventArgs e)
        {
            FormAbout form = new FormAbout();
            form.ShowDialog();
        }

        void _view_PlansButtonClick(object sender, EventArgs e)
        {
            FormPlans form = new FormPlans();
            PlansModel model = new PlansModel();
            PlansPresenter presenter = new PlansPresenter(form, model, _view.SelectedRoute);

            form.ShowDialog();
        }

        void _view_DeleteClick(object sender, EventArgs e)
        {
            _model.DeleteRoute(_view.SelectedRoute);
            _view.RouteList = _model.GetRoutes();
        }

        void _view_EditClick(object sender, EventArgs e)
        {
            FormRoute form = new FormRoute();
            RouteModel model = new RouteModel();
            RoutePresenter presenter =
                new RoutePresenter(form, model, _model.GetById(_view.SelectedRoute.ID));

            if (form.ShowDialog() == DialogResult.OK)
                _view.RouteList = _model.GetRoutes();
        }

        void _view_AddClick(object sender, EventArgs e)
        {
            FormRoute form = new FormRoute();
            RouteModel model = new RouteModel();
            RoutePresenter presenter = new RoutePresenter(form, model);
            
            if (form.ShowDialog() == DialogResult.OK)
                _view.RouteList = _model.GetRoutes();
        }


    }

}
