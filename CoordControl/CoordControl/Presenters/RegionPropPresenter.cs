using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CoordControl.Forms;
using CoordControl.Core;
using CoordControl.Models;

namespace CoordControl.Presenters
{
    public class RegionPropPresenter
    {
        public IFormRegionProp View;
        private RegionPropModel _model;
        private ModelingPresenter modelPresenter;
        public Region Region;

        public RegionPropPresenter(IFormRegionProp view, RegionPropModel model, ModelingPresenter mp, Region region)
        {
            View = view;
            _model = model;
            Region = region;
            modelPresenter = mp;
            SetConstParams();
            SetVariableParams();

            mp.FormClosed += mp_FormClosed;
            mp.ModelSteped += mp_ModelSteped;
            View.FormClosing += View_FormClosing;
        }

        void View_FormClosing(object sender, EventArgs e)
        {
            OnFormClose();
        }

        void mp_ModelSteped(object sender, EventArgs e)
        {
            SetVariableParams();
        }

        void mp_FormClosed(object sender, EventArgs e)
        {
            if (View!= null)
                View.FormClose();
            OnFormClose();
        }

        private void OnFormClose()
        {
            View = null;
            modelPresenter.ModelSteped -= mp_ModelSteped;
        }

        private void SetConstParams() {
            View.CrossLeft = _model.GetLeftCrossName(Region);
            View.CrossRight = _model.GetRightCrossName(Region);

            View.MovingDirect = _model.GetWayDirection(Region);
            View.RegionNum = _model.GetRegionNum(Region);
            View.WayType = _model.GetWayType(Region);
            View.RegionLength = _model.GetRegionLength(Region);
            View.RegionWidth = _model.GetRegionWidth(Region);
            View.LinesCount = _model.GetLinesCount(Region);
            View.WayLength = _model.GetWayLength(Region);
        }

        public void SetVariableParams()
        {
            View.FlowPart = Region.FlowPart;
            View.Speed = Region.Velocity * ModelConst.SPEED_COEF;
            View.Intensity = Region.GetIntensity();
            View.Density = Region.GetDensity();
        }


        public void SetWindowActive()
        {
            View.FormActivate();
        }

        //TO-DO: доделать свойства участков
    }
}
