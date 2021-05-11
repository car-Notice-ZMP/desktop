using NoticeMyCar.CommonNoticeDetail.Model;
using System;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace NoticeMyCar.CommonNoticeDetail.View
{
    public partial class ViewC : Form, IViewC
    {
        public event EventHandler giveMeTheData;
        public event EventHandler addComment;

        int index;

        public ViewC(int id)
        {
            InitializeComponent();

            CreateObjects createObjects = new CreateObjects();
            createObjects.FacityFactory(this);

            giveId(id);
        }

        public int id
        {
            get { return index; }
        }

        public string content
        {
            get { return richTextBoxContent.Text; }
        }

        public void Data(IModelC data)
        {
            index = data.id;

            if (data.name.Equals("aktywne"))
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

        public void HasAnNoticeBeenAdded(bool wasItSuccessful)
        {
            if (wasItSuccessful)
            {
                iconPictureBoxWasItSent.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
                iconPictureBoxWasItSent.IconColor = Color.LimeGreen;
            }
            else
            {
                iconPictureBoxWasItSent.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
                iconPictureBoxWasItSent.IconColor = Color.Red;
            }

            iconPictureBoxWasItSent.Visible = true;

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

        private void giveId(int id)
        {
            index = id;
            giveMeTheData(this, EventArgs.Empty);
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            addComment(this, EventArgs.Empty);
        }
    }
}
