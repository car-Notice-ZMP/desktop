using NoticeMyCar.BuyACar.Notice.Model;

namespace NoticeMyCar.BuyACar.Notice.Service
{
    interface IServiceN
    {
        bool AddToFollowed(int id);
        IModelN Notice(int id);
        int NumberOfNotices();
    }
}