using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            get { return textBoxtitle.Text; }
        }

        public string content
        {
            get { return richTextBoxContent.Text; }
        }

        public void Report(bool report)
        {
            if (report)
            {
                iconButtonWhetherAdded.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
                iconButtonWhetherAdded.IconColor = Color.LimeGreen;
            }
            else
            {
                iconButtonWhetherAdded.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
                iconButtonWhetherAdded.IconColor = Color.Red;
            }

            iconButtonWhetherAdded.Visible = true;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (notice != null)
                notice(this, EventArgs.Empty);
        }

        /*private byte[] ImageToByte()
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(pictureBoxCar.Image, typeof(byte[]));
        }*/

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
