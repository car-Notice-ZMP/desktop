using NoticeMyCar.SellACars.Notice.Model;
using NoticeMyCar.SellACars.Notice.Presenter;
using NoticeMyCar.SellACars.Notice.Service;
using NoticeMyCar.SellACars.Notice.View;

namespace NoticeMyCar.SellACars.Notice
{
    class CreateObjects : ICreateObjects
    {
        public void FacityFactory(ViewN viewN)
        {
            var modelN = new ModelN();
            var serviceN = new ServiceN(modelN);
            var presenterN = new PresenterN(viewN, serviceN, viewN, viewN, viewN, viewN);
        }
    }
}
