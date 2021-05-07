using NoticeMyCar.Login.Model;
using NoticeMyCar.Login.Presenter;
using NoticeMyCar.Login.View;
using NoticeMyCar.Services.Login;

namespace NoticeMyCar.Login
{
    public class CreateObjects : ICreateObjects
    {
        public void FacityFactory(ViewL viewL)
        {
            var modelL = new ModelL();
            var serviceL = new ServiceL(modelL);
            var presenterL = new PresenterL(viewL, serviceL, viewL);
        }
    }
}
