﻿using NoticeMyCar.BuyACar.Notice.Model;
using NoticeMyCar.BuyACar.Notice.Presenter;
using NoticeMyCar.BuyACar.Notice.Service;
using NoticeMyCar.BuyACar.Notice.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoticeMyCar.BuyACar.Notice
{
    class CreateObjects : ICreateObjects
    {
        public void FacityFactory(ViewN viewN)
        {
            var modelN = new ModelN();
            var serviceN = new ServiceN(modelN);
            var presenterN = new PresenterN(viewN, serviceN, viewN, viewN, viewN);
        }
    }
}
