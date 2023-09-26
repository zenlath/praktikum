using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appTugas3._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "NIM   : 22.11.4755";
            label2.Text = "Nama  : Yusma Zainal L";
            label3.Text = "Kelas : IF4";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "NIM   :";
            label2.Text = "Nama  :";
            label3.Text = "Kelas :";
        }
    }
}
