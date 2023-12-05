using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ShunanovKE.Sprint6.Task4.V24.Lib;
using System.IO;

namespace Tyuiu.ShunanovKE.Sprint6.Task4.V24
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
                int stop = Convert.ToInt32(textBoxStop_SKE.Text);
                int len = stop - start + 1;
                double[] array = ds.GetMassFunction(start, stop);

                textBoxOutPut_SKE.Text = "";
                chartFunc_SKE.Series[0].Points.Clear();
                this.chartFunc_SKE.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunc_SKE.ChartAreas[0].AxisY.Title = "Ось y";

                for (int i = 0; i < len; i++)
                {
                    textBoxOutPut_SKE.AppendText(Convert.ToString(array[i]) + Environment.NewLine);
                    chartFunc_SKE.Series[0].Points.AddXY(start, array[i]);
                    start++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_SKE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы ПКТб-23-2 Шунанов Кирилл Ерболатович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSave_SKE_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V24.txt";
                File.WriteAllText(path, textBoxOutPut_SKE.Text);

                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранен успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if(dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
