using NoticeMyCar.SellACars.Notices.Model;
using System;
using System.Windows.Forms;

namespace NoticeMyCar.SellACars.Notices.View
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
        event EventHandler notice;
    }
}