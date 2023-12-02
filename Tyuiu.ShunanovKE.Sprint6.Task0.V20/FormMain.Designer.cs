
namespace Tyuiu.ShunanovKE.Sprint6.Task0.V20
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxTask_SKE = new System.Windows.Forms.GroupBox();
            this.textBoxTask_SKE = new System.Windows.Forms.TextBox();
            this.pictureBoxTask_SKE = new System.Windows.Forms.PictureBox();
            this.groupBoxInPut = new System.Windows.Forms.GroupBox();
            this.buttonInfo_SKE = new System.Windows.Forms.Button();
            this.textBoxInPut_SKE = new System.Windows.Forms.TextBox();
            this.labelInPut_SKE = new System.Windows.Forms.Label();
            this.buttonDone_SKE = new System.Windows.Forms.Button();
            this.groupBoxOutPut_SKE = new System.Windows.Forms.GroupBox();
            this.textBoxOutPut_SKE = new System.Windows.Forms.TextBox();
            this.labelOutPut_SKE = new System.Windows.Forms.Label();
            this.groupBoxTask_SKE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTask_SKE)).BeginInit();
            this.groupBoxInPut.SuspendLayout();
            this.groupBoxOutPut_SKE.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_SKE
            // 
            this.groupBoxTask_SKE.Controls.Add(this.textBoxTask_SKE);
            this.groupBoxTask_SKE.Location = new System.Drawing.Point(8, 9);
            this.groupBoxTask_SKE.Name = "groupBoxTask_SKE";
            this.groupBoxTask_SKE.Size = new System.Drawing.Size(336, 131);
            this.groupBoxTask_SKE.TabIndex = 0;
            this.groupBoxTask_SKE.TabStop = false;
            this.groupBoxTask_SKE.Text = "Условие";
            // 
            // textBoxTask_SKE
            // 
            this.textBoxTask_SKE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_SKE.Location = new System.Drawing.Point(6, 19);
            this.textBoxTask_SKE.Multiline = true;
            this.textBoxTask_SKE.Name = "textBoxTask_SKE";
            this.textBoxTask_SKE.ReadOnly = true;
            this.textBoxTask_SKE.Size = new System.Drawing.Size(324, 63);
            this.textBoxTask_SKE.TabIndex = 0;
            this.textBoxTask_SKE.Text = "Дано выражение вычислить его значение при x = 3, результат вывести в TextBox. Окр" +
    "углить до трёх знаков после запятой. Графический интерфейс оформить по шаблону и" +
    "з лекции.";
            // 
            // pictureBoxTask_SKE
            // 
            this.pictureBoxTask_SKE.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTask_SKE.Image")));
            this.pictureBoxTask_SKE.Location = new System.Drawing.Point(350, 28);
            this.pictureBoxTask_SKE.Name = "pictureBoxTask_SKE";
            this.pictureBoxTask_SKE.Size = new System.Drawing.Size(126, 57);
            this.pictureBoxTask_SKE.TabIndex = 1;
            this.pictureBoxTask_SKE.TabStop = false;
            // 
            // groupBoxInPut
            // 
            this.groupBoxInPut.Controls.Add(this.labelInPut_SKE);
            this.groupBoxInPut.Controls.Add(this.textBoxInPut_SKE);
            this.groupBoxInPut.Location = new System.Drawing.Point(11, 152);
            this.groupBoxInPut.Name = "groupBoxInPut";
            this.groupBoxInPut.Size = new System.Drawing.Size(228, 98);
            this.groupBoxInPut.TabIndex = 2;
            this.groupBoxInPut.TabStop = false;
            this.groupBoxInPut.Text = "Ввод Данных";
            // 
            // buttonInfo_SKE
            // 
            this.buttonInfo_SKE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInfo_SKE.Location = new System.Drawing.Point(250, 227);
            this.buttonInfo_SKE.Name = "buttonInfo_SKE";
            this.buttonInfo_SKE.Size = new System.Drawing.Size(74, 23);
            this.buttonInfo_SKE.TabIndex = 0;
            this.buttonInfo_SKE.Text = "?";
            this.buttonInfo_SKE.UseVisualStyleBackColor = true;
            this.buttonInfo_SKE.Click += new System.EventHandler(this.buttonInfo_SKE_Click);
            // 
            // textBoxInPut_SKE
            // 
            this.textBoxInPut_SKE.Location = new System.Drawing.Point(17, 51);
            this.textBoxInPut_SKE.Name = "textBoxInPut_SKE";
            this.textBoxInPut_SKE.Size = new System.Drawing.Size(100, 20);
            this.textBoxInPut_SKE.TabIndex = 0;
            this.textBoxInPut_SKE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxInPut_SKE_KeyPress);
            // 
            // labelInPut_SKE
            // 
            this.labelInPut_SKE.AutoSize = true;
            this.labelInPut_SKE.Location = new System.Drawing.Point(14, 26);
            this.labelInPut_SKE.Name = "labelInPut_SKE";
            this.labelInPut_SKE.Size = new System.Drawing.Size(17, 13);
            this.labelInPut_SKE.TabIndex = 1;
            this.labelInPut_SKE.Text = "X:";
            // 
            // buttonDone_SKE
            // 
            this.buttonDone_SKE.Location = new System.Drawing.Point(250, 155);
            this.buttonDone_SKE.Name = "buttonDone_SKE";
            this.buttonDone_SKE.Size = new System.Drawing.Size(74, 58);
            this.buttonDone_SKE.TabIndex = 3;
            this.buttonDone_SKE.Text = "Вывести Результат";
            this.buttonDone_SKE.UseVisualStyleBackColor = true;
            this.buttonDone_SKE.Click += new System.EventHandler(this.buttonDone_SKE_Click);
            // 
            // groupBoxOutPut_SKE
            // 
            this.groupBoxOutPut_SKE.Controls.Add(this.labelOutPut_SKE);
            this.groupBoxOutPut_SKE.Controls.Add(this.textBoxOutPut_SKE);
            this.groupBoxOutPut_SKE.Location = new System.Drawing.Point(350, 152);
            this.groupBoxOutPut_SKE.Name = "groupBoxOutPut_SKE";
            this.groupBoxOutPut_SKE.Size = new System.Drawing.Size(126, 98);
            this.groupBoxOutPut_SKE.TabIndex = 4;
            this.groupBoxOutPut_SKE.TabStop = false;
            this.groupBoxOutPut_SKE.Text = "Результат";
            // 
            // textBoxOutPut_SKE
            // 
            this.textBoxOutPut_SKE.Location = new System.Drawing.Point(16, 51);
            this.textBoxOutPut_SKE.Name = "textBoxOutPut_SKE";
            this.textBoxOutPut_SKE.ReadOnly = true;
            this.textBoxOutPut_SKE.Size = new System.Drawing.Size(94, 20);
            this.textBoxOutPut_SKE.TabIndex = 0;
            // 
            // labelOutPut_SKE
            // 
            this.labelOutPut_SKE.AutoSize = true;
            this.labelOutPut_SKE.Location = new System.Drawing.Point(13, 26);
            this.labelOutPut_SKE.Name = "labelOutPut_SKE";
            this.labelOutPut_SKE.Size = new System.Drawing.Size(17, 13);
            this.labelOutPut_SKE.TabIndex = 1;
            this.labelOutPut_SKE.Text = "Y:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 267);
            this.Controls.Add(this.groupBoxOutPut_SKE);
            this.Controls.Add(this.buttonDone_SKE);
            this.Controls.Add(this.buttonInfo_SKE);
            this.Controls.Add(this.groupBoxInPut);
            this.Controls.Add(this.pictureBoxTask_SKE);
            this.Controls.Add(this.groupBoxTask_SKE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 20 | Шунанов К. Е.";
            this.groupBoxTask_SKE.ResumeLayout(false);
            this.groupBoxTask_SKE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTask_SKE)).EndInit();
            this.groupBoxInPut.ResumeLayout(false);
            this.groupBoxInPut.PerformLayout();
            this.groupBoxOutPut_SKE.ResumeLayout(false);
            this.groupBoxOutPut_SKE.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_SKE;
        private System.Windows.Forms.TextBox textBoxTask_SKE;
        private System.Windows.Forms.PictureBox pictureBoxTask_SKE;
        private System.Windows.Forms.GroupBox groupBoxInPut;
        private System.Windows.Forms.Label labelInPut_SKE;
        private System.Windows.Forms.TextBox textBoxInPut_SKE;
        private System.Windows.Forms.Button buttonInfo_SKE;
        private System.Windows.Forms.Button buttonDone_SKE;
        private System.Windows.Forms.GroupBox groupBoxOutPut_SKE;
        private System.Windows.Forms.Label labelOutPut_SKE;
        private System.Windows.Forms.TextBox textBoxOutPut_SKE;
    }
}

