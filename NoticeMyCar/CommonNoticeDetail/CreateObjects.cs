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
            var modelC = new ModelC();
            var serviceC = new ServiceC(modelC);
            var presenterC = new PresenterC(viewC, serviceC, viewC, viewC);
        }
    }
}
