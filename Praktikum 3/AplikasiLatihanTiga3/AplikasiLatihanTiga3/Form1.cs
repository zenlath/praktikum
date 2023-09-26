using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiLatihanTiga3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nama = textBox1.Text;
            var pendidikan = comboBox1.Text;
            var pekerjaan = listBox1.Text;

            textBox2.Text = string.Format("Halo {0}", nama);
            textBox3.Text = string.Format("Pendidikan Anda {0} ya?", pendidikan);
            textBox4.Text = string.Format("Anda Seorang {0}, hebat!!", pekerjaan);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
