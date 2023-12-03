using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using Tyuiu.KultyshevaEA.Sprint6.Task3.V12.Lib;

namespace Tyuiu.KultyshevaEA.Sprint6.Task3.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        int[,] mas2 = new int[5, 5] {
            { -6, -13, -1, -7, 10 },
            { 14, -18, 18, 1, 11 },
            { -2, -17, -15, -10, -8 },
            { 19, -4, -6, -11, 8 },
            { -17, 17, 14, 13, 19 }
        };
        private void dataGridViewMtrx_KEA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mas2.GetLength(0);
            int columns = mas2.GetLength(1);

            dataGridViewMTRX_KEA.ColumnCount = columns;
            dataGridViewMTRX_KEA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMTRX_KEA.Columns[i].Width = 45;
            }

            for (int i = 0; i < rows; i++)
            {
                dataGridViewMTRX_KEA.Rows[i].Height = 45;
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMTRX_KEA.Rows[i].Cells[j].Value = Convert.ToString(mas2[i, j]);
                }
            }
        }

        private void buttonDone_KEA_Click(object sender, EventArgs e)
        {
            int[,] array = ds.Calculate(mas2);
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);
            Result_KEA.ColumnCount = columns;
            Result_KEA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                Result_KEA.Columns[i].Width = 45;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Result_KEA.Rows[i].Cells[j].Value = mas2[i, j];
                }
            }
        }

        private void buttonInfo_KEA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнила студентка группы ИИПб-23-3 Култышева Екатерина Александровна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
