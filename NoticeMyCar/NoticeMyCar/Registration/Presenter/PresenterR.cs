using NoticeMyCar.Registration.Service;
using NoticeMyCar.Registration.View;
using System;

namespace NoticeMyCar.Registration.Presenter
{
    class PresenterR
    {
        private readonly IViewR _view;
        private readonly IServiceR _service;
        private readonly IReport _report;

        public PresenterR(IViewR view, IServiceR service, IReport report)
        {
            _view = view;
            _service = service;
            _report = report;

            _view.register += new EventHandler(provideTheData);
        }

        void provideTheData(object sender, EventArgs e)
        {
            if (_service.Register(_view))
                _report.Report(true);
            else
                _report.Report(false);
        }
    }
}
