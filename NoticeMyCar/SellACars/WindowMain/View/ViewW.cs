using NoticeMyCar.SellACars.AddNotice.View;
using NoticeMyCar.SellACars.Notices;
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
            settingUpNotices();
        }

        private int spaceForAnnouncements()
        {
            int w = 50;
            int h = 50;
            int i = 0;

            do
            {
                do
                {
                    i++;
                    w += 250;
                } while (w < Screen.PrimaryScreen.Bounds.Width - 620);

                w = 50;
                h += 420;
            } while (h < Screen.PrimaryScreen.Bounds.Height - 401);

            return i;
        }

        private void settingUpNotices()
        {
            int w = 50;
            int h = 50;
            int availableNoticeSpace = spaceForAnnouncements();
            int displayedNumberOfNotices;
            int availableNotices;

            ViewN viewN = new ViewN();
            availableNotices = viewN.theNumberOfMyNotices();

            if (availableNoticeSpace > availableNotices)
                displayedNumberOfNotices = availableNotices;
            else
                displayedNumberOfNotices = availableNoticeSpace;

            if (displayedNumberOfNotices != 0)
                for (int i=0; i<displayedNumberOfNotices; i++)
                {
                    ViewN view = new ViewN();
                    var n = view.Notices(i);

                    if (w < Screen.PrimaryScreen.Bounds.Width - 620)
                        n.Location = new Point(w, h);

                    else
                    {
                        w = 50;
                        h += 420;
                        n.Location = new Point(w, h);
                    }

                    w += 250;

                    n.TopLevel = false;
                    Controls.Add(n);
                    n.Show();
                }
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

        private void iconButtonAddNotice_Click(object sender, EventArgs e)
        {
            iconButtonAddNotice.Hide();
            changePanel(new ViewA());
        }
    }
}
