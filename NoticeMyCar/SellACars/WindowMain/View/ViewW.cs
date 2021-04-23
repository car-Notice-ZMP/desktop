using NoticeMyCar.SellACars.AddNotice.View;
using NoticeMyCar.SellACars.Notices.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoticeMyCar.SellACars.WindowMain.View
{
    public partial class ViewW : Form
    {
        public ViewW()
        {
            InitializeComponent();
            Notices();
        }

        private void Notices()
        {
            int w = 50;
            int h = 50;

            do
            {
                do
                {
                    ViewN notice = new ViewN();

                    notice.TopLevel = false;
                    notice.Location = new Point(w, h);

                    Controls.Add(notice);
                    notice.Show();

                    w += 250;
                } while (w < Screen.PrimaryScreen.Bounds.Width - 797);
                w = 50;
                h += 420;
            } while (h < Screen.PrimaryScreen.Bounds.Height - 430);
        }

        private Form activeForm = null;

        private void changePanel(Form panel)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = panel;
            panel.TopLevel = false;
            panel.Dock = DockStyle.Fill;
            Controls.Add(panel);
            Tag = panel;
            panel.BringToFront();
            panel.Show();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            iconButton1.Hide();
            changePanel(new ViewA());
        }
    }
}
