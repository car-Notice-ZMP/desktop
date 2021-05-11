using NoticeMyCar.CommonNoticeDetail.Service;
using NoticeMyCar.CommonNoticeDetail.View;
using System;

namespace NoticeMyCar.CommonNoticeDetail.Presenter
{
    class PresenterC
    {
        private readonly IViewC _view;
        private readonly IServiceC _service;
        private readonly IData _data;
        private readonly IHasAnNoticeBeenAdded _hasAnNoticeBeenAdded;

        public PresenterC(IViewC view, IServiceC service, IData data, IHasAnNoticeBeenAdded hasAnNoticeBeenAdded)
        {
            _view = view;
            _service = service;
            _data = data;
            _hasAnNoticeBeenAdded = hasAnNoticeBeenAdded;

            _view.giveMeTheData += new EventHandler(giveMeTheData);
            _view.addComment += new EventHandler(addComment);
        }

        void giveMeTheData(object sender, EventArgs e)
        {
            _data.Data(
                _service.Notice(
                    _view.id)
                );
        }

        void addComment(object sender, EventArgs e)
        {
            _hasAnNoticeBeenAdded.HasAnNoticeBeenAdded(
                _service.addComment(
                    _view, _view.id)
                    );
        }
    }
}
