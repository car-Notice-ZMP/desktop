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
        public event EventHandler notice;
        public event EventHandler giveTheNumberOfNotices;

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

        public void Data(IModelN data)
        {
            WebRequest request = WebRequest.Create(data.image_url);
            var response = request.GetResponse();
            var str = response.GetResponseStream();

            pictureBox1.Image = Bitmap.FromStream(str);
            label1.Text = data.title;
            label2.Text = data.contenet;
        }

        public int theNumberOfMyNotices()
        {
            giveTheNumberOfNotices(this, EventArgs.Empty);
            return numberOfUserNotices;
        }

        public Form Notices(int id)
        {
            index = id;
            notice(this, EventArgs.Empty);
            return this;
        }
    }
}
