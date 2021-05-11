using NoticeMyCar.SendAMessage.Service;
using NoticeMyCar.SendAMessage.View;
using System;

namespace NoticeMyCar.SendAMessage.Presenter
{
    class PresenterS
    {
        private readonly IViewSAM _view;
        private readonly IServiceS _service;
        private readonly IReport _report;

        public PresenterS(IViewSAM view, IServiceS service, IReport report)
        {
            _view = view;
            _service = service;
            _report = report;

            _view.send += new EventHandler(whetherSent);
        }

        void whetherSent(object sender, EventArgs e)
        {
            if (_service.WasItSent(_view))
                _report.wasItSent(true);
            else
                _report.wasItSent(false);
        }
    }
}
