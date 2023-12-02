using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.KultyshevaEA.Sprint6.Task0.V8.Lib;

namespace Tyuiu.KultyshevaEA.Sprint6.Task0.V8
{
    public partial class FormName_KEA : Form
    {
        public FormName_KEA()
        {
            InitializeComponent();
        }


        private void buttonDone_KEA_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_KEA.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarX_KEA.Text)));

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_KEA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнила студентка группы ИИПб-23-3 Култышева Екатерина Александровна ", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void textBoxVarX_KEA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void groupBoxOutput_KEA_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxTask_KEA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
