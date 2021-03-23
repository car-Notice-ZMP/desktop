using NoticeMyCar.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoticeMyCar.Views
{
    public partial class FormLogin : Form, IFormLogin
    {
        public event EventHandler LoginEvent;
        private LoginPresenter loginPresenter;

        public FormLogin()
        {
            InitializeComponent();
            loginPresenter = new LoginPresenter(this);
        }

        public string email
        {
            get { return textBoxEmail.Text; }
        }

        public string password
        {
            get { return textBoxPassword.Text; }
        }

        public void Report(bool report)
        {
            if (report)
            {
                FormValue formValue = new FormValue();
                formValue.Show();
            }
            else
            {
                labelIncorrect.Text = "Nieprawidłowy e-mail albo hasło!";
                labelIncorrect.Visible = true;
            }
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            if (LoginEvent != null)
                LoginEvent(this, EventArgs.Empty);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
                textBoxPassword.PasswordChar = '\0';
            else
                textBoxPassword.PasswordChar = '*';
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            FormRegistration formRegistration = new FormRegistration();
            formRegistration.Show();
            Hide();
        }
    }
}
