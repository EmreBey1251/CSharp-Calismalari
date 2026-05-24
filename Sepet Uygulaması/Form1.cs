using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inan_hoca_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Elma");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Armut");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Muz");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Kiraz");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Avokado");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Şeftali");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("İncir");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Karpuz");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Kavun");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Çilek");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
