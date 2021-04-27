using NoticeMyCar.SellACars.AddNotice.Service;
using NoticeMyCar.SellACars.Notices.Model;
using NoticeMyCar.SellACars.Notices.Presenter;
using NoticeMyCar.SellACars.Notices.Service;
using NoticeMyCar.SellACars.Notices.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoticeMyCar.SellACars.Notices
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
