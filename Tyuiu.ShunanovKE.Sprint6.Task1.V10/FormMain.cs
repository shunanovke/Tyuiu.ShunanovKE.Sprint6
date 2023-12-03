using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ShunanovKE.Sprint6.Task1.V10.Lib;

namespace Tyuiu.ShunanovKE.Sprint6.Task1.V10
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
                int start = Convert.ToInt32(textBoxStart_SKE.Text);
                int end = Convert.ToInt32(textBoxEnd_SKE.Text);

                string strLine;

                int len = ds.GetMassFunction(start, end).Length;

                double[] res = new double[len];
                res = ds.GetMassFunction(start, end);
                
                textBoxOutPut_SKE.Text = "";
                textBoxOutPut_SKE.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxOutPut_SKE.AppendText("+    x     +   f(x)   +" + Environment.NewLine);
                textBoxOutPut_SKE.AppendText("+----------+----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     |  {1, 6:f2}  |", start, res[i]);
                    textBoxOutPut_SKE.AppendText(strLine + Environment.NewLine);
                    start++;
                }
                textBoxOutPut_SKE.AppendText("+----------+----------+");
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_SKE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск1 выполнил студент группы ПКТб-23-2 Шунанов Кирилл Ерболатович", "Сообщение");
        }
    }
}
