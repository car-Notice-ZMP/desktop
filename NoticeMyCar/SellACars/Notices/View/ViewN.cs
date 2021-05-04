using NoticeMyCar.SellACars.Notices.Model;
using RestSharp;
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

namespace NoticeMyCar.SellACars.Notices.View
{
    public partial class ViewN : Form, IViewN
    {
        public event EventHandler noticeAndId;
        public event EventHandler giveTheNumberOfNotices;
        public event EventHandler deleteNotice;
        public event EventHandler statusNotice;

        int numberOfUserNotices;
        int index = 0;

        public ViewN()
        {
            InitializeComponent();

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

        public void Status(bool status)
        {
            if (status)
                iconButtonStatus.IconColor = Color.LimeGreen;
        }

        public void Data(IModelN data)
        {
            index = data.id;

            if (data.name.Equals("aktywne"))
                iconButtonStatus.IconColor = Color.LimeGreen;
            else
                iconButtonStatus.IconColor = Color.Red;

            WebRequest request = WebRequest.Create(data.image_url);
            var response = request.GetResponse();
            var str = response.GetResponseStream();

            pictureBox1.Image = Bitmap.FromStream(str);

            labelTitle.Text = data.title;
            labelMark.Text = data.mark;
            labelModel.Text = data.model;
            labelColor.Text = data.color;
            labelBody.Text = data.body;
            labelMileage.Text = data.mileage;
            labelPrice.Text = data.price;
            labelYear.Text = data.year;
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

        private void iconButtonDelete_Click(object sender, EventArgs e)
        {
            deleteNotice(this, EventArgs.Empty);
            Close();
        }

        private void iconButtonStatus_Click(object sender, EventArgs e)
        {
            if (iconButtonStatus.IconColor == Color.Red)
                statusNotice(this, EventArgs.Empty);
        }
    }
}
