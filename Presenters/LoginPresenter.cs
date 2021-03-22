using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Views;

namespace Presenters
{
    public class LoginPresenter
    {
        private IFormLogin formLogin;

        public LoginPresenter(IFormLogin view)
        {
            formLogin = view;
            formLogin.LoginEvent += new EventHandler(formLogin_LoginEvent);
        }

        void formLogin_LoginEvent(object sender, EventArgs e)
        {
            string email = formLogin.Email;
            string password = formLogin.Password;

            LoginService loginService = new LoginService();
            loginService.Login(email, password);
        }
    }
}
