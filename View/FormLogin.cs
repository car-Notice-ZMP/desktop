using System;
using System.Windows.Forms;

namespace Views
{
    public partial class FormLogin : Form, IFormLogin
    {
        public event EventHandler LoginEvent;

        public FormLogin()
        {
            InitializeComponent();
        }

        public string Email
        {
            get { return textBoxEmail.Text; }
        }

        public string Password
        {
            get { return textBoxPassword.Text; }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            if (LoginEvent != null)
                LoginEvent(this, EventArgs.Empty);
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            FormRegister formRegister = new FormRegister();
            formRegister.Show();
            Hide();
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
                textBoxPassword.PasswordChar = '\0';
            else
                textBoxPassword.PasswordChar = '*';
        }
    }
}
