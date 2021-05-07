using NoticeMyCar.BuyACar.Notice.Model;
using System;
using System.Windows.Forms;

namespace NoticeMyCar.BuyACar.Notice.View
{
    public interface IData
    {
        void Data(IModelN data);
    }

    public interface INumberOfNotices
    {
        void NumNumberOfNotices(int numberOfNotices);
    }

    public interface IViewN : IData, INumberOfNotices
    {
        int id { get; }

        event EventHandler giveTheNumberOfNotices;
        event EventHandler noticeAndId;
    }
}