using NoticeMyCar.SellACars.Notices.Model;
using System;
using System.Collections.Generic;
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

    public interface IStatus
    {
        void Status(bool status);
    }

    public interface IUpdate
    {
        void Update(bool change);
    }

    public interface IViewN : IData, INumberOfNotices, IStatus, IUpdate
    {
        int id { get; }
        List<string> update { get; }

        event EventHandler giveTheNumberOfNotices;
        event EventHandler noticeAndId;
        event EventHandler delete;
        event EventHandler status;
        event EventHandler edit;
    }
}