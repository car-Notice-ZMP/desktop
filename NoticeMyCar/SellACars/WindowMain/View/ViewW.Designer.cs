
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
            // ViewW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(753, 532);
            this.Controls.Add(this.iconButtonAddNotice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewW";
            this.Text = "ViewW";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButtonAddNotice;
    }
}