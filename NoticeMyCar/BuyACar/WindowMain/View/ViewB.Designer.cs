
namespace NoticeMyCar.BuyACa.WindowMain.View
{
    partial class ViewB
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
            this.panelBottom = new System.Windows.Forms.Panel();
            this.labelPage = new System.Windows.Forms.Label();
            this.iconButtonAngleLeft = new FontAwesome.Sharp.IconButton();
            this.iconButtonAngleRight = new FontAwesome.Sharp.IconButton();
            this.textBoxSearched = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.labelPage);
            this.panelBottom.Controls.Add(this.iconButtonAngleLeft);
            this.panelBottom.Controls.Add(this.iconButtonAngleRight);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 504);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(837, 50);
            this.panelBottom.TabIndex = 3;
            // 
            // labelPage
            // 
            this.labelPage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPage.AutoSize = true;
            this.labelPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPage.Location = new System.Drawing.Point(411, 0);
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
            this.iconButtonAngleLeft.Location = new System.Drawing.Point(331, 0);
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
            this.iconButtonAngleRight.Location = new System.Drawing.Point(481, 0);
            this.iconButtonAngleRight.Name = "iconButtonAngleRight";
            this.iconButtonAngleRight.Size = new System.Drawing.Size(50, 50);
            this.iconButtonAngleRight.TabIndex = 0;
            this.iconButtonAngleRight.UseVisualStyleBackColor = false;
            this.iconButtonAngleRight.Click += new System.EventHandler(this.iconButtonAngleRight_Click);
            // 
            // textBoxSearched
            // 
            this.textBoxSearched.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxSearched.Location = new System.Drawing.Point(80, 28);
            this.textBoxSearched.Name = "textBoxSearched";
            this.textBoxSearched.Size = new System.Drawing.Size(205, 26);
            this.textBoxSearched.TabIndex = 4;
            // 
            // buttonSearch
            // 
            this.buttonSearch.AutoSize = true;
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSearch.ForeColor = System.Drawing.Color.LightGray;
            this.buttonSearch.Location = new System.Drawing.Point(300, 24);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(94, 34);
            this.buttonSearch.TabIndex = 25;
            this.buttonSearch.Text = "Szukaj";
            this.buttonSearch.UseVisualStyleBackColor = false;
            // 
            // ViewB
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(837, 554);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearched);
            this.Controls.Add(this.panelBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewB";
            this.Text = "ViewB";
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Label labelPage;
        private FontAwesome.Sharp.IconButton iconButtonAngleLeft;
        private FontAwesome.Sharp.IconButton iconButtonAngleRight;
        private System.Windows.Forms.TextBox textBoxSearched;
        private System.Windows.Forms.Button buttonSearch;
    }
}