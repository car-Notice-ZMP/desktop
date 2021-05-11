using NoticeMyCar.Observed.Notice.Service;
using NoticeMyCar.Observed.Notice.View;
using System;

namespace NoticeMyCar.Observed.Notice.Presenter
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
            _view.removeFromWatched += new EventHandler(removeTheNoticeFromTheWatchlist);
        }

        void giveTheNumberOfNotices(object sender, EventArgs e)
        {
            _numberOfNotices.NumNumberOfNotices(_service.NumberOfNotices());
        }

        void giveMeTheData(object sender, EventArgs e)
        {
            _data.Data(
                _service.Notice(
                    _view.id)
                );
        }

        void removeTheNoticeFromTheWatchlist(object sender, EventArgs e)
        {
            _service.removeFromWatched(_view.id);
        }
    }
}
