using NoticeMyCar.SendAMessage.Model;
using NoticeMyCar.SendAMessage.Presenter;
using NoticeMyCar.SendAMessage.Service;
using NoticeMyCar.SendAMessage.View;

namespace NoticeMyCar.SendAMessage
{
    public class CreateObjects : ICreateObjects
    {
        public void FacityFactory(ViewSAM viewSAM)
        {
            var modelS = new ModelS();
            var serviceS = new ServiceS(modelS);
            var presenterS = new PresenterS(viewSAM, serviceS, viewSAM);
        }
    }
}
