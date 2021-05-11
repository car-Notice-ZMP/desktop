using System;
using System.Drawing;
using System.Windows.Forms;

namespace NoticeMyCar.SellACars.AddNotice.View
{
    public partial class ViewA : Form, IViewA
    {
        public event EventHandler notice;
        public string[] fileName;

        public ViewA()
        {
            InitializeComponent();
            pictureBoxCar.AllowDrop = true;

            CreateObjects createObjects = new CreateObjects();
            createObjects.FacityFactory(this);
        }

        public string image
        {
            get { return fileName[0]; }
        }

        public string title
        {
            get { return textBoxTitle.Text; }
        }

        public string content
        {
            get { return richTextBoxContent.Text; }
        }

        public string mark
        {
            get { return textBoxMark.Text; }
        }

        public string model
        {
            get { return textBoxModel.Text; }
        }

        public string color
        {
            get { return textBoxColor.Text; }
        }

        public string body
        {
            get { return textBoxBody.Text; }
        }

        public string mileage
        {
            get { return textBoxMileage.Text; }
        }

        public string price
        {
            get { return textBoxPrice.Text; }
        }

        public string year
        {
            get { return textBoxYear.Text; }
        }

        public void Report(bool report)
        {
            if (report)
            {
                iconPictureBoxWhetherAdded.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
                iconPictureBoxWhetherAdded.IconColor = Color.LimeGreen;
            }
            else
            {
                iconPictureBoxWhetherAdded.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
                iconPictureBoxWhetherAdded.IconColor = Color.Red;
            }

            iconPictureBoxWhetherAdded.Visible = true;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (notice != null)
                notice(this, EventArgs.Empty);
        }

        private void pictureBoxCar_DragDrop(object sender, DragEventArgs e)
        {
            var info = e.Data.GetData(DataFormats.FileDrop);
            if (info != null)
            {
                fileName = info as string[];
                if (fileName.Length > 0)
                    pictureBoxCar.Image = Image.FromFile(fileName[0]);
            }
        }

        private void pictureBoxCar_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
    }
}
