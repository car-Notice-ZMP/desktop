using NoticeMyCar.Login.View;
using NoticeMyCar.Services.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoticeMyCar.Login.Presenter
{
    class PresenterL
    {
        private readonly IViewL _view;
        private readonly IServiceL _service;
        private readonly IReportL _report;

        public PresenterL(IViewL view, IServiceL service, IReportL report)
        {
            _view = view;
            _view.login += new EventHandler(iFormLogin_LoginEvent);
            _service = service;
            _report = report;
        }

        void iFormLogin_LoginEvent(object sender, EventArgs e)
        {
            if (_service.Login(_view))
                _report.Report(true);
            else
                _report.Report(false);
        }
    }
}