using NoticeMyCar.Login.Model;
using NoticeMyCar.Login.Presenter;
using NoticeMyCar.Login.View;
using NoticeMyCar.Services.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoticeMyCar.Login
{
    public class CreateObjects : ICreateObjects
    {
        public void FacityFactory(ViewL viewL)
        {
            var modelL = new ModelL();
            var serviceL = new ServiceL(modelL);
            var presenterL = new PresenterL(viewL, serviceL, viewL);
        }
    }
}
