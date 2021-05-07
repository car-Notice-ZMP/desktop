using NoticeMyCar.Observed.Notice.Model;

namespace NoticeMyCar.Observed.Notice.Service
{
    interface IServiceN
    {
        IModelN Notice(int id);
        int NumberOfNotices();
    }
}