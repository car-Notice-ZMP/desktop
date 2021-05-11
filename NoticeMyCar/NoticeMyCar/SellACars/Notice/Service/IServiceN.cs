using NoticeMyCar.SellACars.Notice.Model;
using System.Collections.Generic;

namespace NoticeMyCar.SellACars.Notice.Service
{
    interface IServiceN
    {
        void DeleteNotice(int id);
        IModelN Notice(int id);
        int NumberOfNotices();
        bool StatusNotice(int id);
        bool Update(int id, List<string> changes);
    }
}