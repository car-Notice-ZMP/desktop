using NoticeMyCar.Login.Model;
using NoticeMyCar.Menu;
using NoticeMyCar.Menu.View;
using NoticeMyCar.Registration.View;
using NoticeMyCar.Services.Login;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace NoticeMyCar.Login.View
{
    public partial class ViewL : Form, IViewL
    {
        public event EventHandler login;

        public ViewL()
        {
            InitializeComponent();
            CreateObjects createObjects = new CreateObjects();
            createObjects.FacityFactory(this);
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
                ViewM view = new ViewM();
                view.Show();
                Hide();
            }
            else
            {
                labelIncorrect.Text = "Nieprawidłowy e-mail albo hasło!";
                labelIncorrect.Visible = true;
            }
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            if (login != null)
                login(this, EventArgs.Empty);
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
            ViewR view = new ViewR();
            view.Show();
            Hide();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelMenu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void buttonMinimized_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
