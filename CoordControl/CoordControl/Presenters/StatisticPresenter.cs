using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoordControl.Forms;
using CoordControl.Models;

namespace CoordControl.Presenters
{
    class StatisticPresenter
    {
        private IFormStatistic _view;
        private StatisticModel _model;
        private ModelingPresenter _modelPresenter;

        public StatisticPresenter(IFormStatistic view, StatisticModel model, ModelingPresenter modelPresenter)
        {
            _view = view;
            _model = model;
            _modelPresenter = modelPresenter;

            _view.FormClosing += _view_FormClosing;

            _modelPresenter.ModelSteped += _modelPresenter_ModelSteped;
            _modelPresenter.StatMeasured += _modelPresenter_StatMeasured;
            _modelPresenter.FormClosed += _modelPresenter_FormClosed;

            _view.MeasurePeriod = _model.GetMeasurePeriod();
            _view.SetMeasureHistory(_model.DelaysDirect, _model.DelaysReverse, _model.DelaysSum);
            SetNumericChars();
        }

        void _modelPresenter_FormClosed(object sender, EventArgs e)
        {
            _view.FormClose();
        }

        void _view_FormClosing(object sender, EventArgs e)
        {
            _modelPresenter.ModelSteped -= _modelPresenter_ModelSteped;
            _modelPresenter.StatMeasured -= _modelPresenter_StatMeasured;
        }

        void _modelPresenter_ModelSteped(object sender, EventArgs e)
        {
            _view.DelayDirect = _model.CurrentDirect;
            _view.DelayReverse = _model.CurrentReverse;
            _view.DelaySum = _model.CurrentSum;
        }

        void _modelPresenter_StatMeasured(object sender, EventArgs e)
        {
            _view.AddMeasureHistory(_model.DelaysDirect.Last(),
                _model.DelaysReverse.Last(), _model.DelaysSum.Last());

            SetNumericChars();
        }

        void SetNumericChars()
        {
           _view.SetMx(_model.CalcMx(_model.DelaysDirect),
               _model.CalcMx(_model.DelaysReverse),
               _model.CalcMx(_model.DelaysSum)
               );

           _view.SetDx(_model.CalcDx(_model.DelaysDirect),
               _model.CalcDx(_model.DelaysReverse),
               _model.CalcDx(_model.DelaysSum)
               );
        }


    }
}
