using System;
using System.Drawing;
using System.Windows.Forms;

namespace NoticeMyCar.SendAMessage.View
{
    public partial class ViewSAM : Form, IViewSAM
    {
        public event EventHandler send;

        public ViewSAM()
        {
            InitializeComponent();

            CreateObjects createObjects = new CreateObjects();
            createObjects.FacityFactory(this);
        }

        public string receiver
        {
            get { return textBoxReceiver.Text; }
        }

        public string title
        {
            get { return richTextBoxTitle.Text; }
        }

        public string content
        {
            get { return richTextBoxContent.Text; }
        }

        public void wasItSent(bool wasItSent)
        {
            if (wasItSent)
                iconPictureBoxWasItSent.Show();
            else
                MessageBox.Show("Nie posiadasz uprawnień administratora.", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void ViewSAM_Resize(object sender, EventArgs e)
        {
            richTextBoxContent.Size = new Size(richTextBoxContent.Width, Height - 530);
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (send != null)
                send(this, EventArgs.Empty);
        }
    }
}
