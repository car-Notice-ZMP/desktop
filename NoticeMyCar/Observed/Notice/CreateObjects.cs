using NoticeMyCar.Observed.Notice.Model;
using NoticeMyCar.Observed.Notice.Presenter;
using NoticeMyCar.Observed.Notice.Service;
using NoticeMyCar.Observed.Notice.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoticeMyCar.Observed.Notice
{
    class CreateObjects : ICreateObjects
    {
        public void FacityFactory(ViewN viewN)
        {
            var modelN = new ModelN();
            var serviceN = new ServiceN(modelN);
            var presenterN = new PresenterN(viewN, serviceN, viewN, viewN);
        }
    }
}
