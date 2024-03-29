﻿using NoticeMyCar.Registration.Model;
using NoticeMyCar.Registration.Presenter;
using NoticeMyCar.Registration.Service;
using NoticeMyCar.Registration.View;

namespace NoticeMyCar.Registration
{
    public class CreateObjects : ICreateObjects
    {
        public void FacityFactory(ViewR viewR)
        {
            var modelR = new ModelR();
            var serviceR = new ServiceR(modelR);
            var presenterR = new PresenterR(viewR, serviceR, viewR);
        }
    }
}
