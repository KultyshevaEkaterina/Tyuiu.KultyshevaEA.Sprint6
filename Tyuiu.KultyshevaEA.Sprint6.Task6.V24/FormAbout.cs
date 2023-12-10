using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.KultyshevaEA.Sprint6.Task6.V24
{
    public partial class FormAbout_KEA : Form
    {
        public FormAbout_KEA()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void buttonOK_KEA_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
