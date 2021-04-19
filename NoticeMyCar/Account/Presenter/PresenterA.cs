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
        private readonly IDataA _data;

        public PresenterA(IViewA view, IServiceA service, IDataA data)
        {
            _view = view;
            _view.profile += new EventHandler(iFormLogin_LoginEvent);
            _service = service;
            _data = data;
        }

        void iFormLogin_LoginEvent(object sender, EventArgs e)
        {
            _data.Data(_service.Profile());
        }
    }
}
