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

using Tyuiu.KultyshevaEA.Sprint6.Task7.V24.Lib;

namespace Tyuiu.KultyshevaEA.Sprint6.Task7.V24
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_KEA.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Всефайлы(*.*)|*.*";
            saveFileDialog_KEA.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Всефайлы(*.*)|*.*";
        }
        static string openFile;
        static int rows;
        static int columns;
        DataService ds = new DataService();
        public int[,] LoadFromData(string path)
        {
            string file = File.ReadAllText(path);
            file = file.Replace('\n', '\r');
            string[] lines = file.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] array = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line_mas = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = Convert.ToInt32(line_mas[j]);
                }
            }
            return array;
        }


        private void buttonFile_KEA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_KEA.ShowDialog();
            openFile = openFileDialogTask_KEA.FileName;
            int[,] matrix = new int[rows, columns];
            matrix = LoadFromData(openFile);

            dataGridViewVar_KEA.RowCount = rows;
            dataGridViewVar_KEA.ColumnCount = columns;
            dataGridViewRes_KEA.RowCount = rows;
            dataGridViewRes_KEA.ColumnCount = columns;


            for (int i = 0; i < columns; i++)
            {
                dataGridViewVar_KEA.Columns[i].Width = 50;
                dataGridViewRes_KEA.Columns[i].Width = 50;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewVar_KEA.Rows[r].Cells[c].Value = matrix[r, c];
                }
            }
            matrix = ds.GetMatrix(openFile);
            buttonDone_KEA.Enabled = true;
        }

        private void buttonDone_KEA_Click(object sender, EventArgs e)
        {
            int[,] matrixNew = new int[rows, columns];
            matrixNew = ds.GetMatrix(openFile);
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewRes_KEA.Rows[r].Cells[c].Value = matrixNew[r, c];
                }
            }
            buttonFile_KEA.Enabled = true;
        }

        private void buttonSave_KEA_Click(object sender, EventArgs e)
        {
            saveFileDialog_KEA.FileName = "OutPutFileTask7.csv";
            saveFileDialog_KEA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog_KEA.ShowDialog();
            string path = saveFileDialog_KEA.FileName;
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }
            int rows = dataGridViewRes_KEA.RowCount;
            int columns = dataGridViewRes_KEA.ColumnCount;
            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewRes_KEA.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewRes_KEA.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonHelp_KEA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
