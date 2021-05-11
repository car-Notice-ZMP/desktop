using NoticeMyCar.CommonNoticeDetail.Model;
using NoticeMyCar.CommonNoticeDetail.View;

namespace NoticeMyCar.CommonNoticeDetail.Service
{
    interface IServiceC
    {
        bool addComment(IViewC view, int id);
        IModelC Notice(int id);
    }
}