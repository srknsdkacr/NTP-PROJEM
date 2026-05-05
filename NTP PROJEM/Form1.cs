using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTP_PROJEM
{
    public partial class Form1 : Form
    {
        public List<kitaplık> kitap = new List<kitaplık>();
        public List<emanet> emanet = new List<emanet>();
        public List<kullanicilar> kullanici = new List<kullanicilar>();
        public string username;
        public Form1()
        {
            InitializeComponent();
        }


        private void kitapeklebtn_Click(object sender, EventArgs e)
        {
            kitapeklemesayfasi kitapeklebtn = new kitapeklemesayfasi();
            kitapeklebtn.Show();
            kitapeklebtn.kitap = this.kitap;
            kitapeklebtn.emanet = this.emanet;
            kitapeklebtn.kullanici = this.kullanici;
            this.Hide();
        }
        private void kitapsil_Click(object sender, EventArgs e)
        {
            string secilen = listBox1.SelectedItem.ToString();

            string[] parcalar = secilen.Split('-');

            // Trim ile boşlukları temizle
            int id = int.Parse(parcalar[0].Trim());

            var silinecek = kitap.FirstOrDefault(x => x.Kitap_ID == id);
            kitap.Remove(silinecek);
            MessageBox.Show("Veri Silindi");
            kitaplistboxyenile();
        }

        public void kitaplistboxyenile()
        {
            listBox1.Items.Clear();
            if (kitap.Count > 0)
            {
                foreach (var item in kitap)
                {
                    listBox1.Items.Add(item.Kitap_ID.ToString() + " - " + item.Kitap_ad.ToString() + " , " + item.Kitap_sayi.ToString());
                }
            }
        }

        public void emanetlistboxyenile()
        {
            listBox2.Items.Clear();
            if (emanet.Count > 0)
            {
                foreach (var item in emanet)
                {
                    listBox2.Items.Add(item.kullanici.Kisi_ad.ToString() + " " + item.kullanici.Kisi_soyad.ToString()+ " isimli kişi, " + item.kitap.Kitap_ad.ToString() + " kitabını aldı.");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kitaplistboxyenile();
            emanetlistboxyenile();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string aranan = textBox1.Text.ToLower();

            listBox1.Items.Clear();

            foreach (var kitap in kitap)
            {
                // ID mi girildi kontrolü
                bool idMi = int.TryParse(aranan, out int id);

                if ((idMi && kitap.Kitap_ID == id) ||
                    (!idMi && kitap.Kitap_ad.ToLower().Contains(aranan)))
                {
                    listBox1.Items.Add($"{kitap.Kitap_ID} - {kitap.Kitap_ad} - {kitap.Kitap_yazar}");
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            kitaplistboxyenile();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            emanetlistboxyenile();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kullaniciislemleri kullaniciislemleri = new kullaniciislemleri();
            kullaniciislemleri.Show();
            kullaniciislemleri.kitap = this.kitap;
            kullaniciislemleri.emanet = this.emanet;
            kullaniciislemleri.kullanici = this.kullanici;
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            emanetislemleri emanetislemleri = new emanetislemleri();
            emanetislemleri.Show();
            emanetislemleri.kitap = this.kitap;
            emanetislemleri.emanet = this.emanet;
            emanetislemleri.kullanici = this.kullanici;
            emanetislemleri.kisilistboxyenile();
            emanetislemleri.kitaplistboxyenile();
            this.Hide();
        }
    }
}
