using NoticeMyCar.CommonNoticeDetail.Service;
using NoticeMyCar.CommonNoticeDetail.View;
using System;

namespace NoticeMyCar.CommonNoticeDetail.Presenter
{
    class PresenterC
    {
        private readonly IViewC _view;
        private readonly IServiceC _service;
        private readonly INotic _notice;
        private readonly INumberOfComments _numberOfComments;
        private readonly ICommen _comment;
        private readonly IHasAnNoticeBeenAdded _hasAnNoticeBeenAdded;

        public PresenterC(IViewC view, IServiceC service, INotic notice, INumberOfComments numberOfComments, ICommen comment, IHasAnNoticeBeenAdded hasAnNoticeBeenAdded)
        {
            _view = view;
            _service = service;
            _notice = notice;
            _numberOfComments = numberOfComments;
            _comment = comment;
            _hasAnNoticeBeenAdded = hasAnNoticeBeenAdded;

            _view.giveMeTheNotice += new EventHandler(giveMeTheNotice);
            _view.giveTheNumberOfComments += new EventHandler(giveTheNumberOfComments);
            _view.giveComment += new EventHandler(giveComment);
            _view.addComment += new EventHandler(addComment);
        }

        void giveMeTheNotice(object sender, EventArgs e)
        {
            _notice.Notice(
                _service.Notice(
                    _view.id)
                );
        }

        void giveTheNumberOfComments(object sender, EventArgs e)
        {
            _numberOfComments.NumberOfComments(
                _service.NumberOfComments(
                    _view.id)
                );
        }

        void giveComment(object sender, EventArgs e)
        {
            _comment.Comment(
                _service.Comment(
                    _view.id, _view.number)
                );
        }

        void addComment(object sender, EventArgs e)
        {
            _hasAnNoticeBeenAdded.HasAnNoticeBeenAdded(
                _service.AddComment(
                    _view, _view.id)
                    );
        }
    }
}
