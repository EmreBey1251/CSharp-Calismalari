using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hoca_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double baslangic;
            baslangic = 10000;
         
            if (radioButton1.Checked == true)
            {
                baslangic += 2500;
            }
            else if (radioButton2.Checked == true)
            {
                baslangic -= 3000;
            }
        
            if (radioButton3.Checked == true)
            {
                baslangic += 1000;
            }
            else if (radioButton4.Checked == true)
            {
                baslangic -= 1500;
            }
      
            if (radioButton5.Checked == true)
            {
                baslangic -= 750;
            }       
            else if (radioButton6.Checked == true)
            {
                baslangic += 150;
            }        
                    
            if (radioButton7.Checked == true)
            {
                baslangic += 50000;
            }        
            else if (radioButton8.Checked == true)
            {
                baslangic -= 2300;
            }        
                    
            if (radioButton9.Checked == true)
            {
                baslangic -= 450;
            }
            else if (radioButton10.Checked == true)
            {
                baslangic += 170;
            }
            textBox1.Text=baslangic.ToString()+" TL";
            baslangic = 10000;
        
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
