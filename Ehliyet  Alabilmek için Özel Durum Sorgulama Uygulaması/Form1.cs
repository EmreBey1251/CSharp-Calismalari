using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hoca_ör_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            i = Convert.ToInt32(textBox1.Text);
            if (i == 18 && radioButton1.Checked == true & checkBox2.Checked == true) 
            {
                MessageBox.Show("Askerlik görevinizi yapmanız gerek.");
            }
            else if (i == 18 && radioButton1.Checked == true & checkBox1.Checked == true)
            {
                MessageBox.Show("Askerlik yapamazsınız, özel durumunuz var.");
            }
            else if (i > 18 && radioButton1.Checked == true & checkBox2.Checked == true)
            {
                MessageBox.Show("Ehliyet alabilirsiniz.");
            }
            else if (i > 18 && radioButton1.Checked == true & checkBox1.Checked == true)
            {
                MessageBox.Show("Ehliyet alamazsınız, özel durumunuz var.");
            }
            else if (i >= 18 && radioButton2.Checked == true & checkBox2.Checked == true)
            {
                MessageBox.Show("Ehliyet alabilecek yaştasınız.");
            }
            else if (i >= 18 && radioButton2.Checked == true & checkBox1.Checked == true)
            {
                MessageBox.Show("Ehliyet alamazsınız özel durumunuz var.");
            }
            else if (i < 18)
            {
                MessageBox.Show("Daha yaşınız küçük.");
            }
            else if (i >= 18)
            {
                MessageBox.Show("Yaşınız büyük.");
            }
            else
            {
                MessageBox.Show("Yorum yok.");
            }
        }
    }
}
