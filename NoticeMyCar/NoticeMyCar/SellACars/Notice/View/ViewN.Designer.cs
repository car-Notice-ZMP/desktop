
namespace NoticeMyCar.SellACars.Notice.View
{
    partial class ViewN
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
            this.pictureBoxCar = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelContent = new System.Windows.Forms.Label();
            this.iconButtonDelete = new FontAwesome.Sharp.IconButton();
            this.iconButtonEdit = new FontAwesome.Sharp.IconButton();
            this.iconButtonStatus = new FontAwesome.Sharp.IconButton();
            this.labelMark = new System.Windows.Forms.Label();
            this.labelModel = new System.Windows.Forms.Label();
            this.labelColor = new System.Windows.Forms.Label();
            this.labelBody = new System.Windows.Forms.Label();
            this.labelMileage = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.iconButtonComments = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxCar
            // 
            this.pictureBoxCar.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCar.Location = new System.Drawing.Point(17, 31);
            this.pictureBoxCar.Name = "pictureBoxCar";
            this.pictureBoxCar.Size = new System.Drawing.Size(200, 113);
            this.pictureBoxCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCar.TabIndex = 2;
            this.pictureBoxCar.TabStop = false;
            this.pictureBoxCar.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureBoxCar_DragDrop);
            this.pictureBoxCar.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureBoxCar_DragEnter);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitle.Location = new System.Drawing.Point(125, 160);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.labelTitle.Size = new System.Drawing.Size(40, 29);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "X";
            // 
            // labelContent
            // 
            this.labelContent.BackColor = System.Drawing.Color.Transparent;
            this.labelContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelContent.Location = new System.Drawing.Point(359, 199);
            this.labelContent.Name = "labelContent";
            this.labelContent.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.labelContent.Size = new System.Drawing.Size(210, 192);
            this.labelContent.TabIndex = 4;
            this.labelContent.Text = "X";
            // 
            // iconButtonDelete
            // 
            this.iconButtonDelete.BackColor = System.Drawing.Color.Transparent;
            this.iconButtonDelete.FlatAppearance.BorderSize = 0;
            this.iconButtonDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.iconButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonDelete.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.iconButtonDelete.IconColor = System.Drawing.Color.Red;
            this.iconButtonDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonDelete.IconSize = 22;
            this.iconButtonDelete.Location = new System.Drawing.Point(552, 0);
            this.iconButtonDelete.Name = "iconButtonDelete";
            this.iconButtonDelete.Size = new System.Drawing.Size(48, 30);
            this.iconButtonDelete.TabIndex = 5;
            this.iconButtonDelete.UseVisualStyleBackColor = false;
            this.iconButtonDelete.Click += new System.EventHandler(this.iconButtonDelete_Click);
            // 
            // iconButtonEdit
            // 
            this.iconButtonEdit.BackColor = System.Drawing.Color.Transparent;
            this.iconButtonEdit.FlatAppearance.BorderSize = 0;
            this.iconButtonEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.iconButtonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonEdit.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.iconButtonEdit.IconColor = System.Drawing.Color.LightGray;
            this.iconButtonEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonEdit.IconSize = 22;
            this.iconButtonEdit.Location = new System.Drawing.Point(507, 0);
            this.iconButtonEdit.Name = "iconButtonEdit";
            this.iconButtonEdit.Size = new System.Drawing.Size(48, 30);
            this.iconButtonEdit.TabIndex = 6;
            this.iconButtonEdit.UseVisualStyleBackColor = false;
            this.iconButtonEdit.Click += new System.EventHandler(this.iconButtonEdit_Click);
            // 
            // iconButtonStatus
            // 
            this.iconButtonStatus.BackColor = System.Drawing.Color.Transparent;
            this.iconButtonStatus.FlatAppearance.BorderSize = 0;
            this.iconButtonStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonStatus.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.iconButtonStatus.IconColor = System.Drawing.Color.LimeGreen;
            this.iconButtonStatus.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButtonStatus.IconSize = 20;
            this.iconButtonStatus.Location = new System.Drawing.Point(5, 5);
            this.iconButtonStatus.Name = "iconButtonStatus";
            this.iconButtonStatus.Size = new System.Drawing.Size(20, 20);
            this.iconButtonStatus.TabIndex = 8;
            this.iconButtonStatus.UseVisualStyleBackColor = false;
            this.iconButtonStatus.Click += new System.EventHandler(this.iconButtonStatus_Click);
            // 
            // labelMark
            // 
            this.labelMark.AutoSize = true;
            this.labelMark.BackColor = System.Drawing.Color.Transparent;
            this.labelMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMark.Location = new System.Drawing.Point(125, 189);
            this.labelMark.Name = "labelMark";
            this.labelMark.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.labelMark.Size = new System.Drawing.Size(40, 29);
            this.labelMark.TabIndex = 9;
            this.labelMark.Text = "X";
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.BackColor = System.Drawing.Color.Transparent;
            this.labelModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelModel.Location = new System.Drawing.Point(125, 218);
            this.labelModel.Name = "labelModel";
            this.labelModel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.labelModel.Size = new System.Drawing.Size(40, 29);
            this.labelModel.TabIndex = 10;
            this.labelModel.Text = "X";
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.BackColor = System.Drawing.Color.Transparent;
            this.labelColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelColor.Location = new System.Drawing.Point(125, 247);
            this.labelColor.Name = "labelColor";
            this.labelColor.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.labelColor.Size = new System.Drawing.Size(40, 29);
            this.labelColor.TabIndex = 11;
            this.labelColor.Text = "X";
            // 
            // labelBody
            // 
            this.labelBody.AutoSize = true;
            this.labelBody.BackColor = System.Drawing.Color.Transparent;
            this.labelBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBody.Location = new System.Drawing.Point(125, 276);
            this.labelBody.Name = "labelBody";
            this.labelBody.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.labelBody.Size = new System.Drawing.Size(40, 29);
            this.labelBody.TabIndex = 12;
            this.labelBody.Text = "X";
            // 
            // labelMileage
            // 
            this.labelMileage.AutoSize = true;
            this.labelMileage.BackColor = System.Drawing.Color.Transparent;
            this.labelMileage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMileage.Location = new System.Drawing.Point(125, 305);
            this.labelMileage.Name = "labelMileage";
            this.labelMileage.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.labelMileage.Size = new System.Drawing.Size(40, 29);
            this.labelMileage.TabIndex = 13;
            this.labelMileage.Text = "X";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.BackColor = System.Drawing.Color.Transparent;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPrice.Location = new System.Drawing.Point(125, 334);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.labelPrice.Size = new System.Drawing.Size(40, 29);
            this.labelPrice.TabIndex = 14;
            this.labelPrice.Text = "X";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.BackColor = System.Drawing.Color.Transparent;
            this.labelYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelYear.Location = new System.Drawing.Point(125, 363);
            this.labelYear.Name = "labelYear";
            this.labelYear.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.labelYear.Size = new System.Drawing.Size(40, 29);
            this.labelYear.TabIndex = 15;
            this.labelYear.Text = "X";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(54, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tytuł:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(51, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 29);
            this.label2.TabIndex = 17;
            this.label2.Text = "Kolor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(43, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 29);
            this.label3.TabIndex = 18;
            this.label3.Text = "Marka:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(68, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 29);
            this.label4.TabIndex = 19;
            this.label4.Text = "Typ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(12, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 29);
            this.label5.TabIndex = 20;
            this.label5.Text = "Przebieg:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(52, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 29);
            this.label6.TabIndex = 21;
            this.label6.Text = "Cena:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(41, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 29);
            this.label7.TabIndex = 22;
            this.label7.Text = "Model:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(66, 363);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 29);
            this.label8.TabIndex = 23;
            this.label8.Text = "Rok:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(359, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 29);
            this.label9.TabIndex = 24;
            this.label9.Text = "Opis:";
            // 
            // iconButtonComments
            // 
            this.iconButtonComments.BackColor = System.Drawing.Color.Transparent;
            this.iconButtonComments.FlatAppearance.BorderSize = 0;
            this.iconButtonComments.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.iconButtonComments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonComments.IconChar = FontAwesome.Sharp.IconChar.Comment;
            this.iconButtonComments.IconColor = System.Drawing.Color.LightGray;
            this.iconButtonComments.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButtonComments.IconSize = 22;
            this.iconButtonComments.Location = new System.Drawing.Point(459, 0);
            this.iconButtonComments.Name = "iconButtonComments";
            this.iconButtonComments.Size = new System.Drawing.Size(48, 30);
            this.iconButtonComments.TabIndex = 47;
            this.iconButtonComments.UseVisualStyleBackColor = false;
            this.iconButtonComments.Click += new System.EventHandler(this.iconButtonComments_Click);
            // 
            // ViewN
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.iconButtonComments);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelMileage);
            this.Controls.Add(this.labelBody);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.labelMark);
            this.Controls.Add(this.iconButtonStatus);
            this.Controls.Add(this.iconButtonEdit);
            this.Controls.Add(this.iconButtonDelete);
            this.Controls.Add(this.labelContent);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.pictureBoxCar);
            this.ForeColor = System.Drawing.Color.LightGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewN";
            this.Text = "ViewN";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCar;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelContent;
        private FontAwesome.Sharp.IconButton iconButtonDelete;
        private FontAwesome.Sharp.IconButton iconButtonEdit;
        private FontAwesome.Sharp.IconButton iconButtonStatus;
        private System.Windows.Forms.Label labelMark;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Label labelBody;
        private System.Windows.Forms.Label labelMileage;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private FontAwesome.Sharp.IconButton iconButtonComments;
    }
}