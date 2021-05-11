using System;

namespace NoticeMyCar.SendAMessage.View
{
    public interface IReport
    {
        void wasItSent(bool wasItSent);
    }

    public interface IViewSAM : IReport
    {
        string content { get; }
        string receiver { get; }
        string title { get; }

        event EventHandler send;
    }
}