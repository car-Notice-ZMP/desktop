using System;

namespace Views
{
    public interface IFormLogin
    {
        string Email { get; }
        string Password { get; }

        event EventHandler LoginEvent;
    }
}