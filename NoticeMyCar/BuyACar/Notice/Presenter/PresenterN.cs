using NoticeMyCar.BuyACar.Notice.Service;
using NoticeMyCar.BuyACar.Notice.View;
using System;

namespace NoticeMyCar.BuyACar.Notice.Presenter
{
    class PresenterN
    {
        private readonly IViewN _view;
        private readonly IServiceN _service;
        private readonly IData _data;
        private readonly INumberOfNotices _numberOfNotices;
        private readonly IWhetherAddedDoWatchlist _whetherAddedDoWatchlist;

        public PresenterN(IViewN view, IServiceN service, IData data, INumberOfNotices numberOfNotices, IWhetherAddedDoWatchlist whetherAddedDoWatchlist)
        {
            _view = view;
            _service = service;
            _data = data;
            _numberOfNotices = numberOfNotices;
            _whetherAddedDoWatchlist = whetherAddedDoWatchlist;

            _view.noticeAndId += new EventHandler(giveMeTheData);
            _view.giveTheNumberOfNotices += new EventHandler(giveTheNumberOfNotices);
            _view.addinToWatched += new EventHandler(addToFollowed);
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

        void addToFollowed(object sender, EventArgs e)
        {
            if (_service.AddToFollowed(_view.id))
                _whetherAddedDoWatchlist.Watched(true);
            else
                _whetherAddedDoWatchlist.Watched(false);
        }
    }
}
