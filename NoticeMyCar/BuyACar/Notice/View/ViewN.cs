using NoticeMyCar.BuyACar.Notice.Model;
using System;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace NoticeMyCar.BuyACar.Notice.View
{
    public partial class ViewN : Form, IViewN
    {
        public event EventHandler giveTheNumberOfNotices;
        public event EventHandler noticeAndId;
        public event EventHandler addinToWatched;
        public event EventHandler searchedd;
        public event EventHandler giveTheNumberOfFoundNotices;
        public event EventHandler showComments;

        Panel panel = new Panel();

        int numberOfUserNotices;
        int index;

        string searched;

        public ViewN()
        {
            InitializeComponent();

            userDataPanel();

            CreateObjects createObjects = new CreateObjects();
            createObjects.FacityFactory(this);
        }

        private void userDataPanel()
        {
            panel.Location = new Point(418, 12);
            panel.Size = new Size(100, 25);
            panel.BackColor = ColorTranslator.FromHtml("#808080");
        }

        public int id
        {
            get { return index; }
        }

        public string search
        {
            get { return searched; }
        }

        public void NumNumberOfNotices(int numberOfNotices)
        {
            numberOfUserNotices = numberOfNotices;
        }

        public void Data(IModelN data)
        {
            index = data.id;

            if (data.name == null)
                Controls.Remove(iconPictureBoxStatus);
            else if (data.name.Equals("aktywne"))
                iconPictureBoxStatus.IconColor = Color.LimeGreen;
            else
                iconPictureBoxStatus.IconColor = Color.Red;

            var str = convertToStream(data.image_url);
            pictureBoxCar.Image = Bitmap.FromStream(str);

            str = convertToStream(data.author_avatar);
            pictureBoxAuthorAvatar.Image = Bitmap.FromStream(str);

            labelTitle.Text = data.title;
            labelMark.Text = data.mark;
            labelModel.Text = data.model;
            labelColor.Text = data.color;
            labelBody.Text = data.body;
            labelMileage.Text = data.mileage;
            labelPrice.Text = data.price;
            labelYear.Text = data.year;
            labelName.Text = data.notice_author;
            labelEmail.Text = data.notice_author_email;
            labelContent.Text = data.message;
        }

        public void Watched(bool hasBeenAddedToWatchlist)
        {
            if (hasBeenAddedToWatchlist)
                MessageBox.Show("Dodano do obserwowanych ogłoszeń.", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Nie dodano do obserwowanych ogłoszeń.", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


        public int theNumberOfNotices(string areYouLookingFor)
        {
            if (areYouLookingFor != null)
            {
                searched = areYouLookingFor;
                giveTheNumberOfFoundNotices(this, EventArgs.Empty);
            }
            else
                giveTheNumberOfNotices(this, EventArgs.Empty);

            return numberOfUserNotices;
        }

        public Form Notices(int id, string areYouLookingFor)
        {
            index = id;

            if (areYouLookingFor != null)
            {
                searched = areYouLookingFor;
                searchedd(this, EventArgs.Empty);
            }
            else
                noticeAndId(this, EventArgs.Empty);

            return this;
        }

        private System.IO.Stream convertToStream(string link)
        {
            WebRequest request = WebRequest.Create(link);
            var response = request.GetResponse();
            var str = response.GetResponseStream();

            return str;
        }

        private void pictureBoxAuthorAvatar_MouseEnter(object sender, EventArgs e)
        {
            panelDataAuthor.Show();
        }

        private void pictureBoxAuthorAvatar_MouseLeave(object sender, EventArgs e)
        {
            panelDataAuthor.Hide();
        }

        private void iconButtonAddinToWatched_Click(object sender, EventArgs e)
        {
            addinToWatched(this, EventArgs.Empty);
        }

        private void iconButtonComments_Click(object sender, EventArgs e)
        {
            showComments(this, EventArgs.Empty);
        }
    }
}
