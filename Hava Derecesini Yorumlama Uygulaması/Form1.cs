using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hoca_3
{
    public partial class Form1 : Form
    {
        private const int V = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double hava_sicakligi;
            hava_sicakligi = Convert.ToDouble(textBox1.Text);

            if (hava_sicakligi < -15)
            {
                MessageBox.Show("DONUYORUUUUUUUUUUUM");
            }

            else if (hava_sicakligi < 0)
            {
                MessageBox.Show("Hava çok soğuk");
            }

            else if (hava_sicakligi < 10)
            {
                MessageBox.Show("Hava soğuk");
            }

            else if (hava_sicakligi < 20)
            {
                MessageBox.Show("Hava serin");
            }

            else if (hava_sicakligi < 25)
            {
                MessageBox.Show("Hava güzel");
            }

            else if (hava_sicakligi < 35)
            {
                MessageBox.Show("Hava biraz sıcak");
            }

            else if (hava_sicakligi < 45)
            {
                MessageBox.Show("Hava çok sıcak");
            }

            else if (hava_sicakligi < 60)
            {
                MessageBox.Show("Dışarı çıkmayın Ölüyoz");
            }
      
            else
            {
                MessageBox.Show("YANIYORUUUUUUUUUUM");
            }
            
        }
    }
}
