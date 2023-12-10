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

using Tyuiu.KultyshevaEA.Sprint6.Task6.V24.Lib;

namespace Tyuiu.KultyshevaEA.Sprint6.Task6.V24
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            buttonDone_KEA.Enabled = false;
        }
        DataService ds = new DataService();
        string path = @"C:\DataSprint6\InPutFileTask6V24.txt";

        private void buttonFile_KEA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_KEA.ShowDialog();
            path = openFileDialogTask_KEA.FileName;
            textBoxIn_KEA.Text = File.ReadAllText(path);
            groupBoxVar_KEA.Text = groupBoxVar_KEA.Text + " " + openFileDialogTask_KEA.FileName;
            buttonDone_KEA.Enabled = true;

            

        }

        private void openFileDialogTask_KEA_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void buttonDone_KEA_Click(object sender, EventArgs e)
        {
            textBoxOut_KEA.Text = ds.CollectTextFromFile(path);
        }

        private void buttonHelp_KEA_Click(object sender, EventArgs e)
        {
            FormAbout_KEA formAbout = new FormAbout_KEA();
            formAbout.ShowDialog();
        }
    }
}
