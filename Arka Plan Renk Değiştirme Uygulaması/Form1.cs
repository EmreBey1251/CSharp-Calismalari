using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8_off
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            { this.BackColor = Color.Red; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            { this.BackColor = Color.Green; }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            { this.BackColor = Color.Blue; }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            { this.BackColor = Color.Gray; }
        }
    }
}
