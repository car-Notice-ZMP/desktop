using NoticeMyCar.SellACars.Notices.Service;
using NoticeMyCar.SellACars.Notices.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoticeMyCar.SellACars.Notices.Presenter
{
    class PresenterN
    {
        private readonly IViewN _view;
        private readonly IServiceN _service;
        private readonly IData _data;
        private readonly INumberOfNotices _numberOfNotices;
        private readonly IStatus _status;

        public PresenterN(IViewN view, IServiceN service, IData data, INumberOfNotices numberOfNotices, IStatus status)
        {
            _view = view;
            _service = service;
            _data = data;
            _numberOfNotices = numberOfNotices;
            _status = status;

            _view.noticeAndId += new EventHandler(giveMeTheData);
            _view.giveTheNumberOfNotices += new EventHandler(giveTheNumberOfNotices);
            _view.deleteNotice += new EventHandler(deleteTheNotice);
            _view.statusNotice += new EventHandler(freshStatus);
        }

        void giveTheNumberOfNotices(object sender, EventArgs e)
        {
            _numberOfNotices.NumNumberOfNotices(_service.NumberOfNotices());
        }

        void giveMeTheData(object sender, EventArgs e)
        {
            _data.Data(_service.Notice(_view.id));
        }

        void deleteTheNotice(object sender, EventArgs e)
        {
            _service.DeleteNotice(_view.id);
        }

        void freshStatus(object sender, EventArgs e)
        {
            if (_service.StatusNotice(_view.id))
                _status.Status(true);
            else
                _status.Status(false);
        }
    }
}
