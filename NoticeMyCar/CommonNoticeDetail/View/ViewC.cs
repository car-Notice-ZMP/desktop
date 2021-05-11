using NoticeMyCar.CommonNoticeDetail.Model;
using System;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace NoticeMyCar.CommonNoticeDetail.View
{
    public partial class ViewC : Form, IViewC
    {
        public event EventHandler giveMeTheNotice;
        public event EventHandler addComment;
        public event EventHandler giveComment;
        public event EventHandler giveTheNumberOfComments;

        int index;
        int quantity;
        int x = 119;
        int y = 457;

        public ViewC(int id)
        {
            InitializeComponent();

            CreateObjects createObjects = new CreateObjects();
            createObjects.FacityFactory(this);

            givesTheId(id);
            giveTheNumberOfComments(this, EventArgs.Empty);
            commentField();
        }

        public int id
        {
            get { return index; }
        }

        public string content
        {
            get { return richTextBoxContent.Text; }
        }

        public int number
        {
            get { return quantity; }
        }

        public void Notice(INotice data)
        {
            index = data.id;

            if (data.name.Equals("aktywne"))
                iconPictureBoxStatus.IconColor = Color.LimeGreen;
            else
                iconPictureBoxStatus.IconColor = Color.Red;

            var str = convertToStream(data.image_url);
            pictureBoxCar.Image = Image.FromStream(str);

            str = convertToStream(data.author_avatar);
            pictureBoxAuthorAvatar.Image = Image.FromStream(str);

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

        public void NumberOfComments(int q)
        {
            for (int i = 0; i < q; i++)
            {
                quantity = i;
                giveComment(this, EventArgs.Empty);
            }
        }

        public void Comment(IComment comment)
        {
            Panel panel = new Panel();
            panel.Location = new Point(x, y);
            panel.Size = new Size(600, 85);
            panel.Anchor = AnchorStyles.Top;
            panel.BackColor = ColorTranslator.FromHtml("#202020");

            PictureBox avatar = new PictureBox();
            avatar.Location = new Point(18, 18);
            avatar.Size = new Size(50, 50);
            avatar.SizeMode = PictureBoxSizeMode.Zoom;
            var image = convertToStream(comment.author_avatar);
            avatar.Image = Image.FromStream(image);

            Label name = new Label();
            name.Location = new Point(75, 0);
            name.Font = new Font("Microsoft Sans Serif", 12);
            name.ForeColor = Color.DodgerBlue;
            name.Text = comment.comment_author;

            Label content = new Label();
            content.Location = new Point(75, 20);
            content.Font = new Font("Microsoft Sans Serif", 10);
            content.Text = comment.content;

            panel.Controls.Add(avatar);
            panel.Controls.Add(name);
            panel.Controls.Add(content);

            Controls.Add(panel);

            y += 100;
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

        private void givesTheId(int id)
        {
            index = id;
            giveMeTheNotice(this, EventArgs.Empty);
        }

        private void commentField()
        {
            int pictureX = iconPictureBoxWasItSent.Location.X;

            panelAddComment.Location = new Point(x, y);
            iconPictureBoxWasItSent.Location = new Point(pictureX, y);
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            addComment(this, EventArgs.Empty);
        }
    }
}
