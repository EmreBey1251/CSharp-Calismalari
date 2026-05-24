using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hoca_ör_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {  //Random sayı oluşturuyoruz 100'e kadar
            Random random = new Random(100);
            for (int i = 1; i < 100; i++) //100'e kadar olan sayılara bakıcaz
            {
                int b = i % 3;
                if(b % 3 == 0)//bölünüyorsa listbox a ekliyecez, bölünmüyorsa da eklemiyecez
                {
                    listBox1.Items.Add(i);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int j = 1; j < 100; j++) 
            { 
             if (j % 7 == 0)
             {
                    listBox2.Items.Add(j);
             }
            }
        }
    }
}
