using NoticeMyCar.SellACars.Notice.Model;
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

namespace NoticeMyCar.SellACars.Notice.View
{
    public partial class ViewN : Form, IViewN
    {
        public event EventHandler noticeAndId;
        public event EventHandler giveTheNumberOfNotices;
        public event EventHandler delete;
        public event EventHandler status;
        public event EventHandler edit;

        List<string> data = new List<string>();
        List<string> changes = new List<string>();

        public string[] fileName;

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

        public List<string> update
        {
            get { return changes; }
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

            pictureBoxCar.Image = Bitmap.FromStream(str);

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

        public void Update(bool change)
        {
            if (change)
                displayingNewData();
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
            delete(this, EventArgs.Empty);
            Close();
        }

        private void iconButtonStatus_Click(object sender, EventArgs e)
        {
            if (iconButtonStatus.IconColor == Color.Red)
                status(this, EventArgs.Empty);
        }

        private void iconButtonEdit_Click(object sender, EventArgs e)
        {
            pictureBoxCar.AllowDrop = true;
            memorizeData();

            econversionToAField(labelTitle);
            econversionToAField(labelMark);
            econversionToAField(labelModel);
            econversionToAField(labelColor);
            econversionToAField(labelBody);
            econversionToAField(labelMileage);
            econversionToAField(labelPrice);
            econversionToAField(labelYear);

            econversionToAFieldRichTextBox(labelContent);

            createButton();
        }

        private void memorizeData()
        {
            data.Add(labelTitle.Text);
            data.Add(labelMark.Text);
            data.Add(labelModel.Text);
            data.Add(labelColor.Text);
            data.Add(labelBody.Text);
            data.Add(labelMileage.Text);
            data.Add(labelPrice.Text);
            data.Add(labelYear.Text);
            data.Add(labelContent.Text);
        }

        private void econversionToAField(Label label)
        {
            TextBox textBox = new TextBox();
            textBox.Location = new Point(label.Location.X, label.Location.Y + 3);
            textBox.Size = new Size(195, 0);

            string fontName = textBox.Font.Name;

            textBox.Font = new Font(fontName, 10);
            textBox.Text = label.Text;
            textBox.Name = "textBox";

            Controls.Remove(label);
            Controls.Add(textBox);
        }

        private void econversionToAFieldRichTextBox(Label label)
        {
            RichTextBox richTextBox = new RichTextBox();
            richTextBox.Location = label.Location;
            richTextBox.Size = new Size(200, 193);

            string fontName = richTextBox.Font.Name;

            richTextBox.Font = new Font(fontName, 10);
            richTextBox.Text = label.Text;
            richTextBox.Name = "textBox";

            Controls.Remove(label);
            Controls.Add(richTextBox);
        }

        private void createButton()
        {
            Button buttonEdit = new Button();
            buttonEdit.Location = new Point(472, 360);
            buttonEdit.Size = new Size(100, 30);
            buttonEdit.BackColor = ColorTranslator.FromHtml("#404040");

            buttonEdit.Text = "Zatwierdź";
            buttonEdit.Click += new EventHandler(buttonEdit_Click);

            Controls.Add(buttonEdit);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            currentData();
            edit(this, EventArgs.Empty);
        }

        private void currentData()
        {
            int i = 0;
            string tbs;

            Control[] tbxs = Controls.Find("textBox", false);

            foreach (var d in data)
            {
                if (i <= tbxs.Length - 1)
                {
                    if (i == tbxs.Length - 1)
                    {
                        RichTextBox rtb = tbxs[i] as RichTextBox;
                        tbs = rtb.Text;
                    }
                    else
                    {
                        TextBox tb = tbxs[i] as TextBox;
                        tbs = tb.Text;
                    }

                    if (!d.Equals(tbs))
                        changes.Add(i + "+,+" + tbs);
                }
                else if (fileName[0] != null)
                    changes.Add(i + "+,+" + fileName[0]);

                i++;
            }
        }

        private void pictureBoxCar_DragDrop(object sender, DragEventArgs e)
        {
            var info = e.Data.GetData(DataFormats.FileDrop);
            if (info != null)
            {
                fileName = info as string[];
                if (fileName.Length > 0)
                {
                    data.Add(fileName[0]);
                    pictureBoxCar.Image = Image.FromFile(fileName[0]);
                }
            }
        }

        private void pictureBoxCar_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }


        private void displayingNewData()
        {
            var labels = getTextBoxs();
            var labelRtb = getRichTextBox();

            labelTitle.Text = labels[0].Text;
            labelMark.Text = labels[1].Text;
            labelModel.Text = labels[2].Text;
            labelColor.Text = labels[3].Text;
            labelBody.Text = labels[4].Text;
            labelMileage.Text = labels[5].Text;
            labelPrice.Text = labels[6].Text;
            labelYear.Text = labels[7].Text;
            labelContent.Text = labelRtb.Text;

            foreach (var l in labels)
                Controls.Remove(l);

            Controls.Remove(labelRtb);

            Controls.Add(labelTitle);
            Controls.Add(labelMark);
            Controls.Add(labelModel);
            Controls.Add(labelColor);
            Controls.Add(labelBody);
            Controls.Add(labelMileage);
            Controls.Add(labelPrice);
            Controls.Add(labelYear);
            Controls.Add(labelContent);
        }

        private List<TextBox> getTextBoxs()
        {
            int i = 0;

            Control[] tbxs = Controls.Find("textBox", false);

            List<TextBox> text = new List<TextBox>();

            foreach (var t in tbxs)
            {
                if (i != tbxs.Length - 1)
                {
                    TextBox tb = t as TextBox;
                    text.Add(tb);
                }

                i++;
            }

            return text;
        }

        private RichTextBox getRichTextBox()
        {
            Control[] tbxs = Controls.Find("textBox", false);
            RichTextBox rtb = tbxs[tbxs.Length - 1] as RichTextBox;
            return rtb;
        }
    }
}
