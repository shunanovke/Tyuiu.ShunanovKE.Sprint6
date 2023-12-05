using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ShunanovKE.Sprint6.Task5.V22.Lib;

namespace Tyuiu.ShunanovKE.Sprint6.Task5.V22
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\DataSprint6\InPutFileTask5V22.txt";
        private void buttonResult_SKE_Click(object sender, EventArgs e)
        {
            dataGridViewOutPut_SKE.ColumnCount = 2;
            dataGridViewOutPut_SKE.Columns[0].Width = 20;
            dataGridViewOutPut_SKE.Columns[1].Width = 50;

            this.chartGraph_SKE.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartGraph_SKE.ChartAreas[0].AxisY.Title = "Ось Y";

            chartGraph_SKE.Series[0].Points.Clear();
            double[] array = ds.LoadFromDataFile(path);

            for(int i = 0; i < array.Length; i++)
            {
                dataGridViewOutPut_SKE.Rows.Add(Convert.ToString(i), Convert.ToString(array[i]));
                chartGraph_SKE.Series[0].Points.AddXY(i, array[i]);
            }
        }

        private void buttonShow_SKE_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonInfo_SKE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ПКТб-23-2 Шунанов Кирилл Ерболатович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
