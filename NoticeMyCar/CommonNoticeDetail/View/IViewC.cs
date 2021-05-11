using NoticeMyCar.CommonNoticeDetail.Model;
using System;

namespace NoticeMyCar.CommonNoticeDetail.View
{
    public interface INotic
    {
        void Notice(INotice data);
    }

    public interface INumberOfComments
    {
        void NumberOfComments(int q);
    }

    public interface ICommen
    {
        void Comment(IComment comment);
    }

    public interface IHasAnNoticeBeenAdded
    {
        void HasAnNoticeBeenAdded(bool wasItSuccessful);
    }

    public interface IViewC : INotic, INumberOfComments, ICommen, IHasAnNoticeBeenAdded
    {
        string content { get; }
        int id { get; }
        int number { get; }

        event EventHandler addComment;
        event EventHandler giveComment;
        event EventHandler giveMeTheNotice;
        event EventHandler giveTheNumberOfComments;
    }
}