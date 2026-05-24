using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace araba_2
{
    
    internal class araba
    {
        string marka;
        string model;
        int sonHiz;
        bool calisiyorMu = false;
        int anlikHiz;

        public string Marka { get => marka; set => marka = value; }
        public string Model { get => model; set => model = value; }
        public int SonHiz { get => sonHiz; set => sonHiz = value; }
        public bool CalisiyorMu { get => calisiyorMu; set => calisiyorMu = value; }
        public int AnlikHiz { get => anlikHiz; set => anlikHiz = value; }
        public araba(string marka, string model, int sonHiz)
        {
            Marka = marka;
            Model = model;
            SonHiz = sonHiz;            
        }
        public string ArabayiCalistir()
        {
           if (!CalisiyorMu)
           {
              CalisiyorMu = true;
              return "Araba Çalıştırıldı";
           }
           else
           {
                return "Araba zaten çalışıyor";
           }          
        }
        public string ArabayiDurdur()
        {
            if (CalisiyorMu)
            {
                if (anlikHiz > 0)
                {
                    MessageBox.Show("Arabayı durdurmak için durman lazım.");
                    calisiyorMu = true;
                    return $"Araba çalışıyor, Anlık Hız:{anlikHiz} ";
                }
                calisiyorMu = false;
                return "Araba durduruldu.";               
            }           
            else
            {
                return "Araba zaten durdu.";
            }
        }
        public string Hizlan(int hiz)
        {
            if (CalisiyorMu)
            {
                AnlikHiz += hiz;
                if(AnlikHiz > SonHiz)
                {
                    AnlikHiz = SonHiz;
                }
                return $"Araba hızlandı. Anlık Hız: {AnlikHiz} km/h";
            }
            else
            {
                return "Arabayı önce çalıştırmalısın.";
            }
        }
        public string Yavasla(int hiz)
        {
            if (CalisiyorMu)
            {
                AnlikHiz -= hiz;
                if (AnlikHiz < 0)
                {
                    AnlikHiz = 0;
                }
                return $"Araba Yavaşladı. Anlık Hız: {AnlikHiz} km/h";
            }
            else
            {
                return "Arabayı önce çalıştırmalısın.";
            }
        }
    }
}
