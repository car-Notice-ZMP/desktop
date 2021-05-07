using NoticeMyCar.BuyACar.Notice.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoticeMyCar.BuyACar.Notice.View
{
    public partial class ViewN : Form, IViewN
    {
        public event EventHandler noticeAndId;
        public event EventHandler giveTheNumberOfNotices;

        Panel panel = new Panel();

        int numberOfUserNotices;
        int index = 0;

        public ViewN()
        {
            InitializeComponent();

            panel.Location = new Point(418, 12);
            panel.Size = new Size(100, 25);
            panel.BackColor = ColorTranslator.FromHtml("#808080");

            CreateObjects createObjects = new CreateObjects();
            createObjects.FacityFactory(this);
        }

        public int id
        {
            get { return index; }
        }

        public void NumNumberOfNotices(int numberOfNotices)
        {
            numberOfUserNotices = numberOfNotices;
        }

        public void Data(IModelN data)
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

        public int theNumberOfMyNotices()
        {
            giveTheNumberOfNotices(this, EventArgs.Empty);
            return numberOfUserNotices;
        }

        public Form Notices(int id)
        {
            index = id;
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
    }
}
