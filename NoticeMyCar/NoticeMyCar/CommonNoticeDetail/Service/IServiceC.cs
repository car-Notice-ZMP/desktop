using NoticeMyCar.CommonNoticeDetail.Model;
using NoticeMyCar.CommonNoticeDetail.View;

namespace NoticeMyCar.CommonNoticeDetail.Service
{
    interface IServiceC
    {
        bool AddComment(IViewC view, int id);
        IComment Comment(int id, int numberOfComment);
        INotice Notice(int id);
        int NumberOfComments(int id);
    }
}