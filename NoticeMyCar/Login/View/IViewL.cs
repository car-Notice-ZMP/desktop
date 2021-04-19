using System;

namespace NoticeMyCar.Login.View
{
    public interface IReportL
    {
        void Report(bool report);
    }

    public interface IViewL : IReportL
    {
        string email { get; }
        string password { get; }

        event EventHandler login;
    }
}