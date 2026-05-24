using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inan_hoca_ör_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            a = Convert.ToInt32(textBox1.Text);
                if (a == 2 || a == 3 || a == 5 || a == 7)
                {
                    MessageBox.Show("Asal");
                }
                else if (a % 2 == 0 || a % 3 == 0 || a % 5 == 0 || a % 7 == 0)
                {
                    MessageBox.Show("Asal Değil!");
                }
               else
               {
                MessageBox.Show("Asal");
               }
        }
    }
}
