using NoticeMyCar.CommonNoticeDetail.View;
using NoticeMyCar.Observed.Notice.View;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace NoticeMyCar.Observed.MainWindow.View
{
    public partial class ViewO : Form
    {
        List<ViewN> notices = new List<ViewN>();
        int page = 0;
        int newPage = 0;
        ViewN viewN = new ViewN();

        public ViewO()
        {
            InitializeComponent();
            settingUpNotices();
        }

        private void settingUpNotices()
        {
            int x = 80;
            int y = 80;
            int quantityWillBeDisplayed = 0;
            int availableNoticeSpace = spaceForAnnouncements();
            int displayedNumberOfNotices;
            int availableNotices;

            availableNotices = viewN.theNumberOfMyNotices();

            if (availableNoticeSpace > availableNotices)
                displayedNumberOfNotices = availableNotices;
            else
                displayedNumberOfNotices = availableNoticeSpace;

            if (notices.Count != 0)
            {
                quantityWillBeDisplayed = availableNotices - notices.Count;

                if (quantityWillBeDisplayed > displayedNumberOfNotices)
                {
                    newPage++;
                    quantityWillBeDisplayed = displayedNumberOfNotices * newPage;
                }
                else
                    quantityWillBeDisplayed += displayedNumberOfNotices * newPage;

                for (int i = notices.Count - 1; i >= 0; i--)
                    Controls.Remove(notices[i]);
            }

            if (displayedNumberOfNotices != 0)
            {
                for (int i = notices.Count; i < displayedNumberOfNotices + quantityWillBeDisplayed; i++)
                {
                    ViewN view = new ViewN();
                    var n = view.Notices(i);

                    if (x < Screen.PrimaryScreen.Bounds.Width - 620)
                        n.Location = new Point(x, y);

                    else
                    {
                        x = 80;
                        y += 420;
                        n.Location = new Point(x, y);
                    }

                    x += 650;

                    n.TopLevel = false;
                    notices.Add((ViewN)n);
                    Controls.Add(notices[i]);
                    notices[i].Show();
                }

                listening(notices);
                page++;
                labelPage.Text = page.ToString();
            }
        }

        private int spaceForAnnouncements()
        {
            int x = 80;
            int y = 80;
            int i = 0;

            do
            {
                do
                {
                    i++;
                    x += 650;
                } while (x < Screen.PrimaryScreen.Bounds.Width - 620);

                x = 80;
                y += 420;
            } while (y < Screen.PrimaryScreen.Bounds.Height - 401);

            return i;
        }

        private void comeBack()
        {

            int spaceForAnnouncement = spaceForAnnouncements();
            int a = page * spaceForAnnouncement;
            int b = notices.Count % spaceForAnnouncement;

            if (a > notices.Count)
                a = notices.Count;

            if (a % spaceForAnnouncement == 0)
            {
                for (int i = a - 1; i >= a - spaceForAnnouncement; i--)
                    Controls.Remove(notices[i]);

                for (int i = a - spaceForAnnouncement - 1; i >= a - spaceForAnnouncement * 2; i--)
                    Controls.Add(notices[i]);
            }
            else
            {
                for (int i = notices.Count - 1; i >= notices.Count - b; i--)
                    Controls.Remove(notices[i]);

                for (int i = notices.Count - b - 1; i >= notices.Count - b - spaceForAnnouncement; i--)
                    Controls.Add(notices[i]);
            }

            page--;
            labelPage.Text = page.ToString();

        }

        private void nextPage()
        {
            int spaceForAnnouncement = spaceForAnnouncements();
            int a = page * spaceForAnnouncement;

            if (a + spaceForAnnouncement < notices.Count)
            {
                for (int i = a - 1; i >= a - spaceForAnnouncement; i--)
                    Controls.Remove(notices[i]);

                for (int i = a; i < a + spaceForAnnouncement; i++)
                    Controls.Add(notices[i]);

                page++;
                labelPage.Text = page.ToString();
            }
            else if (a < notices.Count)
            {
                for (int i = a - 1; i >= a - spaceForAnnouncement; i--)
                    Controls.Remove(notices[i]);

                int c = notices.Count - a;

                for (int i = a; i < a + c; i++)
                    Controls.Add(notices[i]);

                page++;
                labelPage.Text = page.ToString();
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

        private void iconButtonAngleRight_Click(object sender, EventArgs e)
        {
            if (viewN.theNumberOfMyNotices() != notices.Count && (page + 1) * spaceForAnnouncements() != notices.Count)
                settingUpNotices();
            else
                nextPage();
        }

        private void iconButtonAngleLeft_Click(object sender, EventArgs e)
        {
            if (page != 1)
                comeBack();
        }

        void listening(List<ViewN> viewNs)
        {
            foreach (var v in viewNs)
                v.showComments += (sender, EventArgs) => { givesTheId(sender, EventArgs, v.id); };
        }

        void givesTheId(object sender, EventArgs e, int id)
        {
            panelBottom.Hide();

            ViewC view = new ViewC(id);
            changePanel(view);
        }
    }
}
