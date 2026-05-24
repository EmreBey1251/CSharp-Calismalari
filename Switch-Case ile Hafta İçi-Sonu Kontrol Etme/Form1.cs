using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2.ünite_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Gün bilgisini sayıya çevirmek yerine doğrudan C#'ın DayOfWeek yapısıyla alıyoruz
            DayOfWeek bugun = DateTime.Now.DayOfWeek;

            switch (bugun)
            {
                case DayOfWeek.Monday:
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Thursday:
                case DayOfWeek.Friday:
                    MessageBox.Show("Bugün hafta içi, çalışmaya devam! ", "Gün Bilgisi");
                    break;

                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    MessageBox.Show("Bugün hafta sonu, dinlenme zamanı!  ", "Gün Bilgisi");
                    break;

                default:
                    MessageBox.Show("Zaman çizgisinde bir kırılma oldu galiba! ", "Hata");
                    break;
            }
        }
    }
}
