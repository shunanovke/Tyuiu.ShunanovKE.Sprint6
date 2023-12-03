
namespace Tyuiu.ShunanovKE.Sprint6.Task3.V28
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
            this.dataGridViewTask_SKE = new System.Windows.Forms.DataGridView();
            this.textBoxTask_SKE = new System.Windows.Forms.TextBox();
            this.groupBoxOutPut_SKE = new System.Windows.Forms.GroupBox();
            this.dataGridViewOutPut_SKE = new System.Windows.Forms.DataGridView();
            this.buttonResult_SKE = new System.Windows.Forms.Button();
            this.buttonInfo_SKE = new System.Windows.Forms.Button();
            this.groupBoxTask_SKE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTask_SKE)).BeginInit();
            this.groupBoxOutPut_SKE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_SKE)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_SKE
            // 
            this.groupBoxTask_SKE.Controls.Add(this.textBoxTask_SKE);
            this.groupBoxTask_SKE.Controls.Add(this.dataGridViewTask_SKE);
            this.groupBoxTask_SKE.Location = new System.Drawing.Point(8, 9);
            this.groupBoxTask_SKE.Name = "groupBoxTask_SKE";
            this.groupBoxTask_SKE.Size = new System.Drawing.Size(398, 189);
            this.groupBoxTask_SKE.TabIndex = 0;
            this.groupBoxTask_SKE.TabStop = false;
            this.groupBoxTask_SKE.Text = "Условие";
            // 
            // dataGridViewTask_SKE
            // 
            this.dataGridViewTask_SKE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTask_SKE.ColumnHeadersVisible = false;
            this.dataGridViewTask_SKE.Location = new System.Drawing.Point(218, 19);
            this.dataGridViewTask_SKE.Name = "dataGridViewTask_SKE";
            this.dataGridViewTask_SKE.ReadOnly = true;
            this.dataGridViewTask_SKE.RowHeadersVisible = false;
            this.dataGridViewTask_SKE.Size = new System.Drawing.Size(174, 156);
            this.dataGridViewTask_SKE.TabIndex = 0;
            // 
            // textBoxTask_SKE
            // 
            this.textBoxTask_SKE.Location = new System.Drawing.Point(13, 19);
            this.textBoxTask_SKE.Multiline = true;
            this.textBoxTask_SKE.Name = "textBoxTask_SKE";
            this.textBoxTask_SKE.ReadOnly = true;
            this.textBoxTask_SKE.Size = new System.Drawing.Size(199, 156);
            this.textBoxTask_SKE.TabIndex = 1;
            this.textBoxTask_SKE.Text = resources.GetString("textBoxTask_SKE.Text");
            // 
            // groupBoxOutPut_SKE
            // 
            this.groupBoxOutPut_SKE.Controls.Add(this.dataGridViewOutPut_SKE);
            this.groupBoxOutPut_SKE.Location = new System.Drawing.Point(532, 9);
            this.groupBoxOutPut_SKE.Name = "groupBoxOutPut_SKE";
            this.groupBoxOutPut_SKE.Size = new System.Drawing.Size(191, 189);
            this.groupBoxOutPut_SKE.TabIndex = 1;
            this.groupBoxOutPut_SKE.TabStop = false;
            this.groupBoxOutPut_SKE.Text = "Вывод Данных";
            // 
            // dataGridViewOutPut_SKE
            // 
            this.dataGridViewOutPut_SKE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutPut_SKE.ColumnHeadersVisible = false;
            this.dataGridViewOutPut_SKE.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewOutPut_SKE.Name = "dataGridViewOutPut_SKE";
            this.dataGridViewOutPut_SKE.ReadOnly = true;
            this.dataGridViewOutPut_SKE.RowHeadersVisible = false;
            this.dataGridViewOutPut_SKE.Size = new System.Drawing.Size(179, 156);
            this.dataGridViewOutPut_SKE.TabIndex = 0;
            // 
            // buttonResult_SKE
            // 
            this.buttonResult_SKE.Location = new System.Drawing.Point(412, 74);
            this.buttonResult_SKE.Name = "buttonResult_SKE";
            this.buttonResult_SKE.Size = new System.Drawing.Size(114, 58);
            this.buttonResult_SKE.TabIndex = 2;
            this.buttonResult_SKE.Text = "Выполнить";
            this.buttonResult_SKE.UseVisualStyleBackColor = true;
            this.buttonResult_SKE.Click += new System.EventHandler(this.buttonResult_SKE_Click);
            // 
            // buttonInfo_SKE
            // 
            this.buttonInfo_SKE.Location = new System.Drawing.Point(433, 138);
            this.buttonInfo_SKE.Name = "buttonInfo_SKE";
            this.buttonInfo_SKE.Size = new System.Drawing.Size(75, 23);
            this.buttonInfo_SKE.TabIndex = 3;
            this.buttonInfo_SKE.Text = "Справка";
            this.buttonInfo_SKE.UseVisualStyleBackColor = true;
            this.buttonInfo_SKE.Click += new System.EventHandler(this.buttonInfo_SKE_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 208);
            this.Controls.Add(this.buttonInfo_SKE);
            this.Controls.Add(this.buttonResult_SKE);
            this.Controls.Add(this.groupBoxOutPut_SKE);
            this.Controls.Add(this.groupBoxTask_SKE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 28 | Шунанов К. Е.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask_SKE.ResumeLayout(false);
            this.groupBoxTask_SKE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTask_SKE)).EndInit();
            this.groupBoxOutPut_SKE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_SKE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_SKE;
        private System.Windows.Forms.TextBox textBoxTask_SKE;
        private System.Windows.Forms.DataGridView dataGridViewTask_SKE;
        private System.Windows.Forms.GroupBox groupBoxOutPut_SKE;
        private System.Windows.Forms.DataGridView dataGridViewOutPut_SKE;
        private System.Windows.Forms.Button buttonResult_SKE;
        private System.Windows.Forms.Button buttonInfo_SKE;
    }
}

