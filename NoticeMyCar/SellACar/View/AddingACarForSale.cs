using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoticeMyCar.SellACar.View
{
    public partial class AddingACarForSale : Form
    {
        public AddingACarForSale()
        {
            InitializeComponent();
        }

        private void pictureBoxCar_DragDrop(object sender, DragEventArgs e)
        {
            var info = e.Data.GetData(DataFormats.FileDrop);
            if (info != null)
            {
                var fileName = info as string[];
                if (fileName.Length > 0)
                    pictureBoxCar.Image = Image.FromFile(fileName[0]);
            }
        }

        private void pictureBoxCar_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void AddingACarForSale_Load(object sender, EventArgs e)
        {
            pictureBoxCar.AllowDrop = true;
        }
    }
}
