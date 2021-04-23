using System;
using System.Drawing;

namespace NoticeMyCar.SellACars.AddNotice.View
{
    public interface IReport
    {
        void Report(bool report);
    }

    public interface IViewA : IReport
    {
        string content { get; }
        string image { get; }
        string title { get; }

        event EventHandler notice;
    }
}