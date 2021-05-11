using NoticeMyCar.SendAMessage.View;

namespace NoticeMyCar.SendAMessage.Service
{
    interface IServiceS
    {
        bool WasItSent(IViewSAM view);
    }
}