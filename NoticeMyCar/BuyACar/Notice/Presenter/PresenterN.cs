using NoticeMyCar.BuyACar.Notice.Service;
using NoticeMyCar.BuyACar.Notice.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoticeMyCar.BuyACar.Notice.Presenter
{
    class PresenterN
    {
        private readonly IViewN _view;
        private readonly IServiceN _service;
        private readonly IData _data;
        private readonly INumberOfNotices _numberOfNotices;

        public PresenterN(IViewN view, IServiceN service, IData data, INumberOfNotices numberOfNotices)
        {
            _view = view;
            _service = service;
            _data = data;
            _numberOfNotices = numberOfNotices;

            _view.noticeAndId += new EventHandler(giveMeTheData);
            _view.giveTheNumberOfNotices += new EventHandler(giveTheNumberOfNotices);
        }

        void giveTheNumberOfNotices(object sender, EventArgs e)
        {
            _numberOfNotices.NumNumberOfNotices(_service.NumberOfNotices());
        }

        void giveMeTheData(object sender, EventArgs e)
        {
            _data.Data(_service.Notice(_view.id));
        }
    }
}
