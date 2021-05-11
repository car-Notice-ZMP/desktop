using System;

namespace NoticeMyCar.SellACars.AddNotice.View
{
    public interface IReport
    {
        void Report(bool report);
    }

    public interface IViewA : IReport
    {
        string body { get; }
        string color { get; }
        string content { get; }
        string image { get; }
        string mark { get; }
        string mileage { get; }
        string model { get; }
        string price { get; }
        string title { get; }
        string year { get; }

        event EventHandler notice;
    }
}