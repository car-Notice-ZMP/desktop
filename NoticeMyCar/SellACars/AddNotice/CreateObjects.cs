using NoticeMyCar.SellACars.AddNotice.Model;
using NoticeMyCar.SellACars.AddNotice.Presenter;
using NoticeMyCar.SellACars.AddNotice.Service;
using NoticeMyCar.SellACars.AddNotice.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoticeMyCar.SellACars.AddNotice
{
    public class CreateObjects : ICreateObjects
    {
        public void FacityFactory(ViewA viewA)
        {
            var modelA = new ModelA();
            var serviceA = new ServiceA(modelA);
            var presenterA = new PresenterA(viewA, serviceA, viewA);
        }
    }
}
