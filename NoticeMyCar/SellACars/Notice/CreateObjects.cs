using NoticeMyCar.SellACars.AddNotice.Service;
using NoticeMyCar.SellACars.Notice.Model;
using NoticeMyCar.SellACars.Notice.Presenter;
using NoticeMyCar.SellACars.Notice.Service;
using NoticeMyCar.SellACars.Notice.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoticeMyCar.SellACars.Notice
{
    class CreateObjects : ICreateObjects
    {
        public void FacityFactory(ViewN viewN)
        {
            var modelN = new ModelN();
            var serviceN = new ServiceN(modelN);
            var presenterN = new PresenterN(viewN, serviceN, viewN, viewN, viewN, viewN);
        }
    }
}
