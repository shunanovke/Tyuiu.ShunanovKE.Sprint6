
namespace Tyuiu.ShunanovKE.Sprint6.Task2.V8
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxTask_SKE = new System.Windows.Forms.GroupBox();
            this.pictureBoxTask_SKE = new System.Windows.Forms.PictureBox();
            this.groupBoxInPut_SKE = new System.Windows.Forms.GroupBox();
            this.textBoxStart_SKE = new System.Windows.Forms.TextBox();
            this.textBoxEnd_SKE = new System.Windows.Forms.TextBox();
            this.labelStart_SKE = new System.Windows.Forms.Label();
            this.labelEnd_SKE = new System.Windows.Forms.Label();
            this.buttonInfo_SKE = new System.Windows.Forms.Button();
            this.buttonResult_SKE = new System.Windows.Forms.Button();
            this.groupBoxOutPut_SKE = new System.Windows.Forms.GroupBox();
            this.dataGridViewOutPut_SKE = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.func = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartOutPut_SKE = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxTask_SKE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTask_SKE)).BeginInit();
            this.groupBoxInPut_SKE.SuspendLayout();
            this.groupBoxOutPut_SKE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_SKE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOutPut_SKE)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_SKE
            // 
            this.groupBoxTask_SKE.Controls.Add(this.pictureBoxTask_SKE);
            this.groupBoxTask_SKE.Location = new System.Drawing.Point(6, 9);
            this.groupBoxTask_SKE.Name = "groupBoxTask_SKE";
            this.groupBoxTask_SKE.Size = new System.Drawing.Size(662, 244);
            this.groupBoxTask_SKE.TabIndex = 0;
            this.groupBoxTask_SKE.TabStop = false;
            this.groupBoxTask_SKE.Text = "Условие";
            // 
            // pictureBoxTask_SKE
            // 
            this.pictureBoxTask_SKE.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTask_SKE.Image")));
            this.pictureBoxTask_SKE.Location = new System.Drawing.Point(7, 25);
            this.pictureBoxTask_SKE.Name = "pictureBoxTask_SKE";
            this.pictureBoxTask_SKE.Size = new System.Drawing.Size(649, 211);
            this.pictureBoxTask_SKE.TabIndex = 0;
            this.pictureBoxTask_SKE.TabStop = false;
            // 
            // groupBoxInPut_SKE
            // 
            this.groupBoxInPut_SKE.Controls.Add(this.labelEnd_SKE);
            this.groupBoxInPut_SKE.Controls.Add(this.labelStart_SKE);
            this.groupBoxInPut_SKE.Controls.Add(this.textBoxEnd_SKE);
            this.groupBoxInPut_SKE.Controls.Add(this.textBoxStart_SKE);
            this.groupBoxInPut_SKE.Location = new System.Drawing.Point(6, 259);
            this.groupBoxInPut_SKE.Name = "groupBoxInPut_SKE";
            this.groupBoxInPut_SKE.Size = new System.Drawing.Size(444, 63);
            this.groupBoxInPut_SKE.TabIndex = 1;
            this.groupBoxInPut_SKE.TabStop = false;
            this.groupBoxInPut_SKE.Text = "Ввод Данных";
            // 
            // textBoxStart_SKE
            // 
            this.textBoxStart_SKE.Location = new System.Drawing.Point(7, 37);
            this.textBoxStart_SKE.Name = "textBoxStart_SKE";
            this.textBoxStart_SKE.Size = new System.Drawing.Size(100, 20);
            this.textBoxStart_SKE.TabIndex = 0;
            // 
            // textBoxEnd_SKE
            // 
            this.textBoxEnd_SKE.Location = new System.Drawing.Point(210, 37);
            this.textBoxEnd_SKE.Name = "textBoxEnd_SKE";
            this.textBoxEnd_SKE.Size = new System.Drawing.Size(100, 20);
            this.textBoxEnd_SKE.TabIndex = 0;
            // 
            // labelStart_SKE
            // 
            this.labelStart_SKE.AutoSize = true;
            this.labelStart_SKE.Location = new System.Drawing.Point(6, 21);
            this.labelStart_SKE.Name = "labelStart_SKE";
            this.labelStart_SKE.Size = new System.Drawing.Size(64, 13);
            this.labelStart_SKE.TabIndex = 1;
            this.labelStart_SKE.Text = "Старт шага";
            // 
            // labelEnd_SKE
            // 
            this.labelEnd_SKE.AutoSize = true;
            this.labelEnd_SKE.Location = new System.Drawing.Point(207, 21);
            this.labelEnd_SKE.Name = "labelEnd_SKE";
            this.labelEnd_SKE.Size = new System.Drawing.Size(66, 13);
            this.labelEnd_SKE.TabIndex = 1;
            this.labelEnd_SKE.Text = "Конец шага";
            // 
            // buttonInfo_SKE
            // 
            this.buttonInfo_SKE.BackColor = System.Drawing.Color.LightBlue;
            this.buttonInfo_SKE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInfo_SKE.Location = new System.Drawing.Point(472, 259);
            this.buttonInfo_SKE.Name = "buttonInfo_SKE";
            this.buttonInfo_SKE.Size = new System.Drawing.Size(77, 63);
            this.buttonInfo_SKE.TabIndex = 2;
            this.buttonInfo_SKE.Text = "Справка";
            this.buttonInfo_SKE.UseVisualStyleBackColor = false;
            this.buttonInfo_SKE.Click += new System.EventHandler(this.buttonInfo_SKE_Click);
            // 
            // buttonResult_SKE
            // 
            this.buttonResult_SKE.BackColor = System.Drawing.Color.LightGreen;
            this.buttonResult_SKE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResult_SKE.Location = new System.Drawing.Point(570, 259);
            this.buttonResult_SKE.Name = "buttonResult_SKE";
            this.buttonResult_SKE.Size = new System.Drawing.Size(81, 63);
            this.buttonResult_SKE.TabIndex = 2;
            this.buttonResult_SKE.Text = "Результат";
            this.buttonResult_SKE.UseVisualStyleBackColor = false;
            this.buttonResult_SKE.Click += new System.EventHandler(this.buttonResult_SKE_Click);
            this.buttonResult_SKE.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonResult_SKE_MouseDown);
            this.buttonResult_SKE.MouseEnter += new System.EventHandler(this.buttonResult_SKE_MouseEnter);
            this.buttonResult_SKE.MouseLeave += new System.EventHandler(this.buttonResult_SKE_MouseLeave);
            // 
            // groupBoxOutPut_SKE
            // 
            this.groupBoxOutPut_SKE.Controls.Add(this.chartOutPut_SKE);
            this.groupBoxOutPut_SKE.Controls.Add(this.dataGridViewOutPut_SKE);
            this.groupBoxOutPut_SKE.Location = new System.Drawing.Point(674, 18);
            this.groupBoxOutPut_SKE.Name = "groupBoxOutPut_SKE";
            this.groupBoxOutPut_SKE.Size = new System.Drawing.Size(580, 304);
            this.groupBoxOutPut_SKE.TabIndex = 3;
            this.groupBoxOutPut_SKE.TabStop = false;
            this.groupBoxOutPut_SKE.Text = "Вывод Данных";
            // 
            // dataGridViewOutPut_SKE
            // 
            this.dataGridViewOutPut_SKE.AllowDrop = true;
            this.dataGridViewOutPut_SKE.AllowUserToOrderColumns = true;
            this.dataGridViewOutPut_SKE.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewOutPut_SKE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutPut_SKE.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.func});
            this.dataGridViewOutPut_SKE.Location = new System.Drawing.Point(14, 27);
            this.dataGridViewOutPut_SKE.Name = "dataGridViewOutPut_SKE";
            this.dataGridViewOutPut_SKE.ReadOnly = true;
            this.dataGridViewOutPut_SKE.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewOutPut_SKE.RowHeadersVisible = false;
            this.dataGridViewOutPut_SKE.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewOutPut_SKE.Size = new System.Drawing.Size(104, 270);
            this.dataGridViewOutPut_SKE.TabIndex = 0;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.ReadOnly = true;
            this.X.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.X.Width = 50;
            // 
            // func
            // 
            this.func.HeaderText = "F(X)";
            this.func.Name = "func";
            this.func.ReadOnly = true;
            this.func.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.func.Width = 50;
            // 
            // chartOutPut_SKE
            // 
            chartArea5.Name = "ChartArea1";
            this.chartOutPut_SKE.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartOutPut_SKE.Legends.Add(legend5);
            this.chartOutPut_SKE.Location = new System.Drawing.Point(134, 27);
            this.chartOutPut_SKE.Name = "chartOutPut_SKE";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.IsVisibleInLegend = false;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartOutPut_SKE.Series.Add(series5);
            this.chartOutPut_SKE.Size = new System.Drawing.Size(425, 270);
            this.chartOutPut_SKE.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 331);
            this.Controls.Add(this.groupBoxOutPut_SKE);
            this.Controls.Add(this.buttonResult_SKE);
            this.Controls.Add(this.buttonInfo_SKE);
            this.Controls.Add(this.groupBoxInPut_SKE);
            this.Controls.Add(this.groupBoxTask_SKE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 8 | Шунанов К. Е.";
            this.groupBoxTask_SKE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTask_SKE)).EndInit();
            this.groupBoxInPut_SKE.ResumeLayout(false);
            this.groupBoxInPut_SKE.PerformLayout();
            this.groupBoxOutPut_SKE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_SKE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOutPut_SKE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_SKE;
        private System.Windows.Forms.PictureBox pictureBoxTask_SKE;
        private System.Windows.Forms.GroupBox groupBoxInPut_SKE;
        private System.Windows.Forms.Label labelEnd_SKE;
        private System.Windows.Forms.Label labelStart_SKE;
        private System.Windows.Forms.TextBox textBoxEnd_SKE;
        private System.Windows.Forms.TextBox textBoxStart_SKE;
        private System.Windows.Forms.Button buttonInfo_SKE;
        private System.Windows.Forms.Button buttonResult_SKE;
        private System.Windows.Forms.GroupBox groupBoxOutPut_SKE;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOutPut_SKE;
        private System.Windows.Forms.DataGridView dataGridViewOutPut_SKE;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn func;
    }
}

