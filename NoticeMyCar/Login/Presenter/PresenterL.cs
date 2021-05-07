using NoticeMyCar.Login.View;
using NoticeMyCar.Services.Login;
using System;

namespace NoticeMyCar.Login.Presenter
{
    class PresenterL
    {
        private readonly IViewL _view;
        private readonly IServiceL _service;
        private readonly IReport _report;

        public PresenterL(IViewL view, IServiceL service, IReport report)
        {
            _view = view;
            _service = service;
            _report = report;

            _view.login += new EventHandler(checkLogin);
        }

        void checkLogin(object sender, EventArgs e)
        {
            if (_service.Login(_view))
                _report.Report(true);
            else
                _report.Report(false);
        }
    }
}