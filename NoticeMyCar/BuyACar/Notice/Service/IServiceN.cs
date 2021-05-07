using NoticeMyCar.BuyACar.Notice.Model;

namespace NoticeMyCar.BuyACar.Notice.Service
{
    interface IServiceN
    {
        IModelN Notice(int id);
        int NumberOfNotices();
    }
}