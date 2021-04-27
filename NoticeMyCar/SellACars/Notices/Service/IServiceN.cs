using NoticeMyCar.SellACars.Notices.Model;

namespace NoticeMyCar.SellACars.Notices.Service
{
    interface IServiceN
    {
        IModelN Notice(int id);
        int NumberOfNotices();
    }
}