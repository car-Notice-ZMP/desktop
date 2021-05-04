using NoticeMyCar.SellACars.Notices.Model;

namespace NoticeMyCar.SellACars.Notices.Service
{
    interface IServiceN
    {
        void DeleteNotice(int id);
        IModelN Notice(int id);
        int NumberOfNotices();
        bool StatusNotice(int id);
    }
}