using NoticeMyCar.Services.Login;
using NoticeMyCar.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoticeMyCar.Presenters
{
    public class LoginPresenter
    {
        private IFormLogin iFormLogin;

        public LoginPresenter(IFormLogin view)
        {
            iFormLogin = view;
            iFormLogin.LoginEvent += new EventHandler(iFormLogin_LoginEvent);
        }

        void iFormLogin_LoginEvent(object sender, EventArgs e)
        {
            string email = iFormLogin.email;
            string password = iFormLogin.password;

            if (email.Equals("Las@gmail.com") && password.Equals("password"))
                iFormLogin.Report(true);
            else
                iFormLogin.Report(false);
        }
    }
}
