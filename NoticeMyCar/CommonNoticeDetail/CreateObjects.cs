using NoticeMyCar.CommonNoticeDetail.Model;
using NoticeMyCar.CommonNoticeDetail.Presenter;
using NoticeMyCar.CommonNoticeDetail.Service;
using NoticeMyCar.CommonNoticeDetail.View;

namespace NoticeMyCar.CommonNoticeDetail
{
    class CreateObjects : ICreateObjects
    {
        public void FacityFactory(ViewC viewC)
        {
            var notice = new Notice();
            var comment = new Comment();
            var serviceC = new ServiceC(notice, comment);
            var presenterC = new PresenterC(viewC, serviceC, viewC, viewC, viewC, viewC);
        }
    }
}
