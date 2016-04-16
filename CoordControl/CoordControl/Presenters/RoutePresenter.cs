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
    class RoutePresenter
    {
        private readonly IFormRoute _view;
        private readonly RouteModel _model;

        private Route _route;

        public RoutePresenter(IFormRoute view, RouteModel model)
            : this(view)
        {
            
            _model = model;
            _route = model.NewRoute();
            RouteFill();
            _view.FormTitle = "Добавление магистали";
        }


        public RoutePresenter(IFormRoute view, RouteModel model, Route route)
            : this(view)
        {
            _model = model;
            _route = route;
            RouteFill();

            _view.FormTitle = "Изменение магистрали";
        }

        public RoutePresenter(IFormRoute view)
        {
            _view = view;
            
            _view.SaveButtonClick += _view_SaveButtonClick;
        }

        private void RouteFill() {
            _view.StreetName = _route.StreetName;
            _view.CrossCount = _route.CrossCount;
            _view.CrossList = _route.Crosses;
            _view.Cross = _view.SelectedCross;

            _view.CrossCountChanged += _view_CrossCountChanged;
            _view.CrossListSelected += _view_CrossListSelected;
        }

        void _view_SaveButtonClick(object sender, EventArgs e)
        {
            //получение значение из формы и сохранение его в куче
            Cross cr = _view.Cross;

            _route.StreetName = _view.StreetName;
            _model.IntensityCalc(_route);

            _model.Save(_route);
        }

        void _view_CrossListSelected(object sender, EventArgs e)
        {
            //получение значение из формы и сохранение его в куче
            Cross cr = _view.Cross;

            //отображение нового перекрестка
            _model.IntensityCalc(_route);
            _view.Cross = _view.SelectedCross;
        }

        void _view_CrossCountChanged(object sender, EventArgs e)
        {
            _route.CrossCount = _view.CrossCount;

            _model.FixCrossCount(_route);
            _view.ComboBoxRefreshItems();
        }



    }
}
