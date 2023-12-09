using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.ShunanovKE.Sprint6.Task7.V18.Lib;


namespace Tyuiu.ShunanovKE.Sprint6.Task7.V18
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogFile_SKE.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_SKE.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        string path;
        int rows, cols;
        int[,] mtrx;
        DataService ds = new DataService();
        private void buttonLoadFile_SKE_Click(object sender, EventArgs e)
        {
            openFileDialogFile_SKE.ShowDialog();
            path = openFileDialogFile_SKE.FileName;

            mtrx = ds.GetMatrix(path);
            rows = mtrx.GetUpperBound(0) + 1;
            cols = mtrx.Length / rows;

            dataGridViewIn_SKE.ColumnCount = cols;
            dataGridViewIn_SKE.RowCount = rows;
            dataGridViewOut_SKE.ColumnCount = cols;
            dataGridViewOut_SKE.RowCount = rows;

            for(int i = 0; i < cols; i++)
            {
                dataGridViewIn_SKE.Columns[i].Width = 25;
                dataGridViewOut_SKE.Columns[i].Width = 25;
            }

            for(int r = 0; r < rows; r++)
            {
                for(int c = 0; c < cols; c++)
                {
                    dataGridViewIn_SKE.Rows[r].Cells[c].Value = mtrx[r, c];
                }
            }

            buttonDone_SKE.Enabled = true;
        }

        private void buttonFile_SKE_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_SKE.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_SKE.InitialDirectory = Directory.GetCurrentDirectory();
            string outPath = saveFileDialogMatrix_SKE.FileName;

            FileInfo fileinfo = new FileInfo(outPath);
            bool fileex = fileinfo.Exists;
            if (fileex)
            {
                File.Delete(outPath);
            }
            saveFileDialogMatrix_SKE.ShowDialog();

            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if ( j != cols - 1)
                    {
                        str += dataGridViewOut_SKE.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewOut_SKE.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(outPath, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonInfo_SKE_Click(object sender, EventArgs e)
        {
            FormAbout formabout = new FormAbout();
            formabout.ShowDialog();
        }

        private void buttonDone_SKE_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if(j == 8)
                    {
                        dataGridViewOut_SKE.Rows[i].Cells[j].Value = 11;
                        mtrx[i, j] = 11;
                    }
                    else
                    {
                        dataGridViewOut_SKE.Rows[i].Cells[j].Value = mtrx[i, j];
                    }
                }
            }
            buttonFile_SKE.Enabled = true;
        }
    }
}
