using NoticeMyCar.BuyACar.Notice.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoticeMyCar.BuyACa.WindowMain.View
{
    public partial class ViewB : Form
    {
        List<Form> notices = new List<Form>();
        int page = 0;
        int newPage = 0;
        string search;
        ViewN viewN = new ViewN();

        public ViewB()
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

            availableNotices = viewN.theNumberOfNotices(search);

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
                    var n = view.Notices(i, search);

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
                    n.Name = "Notice";
                    notices.Add(n);
                    Controls.Add(notices[i]);
                    notices[i].Show();
                }

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

        private void iconButtonAngleRight_Click(object sender, EventArgs e)
        {
            if (viewN.theNumberOfNotices(search) != notices.Count && (page + 1) * spaceForAnnouncements() != notices.Count)
                settingUpNotices();
            else
                nextPage();
        }

        private void iconButtonAngleLeft_Click(object sender, EventArgs e)
        {
            if (page != 1)
                comeBack();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            notices.Clear();

            page = 0;
            labelPage.Text = page.ToString();
            newPage = 0;

            search = textBoxSearched.Text;

            Control[] form = Controls.Find("Notice", false);

            foreach (var f in form)
                Controls.Remove(f);

            settingUpNotices();
        }
    }
}
