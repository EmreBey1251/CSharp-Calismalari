using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comboBox_groupBox_button
{
    public partial class Form1 : Form
    {
        public Form1()        
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.groupBox1.Controls.Clear();
            int sayi = comboBox1.SelectedIndex;
            int uzun = groupBox1.Height / sayi; //Kısa kenari seçilen sayıya böldük ki onu butonun kısa kenarına atayalım.
            int kısakenar = groupBox1.Width / sayi; //Uzun kenara aynı işlemi uyguladık.
            int konx = 0, kony = 0;
            for (int i = 0; i < sayi; i++) //y ekseni
            {
                for (int j = 0; j < sayi; j++) //x ekseni
                {
                    Button btn = new Button();
                    btn.Name = "btn";
                    btn.Text = "";
                    btn.Size = new Size(uzun, kısakenar);
                    btn.Location = new Point(konx, kony);
                    this.groupBox1.Controls.Add(btn);
                    konx += uzun;

                    if ((i + j) % 2 == 0)
                    {
                        btn.BackColor = Color.Red;

                    }
                    else
                    {
                        btn.BackColor = Color.White;

                    }
                    if (konx > groupBox1.Width) break;
                }
                konx = 0; //x eksenini sıfırladık ki yine baştan dizelim.
                kony += uzun; //y eksenini artırdık, böylece  bir alt satıra geçebilicez.
            }
        }

    }

}
