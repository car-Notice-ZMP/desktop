using NoticeMyCar.Account.View;
using NoticeMyCar.Login.View;
using NoticeMyCar.SellACar.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoticeMyCar.Menu.View
{
    public partial class ViewM : Form
    {
        public ViewM()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMinimized_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void buttonWindow_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
            else
                WindowState = FormWindowState.Maximized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTopMenu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void iconButtonLogOut_Click(object sender, EventArgs e)
        {
            ViewL view = new ViewL();
            view.Show();
            Hide();
        }

        private Form activeForm = null;

        private void changePanel(Form panel)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = panel;
            panel.TopLevel = false;
            panel.Dock = DockStyle.Fill;
            panelMain.Controls.Add(panel);
            panelMain.Tag = panel;
            panel.BringToFront();
            panel.Show();
        }

        private void iconButtonAccount_Click(object sender, EventArgs e)
        {
            changePanel(new ViewA());
        }

        private void iconButtonObserved_Click(object sender, EventArgs e)
        {

        }

        private void iconButtonSellACar_Click(object sender, EventArgs e)
        {
            changePanel(new ViewS());
        }
    }
}
