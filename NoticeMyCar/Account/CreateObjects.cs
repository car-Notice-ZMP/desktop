using NoticeMyCar.Account.Model;
using NoticeMyCar.Account.Presenter;
using NoticeMyCar.Account.Service;
using NoticeMyCar.Account.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoticeMyCar.Account
{
    public class CreateObjects : ICreateObjects
    {
        public void FacityFactory(ViewA viewA)
        {
            var modelA = new ModelA();
            var serviceA = new ServiceA(modelA);
            var presenterL = new PresenterA(viewA, serviceA, viewA);
        }
    }
}
