
namespace Tyuiu.ShunanovKE.Sprint6.Task5.V22
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelUp_SKE = new System.Windows.Forms.Panel();
            this.buttonInfo_SKE = new System.Windows.Forms.Button();
            this.buttonShow_SKE = new System.Windows.Forms.Button();
            this.buttonResult_SKE = new System.Windows.Forms.Button();
            this.groupBoxTask_SKE = new System.Windows.Forms.GroupBox();
            this.textBoxTask_SKE = new System.Windows.Forms.TextBox();
            this.panelLeft_SKE = new System.Windows.Forms.Panel();
            this.groupBoxOutPut_SKE = new System.Windows.Forms.GroupBox();
            this.dataGridViewOutPut_SKE = new System.Windows.Forms.DataGridView();
            this.panelGraph_SKE = new System.Windows.Forms.Panel();
            this.chartGraph_SKE = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelUp_SKE.SuspendLayout();
            this.groupBoxTask_SKE.SuspendLayout();
            this.panelLeft_SKE.SuspendLayout();
            this.groupBoxOutPut_SKE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_SKE)).BeginInit();
            this.panelGraph_SKE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraph_SKE)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUp_SKE
            // 
            this.panelUp_SKE.Controls.Add(this.buttonInfo_SKE);
            this.panelUp_SKE.Controls.Add(this.buttonShow_SKE);
            this.panelUp_SKE.Controls.Add(this.buttonResult_SKE);
            this.panelUp_SKE.Controls.Add(this.groupBoxTask_SKE);
            this.panelUp_SKE.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUp_SKE.Location = new System.Drawing.Point(0, 0);
            this.panelUp_SKE.Name = "panelUp_SKE";
            this.panelUp_SKE.Size = new System.Drawing.Size(634, 94);
            this.panelUp_SKE.TabIndex = 0;
            // 
            // buttonInfo_SKE
            // 
            this.buttonInfo_SKE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_SKE.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonInfo_SKE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInfo_SKE.Location = new System.Drawing.Point(554, 16);
            this.buttonInfo_SKE.Name = "buttonInfo_SKE";
            this.buttonInfo_SKE.Size = new System.Drawing.Size(70, 59);
            this.buttonInfo_SKE.TabIndex = 1;
            this.buttonInfo_SKE.Text = "Справка";
            this.buttonInfo_SKE.UseVisualStyleBackColor = false;
            this.buttonInfo_SKE.Click += new System.EventHandler(this.buttonInfo_SKE_Click);
            // 
            // buttonShow_SKE
            // 
            this.buttonShow_SKE.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonShow_SKE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShow_SKE.Location = new System.Drawing.Point(453, 16);
            this.buttonShow_SKE.Name = "buttonShow_SKE";
            this.buttonShow_SKE.Size = new System.Drawing.Size(70, 59);
            this.buttonShow_SKE.TabIndex = 1;
            this.buttonShow_SKE.Text = "Открыть файл";
            this.buttonShow_SKE.UseVisualStyleBackColor = false;
            this.buttonShow_SKE.Click += new System.EventHandler(this.buttonShow_SKE_Click);
            // 
            // buttonResult_SKE
            // 
            this.buttonResult_SKE.BackColor = System.Drawing.Color.LightGreen;
            this.buttonResult_SKE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResult_SKE.Location = new System.Drawing.Point(377, 16);
            this.buttonResult_SKE.Name = "buttonResult_SKE";
            this.buttonResult_SKE.Size = new System.Drawing.Size(70, 59);
            this.buttonResult_SKE.TabIndex = 1;
            this.buttonResult_SKE.Text = "Результат";
            this.buttonResult_SKE.UseVisualStyleBackColor = false;
            this.buttonResult_SKE.Click += new System.EventHandler(this.buttonResult_SKE_Click);
            // 
            // groupBoxTask_SKE
            // 
            this.groupBoxTask_SKE.Controls.Add(this.textBoxTask_SKE);
            this.groupBoxTask_SKE.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxTask_SKE.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTask_SKE.Name = "groupBoxTask_SKE";
            this.groupBoxTask_SKE.Size = new System.Drawing.Size(371, 94);
            this.groupBoxTask_SKE.TabIndex = 0;
            this.groupBoxTask_SKE.TabStop = false;
            this.groupBoxTask_SKE.Text = "Условие";
            // 
            // textBoxTask_SKE
            // 
            this.textBoxTask_SKE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTask_SKE.Location = new System.Drawing.Point(3, 16);
            this.textBoxTask_SKE.Multiline = true;
            this.textBoxTask_SKE.Name = "textBoxTask_SKE";
            this.textBoxTask_SKE.ReadOnly = true;
            this.textBoxTask_SKE.Size = new System.Drawing.Size(365, 75);
            this.textBoxTask_SKE.TabIndex = 0;
            this.textBoxTask_SKE.Text = resources.GetString("textBoxTask_SKE.Text");
            // 
            // panelLeft_SKE
            // 
            this.panelLeft_SKE.Controls.Add(this.groupBoxOutPut_SKE);
            this.panelLeft_SKE.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_SKE.Location = new System.Drawing.Point(0, 94);
            this.panelLeft_SKE.Name = "panelLeft_SKE";
            this.panelLeft_SKE.Size = new System.Drawing.Size(174, 308);
            this.panelLeft_SKE.TabIndex = 1;
            // 
            // groupBoxOutPut_SKE
            // 
            this.groupBoxOutPut_SKE.Controls.Add(this.dataGridViewOutPut_SKE);
            this.groupBoxOutPut_SKE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPut_SKE.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutPut_SKE.Name = "groupBoxOutPut_SKE";
            this.groupBoxOutPut_SKE.Size = new System.Drawing.Size(174, 308);
            this.groupBoxOutPut_SKE.TabIndex = 0;
            this.groupBoxOutPut_SKE.TabStop = false;
            this.groupBoxOutPut_SKE.Text = "Вывод данных";
            // 
            // dataGridViewOutPut_SKE
            // 
            this.dataGridViewOutPut_SKE.AllowUserToResizeColumns = false;
            this.dataGridViewOutPut_SKE.AllowUserToResizeRows = false;
            this.dataGridViewOutPut_SKE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutPut_SKE.ColumnHeadersVisible = false;
            this.dataGridViewOutPut_SKE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOutPut_SKE.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewOutPut_SKE.Name = "dataGridViewOutPut_SKE";
            this.dataGridViewOutPut_SKE.ReadOnly = true;
            this.dataGridViewOutPut_SKE.RowHeadersVisible = false;
            this.dataGridViewOutPut_SKE.Size = new System.Drawing.Size(168, 289);
            this.dataGridViewOutPut_SKE.TabIndex = 0;
            // 
            // panelGraph_SKE
            // 
            this.panelGraph_SKE.Controls.Add(this.chartGraph_SKE);
            this.panelGraph_SKE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGraph_SKE.Location = new System.Drawing.Point(174, 94);
            this.panelGraph_SKE.Name = "panelGraph_SKE";
            this.panelGraph_SKE.Size = new System.Drawing.Size(460, 308);
            this.panelGraph_SKE.TabIndex = 2;
            // 
            // chartGraph_SKE
            // 
            chartArea3.Name = "ChartArea1";
            this.chartGraph_SKE.ChartAreas.Add(chartArea3);
            this.chartGraph_SKE.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.chartGraph_SKE.Legends.Add(legend3);
            this.chartGraph_SKE.Location = new System.Drawing.Point(0, 0);
            this.chartGraph_SKE.Name = "chartGraph_SKE";
            series3.ChartArea = "ChartArea1";
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartGraph_SKE.Series.Add(series3);
            this.chartGraph_SKE.Size = new System.Drawing.Size(460, 308);
            this.chartGraph_SKE.TabIndex = 0;
            this.chartGraph_SKE.Text = "chart1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 402);
            this.Controls.Add(this.panelGraph_SKE);
            this.Controls.Add(this.panelLeft_SKE);
            this.Controls.Add(this.panelUp_SKE);
            this.MinimumSize = new System.Drawing.Size(650, 440);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 22 | Шунанов К. Е.";
            this.panelUp_SKE.ResumeLayout(false);
            this.groupBoxTask_SKE.ResumeLayout(false);
            this.groupBoxTask_SKE.PerformLayout();
            this.panelLeft_SKE.ResumeLayout(false);
            this.groupBoxOutPut_SKE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_SKE)).EndInit();
            this.panelGraph_SKE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartGraph_SKE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUp_SKE;
        private System.Windows.Forms.Button buttonInfo_SKE;
        private System.Windows.Forms.Button buttonShow_SKE;
        private System.Windows.Forms.Button buttonResult_SKE;
        private System.Windows.Forms.GroupBox groupBoxTask_SKE;
        private System.Windows.Forms.TextBox textBoxTask_SKE;
        private System.Windows.Forms.Panel panelLeft_SKE;
        private System.Windows.Forms.GroupBox groupBoxOutPut_SKE;
        private System.Windows.Forms.DataGridView dataGridViewOutPut_SKE;
        private System.Windows.Forms.Panel panelGraph_SKE;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGraph_SKE;
    }
}

