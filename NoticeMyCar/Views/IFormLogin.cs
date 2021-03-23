using System;

namespace NoticeMyCar.Views
{
    /*public interface IReport
    {
        void Report(bool report);
    }*/

    public interface IFormLogin
    {
        string email { get; }
        string password { get; }

        event EventHandler LoginEvent;

        void Report(bool report);
    }
}