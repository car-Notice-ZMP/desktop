using System;

namespace NoticeMyCar.Login.View
{
    public interface IReport
    {
        void Report(bool report);
    }

    public interface IViewL : IReport
    {
        string email { get; }
        string password { get; }

        event EventHandler login;
    }
}