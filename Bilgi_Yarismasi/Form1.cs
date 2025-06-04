using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Bilgi_Yarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruno = 0, dogru = 0, yanlis = 0;

        private void BtnB_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            label4.Text = BtnB.Text;
            if (label2.Text == label4.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;


            label4.Text = BtnC.Text;
            if (label2.Text == label4.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void BtnD_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;


            label4.Text = BtnD.Text;
            if (label2.Text == label4.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void BtnA_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;


            label4.Text = BtnA.Text;
            if (label2.Text == label4.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void BtnSonraki_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\Onursal Toparlak\Desktop\Who Wants to Be a Millionaire_ (Turkey) - Intro.wav");
            splayer.Play();

            BtnA.Enabled = true;
            BtnB.Enabled = true;
            BtnC.Enabled = true;
            BtnD.Enabled = true;
            BtnSonraki.Enabled = false;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            soruno++;
            LblSoruNo.Text = soruno.ToString();

            if (soruno == 1)
            {
                richTextBox1.Text = "Cumhuriyet kaç yılında ilan edilmiştir?";
                BtnA.Text = "1920";
                BtnB.Text = "1921";
                BtnC.Text = "1922";
                BtnD.Text = "1923";
                label2.Text = "1923";
            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Hangi şehir Ege bölgemizde bulunmaz?";
                BtnA.Text = "İzmir";
                BtnB.Text = "Balıkesir";
                BtnC.Text = "Aydın";
                BtnD.Text = "Manisa";
                label2.Text = "Balıkesir";
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "1984 kitabı hangi yazara aittir?";
                BtnA.Text = "George Orwell";
                BtnB.Text = "John Verdon";
                BtnC.Text = "Dostoyevksi";
                BtnD.Text = "Tolstoy";
                label2.Text = "George Orwell";
            }
            if (soruno == 4)
            {
                richTextBox1.Text = "Türkiye'nin en uzun nehri hangisidir?";
                BtnA.Text = "Kızılırmak";
                BtnB.Text = "Fırat";
                BtnC.Text = "Dicle";
                BtnD.Text = "Sakarya";
                label2.Text = "Kızılırmak";
            }
            if (soruno == 5)
            {
                richTextBox1.Text = "DNA'nın çift sarmal yapısını kim keşfetmiştir?";
                BtnA.Text = "Newton ve Einstein";
                BtnB.Text = "Watson ve Crick";
                BtnC.Text = "Darwin ve Mendel";
                BtnD.Text = "Pasteur ve Curie";
                label2.Text = "Watson ve Crick";
            }
            if (soruno == 6)
            {
                richTextBox1.Text = "Aşağıdakilerden hangisi bir gezegen değildir?";
                BtnA.Text = "Venüs";
                BtnB.Text = "Mars";
                BtnC.Text = "Ay";
                BtnD.Text = "Plüton";
                label2.Text = "Ay";
            }
            if (soruno == 7)
            {
                richTextBox1.Text = "Osmanlı Devleti hangi yıl kuruldu?";
                BtnA.Text = "1296";
                BtnB.Text = "1297";
                BtnC.Text = "1298";
                BtnD.Text = "1299";
                label2.Text = "1299";
            }
            if (soruno == 8)
            {
                richTextBox1.Text = "En küçük asal sayı hangisidir?";
                BtnA.Text = "1";
                BtnB.Text = "2";
                BtnC.Text = "3";
                BtnD.Text = "0";
                label2.Text = "2";
            }
            if (soruno == 9)
            {
                richTextBox1.Text = "İstiklal Marşı'nı kim yazmıştır?";
                BtnA.Text = "Mehmet Akif Ersoy";
                BtnB.Text = "Namık Kemal";
                BtnC.Text = "Tevfik Fikret";
                BtnD.Text = "Ziya Gökalp";
                label2.Text = "Mehmet Akif Ersoy";
            }
            if (soruno == 10)
            {
                richTextBox1.Text = "Güneş sistemindeki en büyük gezegen hangisidir?";
                BtnA.Text = "Dünya";
                BtnB.Text = "Mars";
                BtnC.Text = "Jüpiter";
                BtnD.Text = "Satürn";
                label2.Text = "Jüpiter";
            }
            if (soruno == 11)
            {
                richTextBox1.Text = "Türkiye kaç coğrafi bölgeye ayrılır?";
                BtnA.Text = "4";
                BtnB.Text = "5";
                BtnC.Text = "6";
                BtnD.Text = "7";
                label2.Text = "7";
            }
            if (soruno == 12)
            {
                richTextBox1.Text = "Hangi elementin kimyasal sembolü 'O' harfidir?";
                BtnA.Text = "Altın";
                BtnB.Text = "Oksijen";
                BtnC.Text = "Sodyum";
                BtnD.Text = "Azot";
                label2.Text = "Oksijen";
            }
            if (soruno == 13)
            {
                richTextBox1.Text = "Rönesans hangi kıtada başlamıştır?";
                BtnA.Text = "Avrupa";
                BtnB.Text = "Afrika";
                BtnC.Text = "Asya";
                BtnD.Text = "Amerika";
                label2.Text = "Avrupa";
            }
            if (soruno == 14)
            {
                richTextBox1.Text = "Türk lirası 2005 yılında hangi eski para birimi yerine geçti?";
                BtnA.Text = "Türk Lirası (milyonlu)";
                BtnB.Text = "Lira";
                BtnC.Text = "Bin Lira";
                BtnD.Text = "Yeni Türk Lirası";
                label2.Text = "Yeni Türk Lirası";
            }
            if (soruno == 15)
            {
                richTextBox1.Text = "Hangisi yaz mevsimi aylarından biridir?";
                BtnA.Text = "Nisan";
                BtnB.Text = "Temmuz";
                BtnC.Text = "Ekim";
                BtnD.Text = "Mart";
                label2.Text = "Temmuz";
            }
            if (soruno == 16)
            {
                richTextBox1.Text = "Türkiye'nin en yüksek dağı hangisidir?";
                BtnA.Text = "Erciyes";
                BtnB.Text = "Kaçkar";
                BtnC.Text = "Ağrı Dağı";
                BtnD.Text = "Palandöken";
                label2.Text = "Ağrı Dağı";
            }
            if (soruno == 17)
            {
                richTextBox1.Text = "İnternetin temel protokolü aşağıdakilerden hangisidir?";
                BtnA.Text = "TCP/IP";
                BtnB.Text = "HTTP";
                BtnC.Text = "FTP";
                BtnD.Text = "SMTP";
                label2.Text = "TCP/IP";
            }
            if (soruno == 18)
            {
                richTextBox1.Text = "Leonardo da Vinci'nin en bilinen tablosu hangisidir?";
                BtnA.Text = "Son Akşam Yemeği";
                BtnB.Text = "Mona Lisa";
                BtnC.Text = "Çığlık";
                BtnD.Text = "Yıldızlı Gece";
                label2.Text = "Mona Lisa";
            }
            if (soruno == 19)
            {
                richTextBox1.Text = "Aşağıdakilerden hangisi bir programlama dili değildir?";
                BtnA.Text = "Python";
                BtnB.Text = "Java";
                BtnC.Text = "HTML";
                BtnD.Text = "C++";
                label2.Text = "HTML";
            }
            if (soruno == 20)
            {
                richTextBox1.Text = "Dünya Sağlık Örgütü'nün (WHO) merkezi hangi şehirde bulunur?";
                BtnA.Text = "New York";
                BtnB.Text = "Paris";
                BtnC.Text = "Londra";
                BtnD.Text = "Cenevre";
                label2.Text = "Cenevre";
                BtnSonraki.Text = "Sonuçlar";
            }
            if (soruno == 21)
            {
                BtnA.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;
                BtnSonraki.Enabled = false;
                MessageBox.Show("Tebrikler! Yarışma bitti." + "\n" + "Doğru: " + dogru + "\n" + "Yanlış: " + yanlis);
            }


        }
    }
}
