
namespace Tyuiu.ShunanovKE.Sprint6.Task7.V18
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.labelInfo_SKE = new System.Windows.Forms.Label();
            this.pictureBoxAvatar_SKE = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_SKE)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInfo_SKE
            // 
            this.labelInfo_SKE.AutoSize = true;
            this.labelInfo_SKE.Location = new System.Drawing.Point(274, 12);
            this.labelInfo_SKE.Name = "labelInfo_SKE";
            this.labelInfo_SKE.Size = new System.Drawing.Size(284, 117);
            this.labelInfo_SKE.TabIndex = 2;
            this.labelInfo_SKE.Text = resources.GetString("labelInfo_SKE.Text");
            // 
            // pictureBoxAvatar_SKE
            // 
            this.pictureBoxAvatar_SKE.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAvatar_SKE.Image")));
            this.pictureBoxAvatar_SKE.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxAvatar_SKE.Name = "pictureBoxAvatar_SKE";
            this.pictureBoxAvatar_SKE.Size = new System.Drawing.Size(256, 188);
            this.pictureBoxAvatar_SKE.TabIndex = 3;
            this.pictureBoxAvatar_SKE.TabStop = false;
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 214);
            this.Controls.Add(this.pictureBoxAvatar_SKE);
            this.Controls.Add(this.labelInfo_SKE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_SKE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInfo_SKE;
        private System.Windows.Forms.PictureBox pictureBoxAvatar_SKE;
    }
}