using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2.ünite_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TryParse ile harf mi girilmiş sayı mı kontrol edip kullanıcıya geri dönüş yaptırıyoruz.
            bool yasGecerli = byte.TryParse(textBox1.Text, out byte yas);

            // Eğer harf girildiyse veya geçersiz bir karakter varsa:
            if (!yasGecerli)
            {
                MessageBox.Show("Lütfen geçerli bir yaş (sayı) giriniz!", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            if (yas > 17)
            {
                MessageBox.Show("Ehliyet başvurusunda bulunabilirsiniz. ", "Başvuru Durumu");
            }
            else
            {
                MessageBox.Show("Ehliyet başvurusunda bulunamazsınız. ", "Başvuru Durumu");
            }
        }
    }
}
