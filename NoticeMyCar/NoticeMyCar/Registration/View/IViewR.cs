using System;

namespace NoticeMyCar.Registration.View
{
    public interface IReport
    {
        void Report(bool report);
    }

    public interface IViewR : IReport
    {
        string email { get; }
        string name { get; }
        string password { get; }
        string repeatPassword { get; }

        event EventHandler register;
    }
}