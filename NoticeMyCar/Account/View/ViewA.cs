using NoticeMyCar.Account.Model;
using System;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace NoticeMyCar.Account.View
{
    public partial class ViewA : Form, IViewA
    {
        public event EventHandler profile;

        public ViewA()
        {
            InitializeComponent();

            CreateObjects createObjects = new CreateObjects();
            createObjects.FacityFactory(this);

            profile(this, EventArgs.Empty);
        }

        public void Data(IModelA data)
        {
            WebRequest request = WebRequest.Create(data.avatar);
            var response = request.GetResponse();
            var str = response.GetResponseStream();
            pictureBoxAvatar.Image = Bitmap.FromStream(str);

            labelName.Text = data.name;
            labelEmail.Text = data.email;
        }

        private void pictureBox1_Resize(object sender, EventArgs e)
        {
            pictureBoxAvatar.Size = new Size(pictureBoxAvatar.Size.Height, pictureBoxAvatar.Size.Height);
        }
    }
}
