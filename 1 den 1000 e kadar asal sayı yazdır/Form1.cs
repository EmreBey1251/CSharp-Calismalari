using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yahya_19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for  ( int b = 2; b < 1000; b++ )
            {
                int a = 0;
                int c = 2;
                while ( c < b )
                {
                    if ( b % c == 0 )
                        
                         a++;
                    c++;
                }
                if ( a != 0 ) { }
                else listBox1.Items.Add(b);
            }
        }
    }
}
