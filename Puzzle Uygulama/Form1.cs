using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace _27_puzzle01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] dizi = new int[9];
        Random rnd = new Random();
        Image res1, res2, ara;
        Button btn1, btn2;
        int tık_say = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            // 1. Diziyi başlangıç değeriyle dolduruyoruz
            for (int i = 0; i < 9; i++)
            {
                dizi[i] = 9;
            }

            // 2. Benzersiz rastgele 9 sayı üretiyoruz (0-8 arası) çünkü şu an dizi oluştuduğumuzda c# içine otomatik olarak 0 lar koyar, bundan dolayı üstte hep 9 oluşturduk ki bize engel olacak 0 lar olmasın
            int sayı;
            for (int i = 0; i < 9; i++)
            {
                do
                {
                    sayı = rnd.Next(0, 9);
                } while (dizi.Contains(sayı)); //daha önce seçilmiş sayıları contains sayesinde seçmez
                dizi[i] = sayı;
            }

            // 3. ListBox ve Butonları güncelliyoruz
            ListeyiVeButonlarıYenile();
        }

        // Listbox'ı ve Buton resimlerini güncel dizilim durumuna göre çizen ortak metot
        private void ListeyiVeButonlarıYenile()
        {
            if (listBox1 != null)
            {
                listBox1.Items.Clear(); //bir sürü 9 var, ondan dolayı temizleyip yeniden içini doldurucaz
                for (int i = 0; i < 9; i++)
                {
                    listBox1.Items.Add(dizi[i]);
                }
            }

            for (int i = 1; i < 10; i++)
            {
                Control bulunanKontrol = this.Controls["button" + i];
                if (bulunanKontrol is Button btn && ımageList1 != null && ımageList1.Images.Count >= 9) //Bulduğun o element gerçekten bir Buton mu? Eğer butonsa, onu hemen btn takma adıyla kullanmamıza izin ver. Formda resim listesi yüklü mü, unutulmuş mu? O resim listesinin içine gerçekten en az 9 tane resim yükledin mi?
                { 
                    btn.BackgroundImage = ımageList1.Images[dizi[i - 1]];
                    btn.BackgroundImageLayout = ImageLayout.Stretch; //imageList teki özellikleri buttonun Image ine taşıdık
                }
            }
        }

        // Butonların yer değiştirme ve kazanma kontrol mekanizması
        private void ortak_olay(object sender, EventArgs e)
        {
            if (!(sender is Button tık_btn)) return; //Sen Gerçekten Bir Buton musun?

            tık_say++; // Sayaç 1 olur

            if (tık_say == 1)
            {
                res1 = tık_btn.BackgroundImage; //tıklanan butonun resmini res1 de tut
                btn1 = tık_btn; //tıkladığın butonu tut

                // Seçilen ilk butona kırmızı kenarlık çekiyoruz
                btn1.FlatStyle = FlatStyle.Flat;
                btn1.FlatAppearance.BorderColor = Color.Red;
                btn1.FlatAppearance.BorderSize = 2;
            }
            else if (tık_say == 2)
            {
                btn2 = tık_btn;

                // Örn: btn1'in adı "button5" ise, "button" kısmını siler, geriye "5" kalır.
                // Diziler 0'dan başladığı için sonuna -1 koyup gerçek indeksini (4) buluruz.
                int idx1 = Convert.ToInt32(btn1.Name.Replace("button", "")) - 1;
                int idx2 = Convert.ToInt32(btn2.Name.Replace("button", "")) - 1;

                // EĞER AYNI BUTONA İKİ KEZ TIKLANDIYSA İPTAL ET
                if (idx1 == idx2)
                {
                    btn1.FlatStyle = FlatStyle.Standard; // Kırmızı çerçeveyi kaldır
                    tık_say = 0;                         // Tıklama sayacını sıfırla
                    return; 
                }

                // 1. Arka plandaki sayı dizisindeki değerleri takas (Swap) ediyoruz
                int geciciSayı = dizi[idx1]; // 1. butonun sayısını düşmesin diye geçici olarak burda tut
                dizi[idx1] = dizi[idx2];     // 2. butonun sayısını al, 1. butonun yerine yaz
                dizi[idx2] = geciciSayı;     // Geçici bardaktaki sayıyı al, 2. butonun yerine yaz

                // 2. Görsel olarak hem listeyi hem de buton resimlerini yeni dizilime göre yeniliyoruz
                ListeyiVeButonlarıYenile();

                // 3. Kenarlıkları eski haline getirip sayacı sıfırlıyoruz
                btn1.FlatStyle = FlatStyle.Standard;
                tık_say = 0;

                // 4. Her takas işleminden sonra oyun bitti mi diye kontrol ediyoruz
                KazanmaKontrolu();
            }
        }

        // Yapbozun doğru sıralamaya ulaşıp ulaşmadığını denetleyen fonksiyon
        private void KazanmaKontrolu()
        {
            bool kazanildiMi = true;

            // Eğer dizi tam olarak 0,1,2,3,4,5,6,7,8 sırasındaysa kazanmıştır
            for (int i = 0; i < 9; i++)
            {
                if (dizi[i] != i)
                {
                    kazanildiMi = false; // Tek bir taş bile yanlış yerdeyse döngüyü kır
                    break;
                }
            }

            if (kazanildiMi)
            {
                MessageBox.Show("Tebrikler, yapbozu başarıyla tamamladın!", "Oyun Bitti", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit(); // Uygulamayı tamamen kapatır
            }
        }

        // Hata koruma amaçlı hayalet metotlar
        private void label1_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}