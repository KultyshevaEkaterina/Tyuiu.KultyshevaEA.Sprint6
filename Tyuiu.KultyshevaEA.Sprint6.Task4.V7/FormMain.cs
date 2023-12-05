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

using Tyuiu.KultyshevaEA.Sprint6.Task4.V7.Lib;

namespace Tyuiu.KultyshevaEA.Sprint6.Task4.V7
{
    public partial class FormMain : Form
    {

        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнила студентка группы ИИПБ-23-3 Култышева Екатерина Александровна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDone_KEA_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxStartStep_KEA.Text);
                int stopValue = Convert.ToInt32(textBoxStopStep_KEA.Text);
                int len = ds.GetMassFunction(startValue, stopValue).Length;
                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startValue, stopValue);


                this.chartResult_KEA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartResult_KEA.ChartAreas[0].AxisX.Title = "Ось Y";
                textBoxResult_KEA.Text = "";

                chartResult_KEA.Series[0].Points.Clear();
                for (int i = 0; i < len - 1; i++)
                {
                    this.chartResult_KEA.Series[0].Points.AddXY(startValue, valueArray[i]);
                    textBoxResult_KEA.AppendText(valueArray[i] + Environment.NewLine);
                    startValue++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_KEA_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V7.txt";
                File.WriteAllText(path, textBoxResult_KEA.Text);
                DialogResult dialogResult = MessageBox.Show("Файл" + path + "сохранен успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
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
   
