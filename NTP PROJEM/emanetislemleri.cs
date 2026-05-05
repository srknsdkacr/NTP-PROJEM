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
    public partial class emanetislemleri : Form
    {
        Form1 f1 = new Form1();
        public List<kitaplık> kitap = new List<kitaplık>();
        public List<emanet> emanet = new List<emanet>();
        public List<kullanicilar> kullanici = new List<kullanicilar>();
        public emanetislemleri()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            f1.Show();
            f1.kitap = this.kitap;
            f1.kullanici = this.kullanici;
            f1.emanet = this.emanet;
            f1.kitaplistboxyenile();
            f1.emanetlistboxyenile();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string kitapStr = listBox1.SelectedItem.ToString();
            int kitapId = int.Parse(kitapStr.Split('-')[0].Trim());

            string kullaniciStr = listBox2.SelectedItem.ToString();
            string kullaniciad = kullaniciStr.Split('-')[0].Trim().ToString();

            var secilenKitap = kitap.FirstOrDefault(k => k.Kitap_ID == kitapId);
            var secilenKullanici = kullanici.FirstOrDefault(k => k.username == kullaniciad);

            if (secilenKitap == null || secilenKullanici == null)
            {
                MessageBox.Show("Kitap ve Kullanıcı Seçiniz.");
                return;
            }

            emanet.Add(new emanet()
            {
                kitap = secilenKitap,
                kullanici = secilenKullanici
            });
            MessageBox.Show("Emanet verildi.");
        }

        private void emanetislemleri_Load(object sender, EventArgs e)
        {
            kitaplistboxyenile();
            kisilistboxyenile();
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

        public void kisilistboxyenile()
        {
            listBox2.Items.Clear();
            if (kullanici.Count > 0)
            {
                foreach (var item in kullanici)
                {
                    listBox2.Items.Add(item.username.ToString() + " - " + item.Kisi_ad.ToString() + " " + item.Kisi_soyad.ToString());
                }
            }
        }
    }
}
