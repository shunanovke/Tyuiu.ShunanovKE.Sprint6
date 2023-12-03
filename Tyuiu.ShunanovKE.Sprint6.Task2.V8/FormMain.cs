using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ShunanovKE.Sprint6.Task2.V8.Lib;

namespace Tyuiu.ShunanovKE.Sprint6.Task2.V8
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonResult_SKE_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBoxStart_SKE.Text), end = Convert.ToInt32(textBoxEnd_SKE.Text);
                double[] res = ds.GetMassFunction(start, end);
                int len = res.Length;

                this.dataGridViewOutPut_SKE.Rows.Clear();
                this.chartOutPut_SKE.Series[0].Points.Clear();
                this.chartOutPut_SKE.Titles.Clear();

                this.chartOutPut_SKE.Titles.Add("График функции");
                this.chartOutPut_SKE.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartOutPut_SKE.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i < len; i++)
                {
                    this.dataGridViewOutPut_SKE.Rows.Add(Convert.ToString(start), res[i]);
                    this.chartOutPut_SKE.Series[0].Points.AddXY(start, res[i]);
                    start++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonResult_SKE_MouseEnter(object sender, EventArgs e)
        {
            buttonResult_SKE.BackColor = Color.DarkGreen;
        }

        private void buttonResult_SKE_MouseLeave(object sender, EventArgs e)
        {
            buttonResult_SKE.BackColor = Color.LightGreen;
        }

        private void buttonResult_SKE_MouseDown(object sender, MouseEventArgs e)
        {
            buttonResult_SKE.BackColor = Color.Red;
        }

        private void buttonInfo_SKE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ПКТб-23-2 Шунанов Кирилл Ерболатович", "Сообщение");
        }
    }
}
