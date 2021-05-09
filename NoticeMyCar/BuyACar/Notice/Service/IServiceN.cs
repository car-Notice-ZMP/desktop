using NoticeMyCar.BuyACar.Notice.Model;

namespace NoticeMyCar.BuyACar.Notice.Service
{
    interface IServiceN
    {
        bool AddToFollowed(int id);
        IModelN Notice(int id);
        IModelN Notice(int id, string s);
        int NumberOfNotices(string s);
        int NumberOfNotices();
    }
}