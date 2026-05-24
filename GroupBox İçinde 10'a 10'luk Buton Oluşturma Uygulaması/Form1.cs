using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace butonlu_bi_şey_sal_bizi_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        int satir = 10;
        int sutun = 10;
      List<int> list = new List<int>();
        private void button1_Click(object sender, EventArgs e)
        {            
            groupBox1.Controls.Clear();
            
            for(int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sutun; j++)
                {

                    Button btn = new Button();
                    int a ;
                    do
                    {
                        a = rnd.Next(1,101);
                     
                    }
                    while (list.Contains(a));
                    { 
                        list.Add(a);
                        btn.Text = a.ToString();
                    btn.Location = new Point(10 + 30 * j, 10+ 30 * i);
                    btn.Size = new Size(30, 30);
                    groupBox1.Controls.Add(btn);
                    }
                  
                    

                }
            }
        }
    }
}
