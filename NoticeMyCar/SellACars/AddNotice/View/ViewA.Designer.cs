
namespace NoticeMyCar.SellACars.AddNotice.View
{
    partial class ViewA
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.pictureBoxCar = new System.Windows.Forms.PictureBox();
            this.richTextBoxContent = new System.Windows.Forms.RichTextBox();
            this.textBoxtitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.iconPictureBoxWhetherAdded = new FontAwesome.Sharp.IconPictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxWhetherAdded)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.iconPictureBoxWhetherAdded);
            this.panel1.Controls.Add(this.buttonCreate);
            this.panel1.Controls.Add(this.pictureBoxCar);
            this.panel1.Controls.Add(this.richTextBoxContent);
            this.panel1.Controls.Add(this.textBoxtitle);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(729, 508);
            this.panel1.TabIndex = 1;
            // 
            // buttonCreate
            // 
            this.buttonCreate.AutoSize = true;
            this.buttonCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCreate.Location = new System.Drawing.Point(556, 432);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(144, 45);
            this.buttonCreate.TabIndex = 25;
            this.buttonCreate.Text = "Stwórz";
            this.buttonCreate.UseVisualStyleBackColor = false;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // pictureBoxCar
            // 
            this.pictureBoxCar.BackColor = System.Drawing.Color.Crimson;
            this.pictureBoxCar.Location = new System.Drawing.Point(181, 25);
            this.pictureBoxCar.Name = "pictureBoxCar";
            this.pictureBoxCar.Size = new System.Drawing.Size(236, 135);
            this.pictureBoxCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCar.TabIndex = 7;
            this.pictureBoxCar.TabStop = false;
            this.pictureBoxCar.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureBoxCar_DragDrop);
            this.pictureBoxCar.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureBoxCar_DragEnter);
            // 
            // richTextBoxContent
            // 
            this.richTextBoxContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBoxContent.Location = new System.Drawing.Point(180, 264);
            this.richTextBoxContent.Name = "richTextBoxContent";
            this.richTextBoxContent.Size = new System.Drawing.Size(520, 138);
            this.richTextBoxContent.TabIndex = 5;
            this.richTextBoxContent.Text = "";
            // 
            // textBoxtitle
            // 
            this.textBoxtitle.Location = new System.Drawing.Point(180, 184);
            this.textBoxtitle.Name = "textBoxtitle";
            this.textBoxtitle.Size = new System.Drawing.Size(520, 49);
            this.textBoxtitle.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 42);
            this.label3.TabIndex = 2;
            this.label3.Text = "Opis:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tytuł:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zdjęcie:";
            // 
            // iconPictureBoxWhetherAdded
            // 
            this.iconPictureBoxWhetherAdded.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.iconPictureBoxWhetherAdded.ForeColor = System.Drawing.Color.LimeGreen;
            this.iconPictureBoxWhetherAdded.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.iconPictureBoxWhetherAdded.IconColor = System.Drawing.Color.LimeGreen;
            this.iconPictureBoxWhetherAdded.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxWhetherAdded.IconSize = 100;
            this.iconPictureBoxWhetherAdded.Location = new System.Drawing.Point(600, 25);
            this.iconPictureBoxWhetherAdded.Name = "iconPictureBoxWhetherAdded";
            this.iconPictureBoxWhetherAdded.Size = new System.Drawing.Size(100, 100);
            this.iconPictureBoxWhetherAdded.TabIndex = 28;
            this.iconPictureBoxWhetherAdded.TabStop = false;
            this.iconPictureBoxWhetherAdded.Visible = false;
            // 
            // ViewA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(22F, 42F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(753, 532);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.LightGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.Name = "ViewA";
            this.Text = "ViewA";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxWhetherAdded)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.PictureBox pictureBoxCar;
        private System.Windows.Forms.RichTextBox richTextBoxContent;
        private System.Windows.Forms.TextBox textBoxtitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxWhetherAdded;
    }
}