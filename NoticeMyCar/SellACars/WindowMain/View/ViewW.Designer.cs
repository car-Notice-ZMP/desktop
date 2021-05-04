
namespace NoticeMyCar.SellACars.WindowMain.View
{
    partial class ViewW
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
            this.iconButtonAddNotice = new FontAwesome.Sharp.IconButton();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.labelPage = new System.Windows.Forms.Label();
            this.iconButtonAngleLeft = new FontAwesome.Sharp.IconButton();
            this.iconButtonAngleRight = new FontAwesome.Sharp.IconButton();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // iconButtonAddNotice
            // 
            this.iconButtonAddNotice.AutoSize = true;
            this.iconButtonAddNotice.BackColor = System.Drawing.Color.Transparent;
            this.iconButtonAddNotice.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconButtonAddNotice.FlatAppearance.BorderSize = 0;
            this.iconButtonAddNotice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.iconButtonAddNotice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonAddNotice.ForeColor = System.Drawing.Color.Black;
            this.iconButtonAddNotice.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.iconButtonAddNotice.IconColor = System.Drawing.Color.Black;
            this.iconButtonAddNotice.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonAddNotice.IconSize = 72;
            this.iconButtonAddNotice.Location = new System.Drawing.Point(675, 0);
            this.iconButtonAddNotice.Margin = new System.Windows.Forms.Padding(0);
            this.iconButtonAddNotice.Name = "iconButtonAddNotice";
            this.iconButtonAddNotice.Size = new System.Drawing.Size(78, 532);
            this.iconButtonAddNotice.TabIndex = 1;
            this.iconButtonAddNotice.UseVisualStyleBackColor = false;
            this.iconButtonAddNotice.Click += new System.EventHandler(this.iconButtonAddNotice_Click);
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.labelPage);
            this.panelBottom.Controls.Add(this.iconButtonAngleLeft);
            this.panelBottom.Controls.Add(this.iconButtonAngleRight);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 482);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(675, 50);
            this.panelBottom.TabIndex = 2;
            // 
            // labelPage
            // 
            this.labelPage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPage.AutoSize = true;
            this.labelPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPage.Location = new System.Drawing.Point(330, 0);
            this.labelPage.Name = "labelPage";
            this.labelPage.Size = new System.Drawing.Size(39, 42);
            this.labelPage.TabIndex = 2;
            this.labelPage.Text = "1";
            // 
            // iconButtonAngleLeft
            // 
            this.iconButtonAngleLeft.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButtonAngleLeft.FlatAppearance.BorderSize = 0;
            this.iconButtonAngleLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonAngleLeft.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            this.iconButtonAngleLeft.IconColor = System.Drawing.Color.Black;
            this.iconButtonAngleLeft.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonAngleLeft.IconSize = 62;
            this.iconButtonAngleLeft.Location = new System.Drawing.Point(250, 0);
            this.iconButtonAngleLeft.Name = "iconButtonAngleLeft";
            this.iconButtonAngleLeft.Size = new System.Drawing.Size(50, 50);
            this.iconButtonAngleLeft.TabIndex = 1;
            this.iconButtonAngleLeft.UseVisualStyleBackColor = true;
            this.iconButtonAngleLeft.Click += new System.EventHandler(this.iconButtonAngleLeft_Click);
            // 
            // iconButtonAngleRight
            // 
            this.iconButtonAngleRight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButtonAngleRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.iconButtonAngleRight.FlatAppearance.BorderSize = 0;
            this.iconButtonAngleRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonAngleRight.IconChar = FontAwesome.Sharp.IconChar.AngleRight;
            this.iconButtonAngleRight.IconColor = System.Drawing.Color.Black;
            this.iconButtonAngleRight.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonAngleRight.IconSize = 62;
            this.iconButtonAngleRight.Location = new System.Drawing.Point(400, 0);
            this.iconButtonAngleRight.Name = "iconButtonAngleRight";
            this.iconButtonAngleRight.Size = new System.Drawing.Size(50, 50);
            this.iconButtonAngleRight.TabIndex = 0;
            this.iconButtonAngleRight.UseVisualStyleBackColor = false;
            this.iconButtonAngleRight.Click += new System.EventHandler(this.iconButtonAngleRight_Click);
            // 
            // ViewW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(753, 532);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.iconButtonAddNotice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewW";
            this.Text = "ViewW";
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButtonAddNotice;
        private System.Windows.Forms.Panel panelBottom;
        private FontAwesome.Sharp.IconButton iconButtonAngleLeft;
        private FontAwesome.Sharp.IconButton iconButtonAngleRight;
        private System.Windows.Forms.Label labelPage;
    }
}