using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veralunos
{
    public partial class veralunos : Form
    {
        public veralunos()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPesquisaInscrição_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisaInscrição.Text !="")
            {
                label1.Visible= false;
                Image image = image.FromFile("C:/Liberay Management System/search1.gif");
                pictureBox1.Image = image;
            }
            else
            {
                label1.Visible = true;
                Image image = image.FromFile("C:/Liberay Management System/search.gif");
                pictureBox1.Image = image;
            }
        }
    }
}
