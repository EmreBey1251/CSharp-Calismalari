using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SİNEMA
{
    class Sinema
    {
        int KoltukSayisi;
        string SalonNo;
        int BosKoltukSayisi;
        double tam;
        double ogrenci;
        double bakiye;
        
        public Sinema (string SalonNo, int KoltukSayisi, double tam, double ogrenci)
        {
            this.KoltukSayisi = KoltukSayisi;
            this.SalonNo = SalonNo;
            this.tam = tam;
            this.ogrenci = ogrenci;
            bakiye = 0;
            BosKoltukSayisi = this.KoltukSayisi;
        }
        public void fiyat(double ogrenci, double tam)
        {
            this.tam = tam;
            this.ogrenci = ogrenci;
        }
        public void biletSat(bool checkBox1)
        {
            BosKoltukSayisi -= 1;
            if (checkBox1)
            {
                bakiye += tam;

            }
            else
            {
                bakiye += ogrenci;
            }
                
        }
        public void biletİptal(bool checkBox1)
        {
            if (checkBox1)
            {
                bakiye -= tam;
                BosKoltukSayisi += 1;
                if(BosKoltukSayisi == KoltukSayisi+1)
                {
                    MessageBox.Show("Zaten kimse bilet almadıki!");
                    BosKoltukSayisi--;
                }
            }
            else
            {
                 bakiye -= ogrenci;
                BosKoltukSayisi += 1;
                if (BosKoltukSayisi == KoltukSayisi+1)
                {
                    MessageBox.Show("Zaten kimse bilet almadıki!");
                    BosKoltukSayisi--;
                }
            }
        }
        public int bosKOLTUKSAYİSİ()
        {
            return BosKoltukSayisi;
        }
        public double Bakiye()
        {
            return bakiye;
        }
    }
    
}
