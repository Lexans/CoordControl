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
        private IFormRegionProp _view;
        private RegionPropModel _model;
        private Region _region;

        public RegionPropPresenter(IFormRegionProp view, RegionPropModel model, Region region)
        {
            _view = view;
            _model = model;
            _region = region;
        }

        //TO-DO: доделать свойства участков
    }
}
