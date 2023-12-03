using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ShunanovKE.Sprint6.Task3.V28.Lib;

namespace Tyuiu.ShunanovKE.Sprint6.Task3.V28
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] mtrx = { {-9, 8, 9, 16, -18},
                        {-13, -11, -20, -15, 9},
                        {18, 13, -12, -15, -11},
                        {10, -2, 19, -4, -10},
                        {6, -20, -4, 13, -14}};
        private void buttonResult_SKE_Click(object sender, EventArgs e)
        {
            int[,] res = ds.Calculate(mtrx);
            int rows = mtrx.GetUpperBound(0) + 1, cols = mtrx.Length / rows;

            dataGridViewOutPut_SKE.ColumnCount = cols;
            dataGridViewOutPut_SKE.RowCount = rows;
            for (int i = 0; i < rows; i++)
            {
                dataGridViewOutPut_SKE.Columns[i].Width = 25;
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewOutPut_SKE.Rows[i].Cells[j].Value = Convert.ToString(res[i, j]);
                }
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1, cols = mtrx.Length / rows;

            dataGridViewTask_SKE.ColumnCount = cols;
            dataGridViewTask_SKE.RowCount = rows;
            for (int i = 0; i < rows; i++)
            {
                dataGridViewTask_SKE.Columns[i].Width = 25;
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewTask_SKE.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }

        }

        private void buttonInfo_SKE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ПКТб-23-2 Шунанов Кирилл Ерболатович", "Сообщение");
        }
    }
}
