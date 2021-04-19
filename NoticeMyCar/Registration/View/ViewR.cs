using NoticeMyCar.Login.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoticeMyCar.Registration.View
{
    public partial class ViewR : Form, IViewR
    {
        public event EventHandler register;

        public ViewR()
        {
            InitializeComponent();
            CreateObjects createObjects = new CreateObjects();
            createObjects.FacityFactory(this);
        }

        public string name
        {
            get { return textBoxName.Text; }
        }

        public string email
        {
            get { return textBoxEmail.Text; }
        }

        public string password
        {
            get { return textBoxPassword.Text; }
        }

        public string repeatPassword
        {
            get { return textBoxRepeatPassword.Text; }
        }

        public void Report(bool report)
        {

        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (register != null)
                register(this, EventArgs.Empty);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            ViewL view = new ViewL();
            view.Show();
            Hide();
        }

        private void buttonMinimized_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
