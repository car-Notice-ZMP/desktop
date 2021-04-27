using NoticeMyCar.Account.Service;
using NoticeMyCar.Account.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoticeMyCar.Account.Presenter
{
    class PresenterA
    {
        private readonly IViewA _view;
        private readonly IServiceA _service;
        private readonly IData _data;

        public PresenterA(IViewA view, IServiceA service, IData data)
        {
            _view = view;
            _service = service;
            _data = data;

            _view.profile += new EventHandler(giveMeTheData);
        }

        void giveMeTheData(object sender, EventArgs e)
        {
            _data.Data(_service.Profile());
        }
    }
}
