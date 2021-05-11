using NoticeMyCar.CommonNoticeDetail.Model;
using System;

namespace NoticeMyCar.CommonNoticeDetail.View
{
    public interface IData
    {
        void Data(IModelC data);
    }

    public interface IHasAnNoticeBeenAdded
    {
        void HasAnNoticeBeenAdded(bool wasItSuccessful);
    }

    public interface IViewC : IData, IHasAnNoticeBeenAdded
    {
        string content { get; }
        int id { get; }

        event EventHandler addComment;
        event EventHandler giveMeTheData;
    }
}