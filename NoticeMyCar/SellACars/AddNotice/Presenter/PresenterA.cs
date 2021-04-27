using NoticeMyCar.SellACars.AddNotice.Service;
using NoticeMyCar.SellACars.AddNotice.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoticeMyCar.SellACars.AddNotice.Presenter
{
    class PresenterA
    {
        private readonly IViewA _view;
        private readonly IServiceA _service;
        private readonly IReport _report;

        public PresenterA(IViewA view, IServiceA service, IReport report)
        {
            _view = view;
            _service = service;
            _report = report;

            _view.notice += new EventHandler(provideTheData);
        }

        void provideTheData(object sender, EventArgs e)
        {
            if (_service.Notice(_view))
                _report.Report(true);
            else
                _report.Report(false);
        }
    }
}
