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
    public partial class kitapeklemesayfasi : Form
    {
        Form1 f1 = new Form1();
        public kitapeklemesayfasi()
        {
            InitializeComponent();
        }

        private void kitapeklemesayfasi_Load(object sender, EventArgs e)
        {
        }

        private void iptalbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void eklebtn_Click(object sender, EventArgs e)
        {
            int sayfa, id;

            if (!int.TryParse(textsayfa.Text, out sayfa) ||
                !int.TryParse(txtID.Text, out id))
            {
                MessageBox.Show("Sayfa ve ID sayısal olmalı.");
                return;
            }

            if (comboturu.Text == "Şiir")
            {
                f1.kitap.Add(new Siir
                {
                    Kitap_ad = textkitapad.Text,
                    Kitap_yazar = textyazar.Text,
                    Kitap_sayi = sayfa,
                    Kitap_ID = id,
                    Kitap_yayinevi = textyayinevi.Text
                });
            }

            if (comboturu.Text == "Roman")
            {
                f1.kitap.Add(new Roman
                {
                    Kitap_ad = textkitapad.Text,
                    Kitap_yazar = textyazar.Text,
                    Kitap_sayi = sayfa,
                    Kitap_ID = id,
                    Kitap_yayinevi = textyayinevi.Text
                });
            }

            if (comboturu.Text == "Deneme")
            {
                f1.kitap.Add(new Deneme
                {
                    Kitap_ad = textkitapad.Text,
                    Kitap_yazar = textyazar.Text,
                    Kitap_sayi = sayfa,
                    Kitap_ID = id,
                    Kitap_yayinevi = textyayinevi.Text
                });
            }
            if (comboturu.Text == "Hikaye")
            {
                f1.kitap.Add(new Hikaye
                {
                    Kitap_ad = textkitapad.Text,
                    Kitap_yazar = textyazar.Text,
                    Kitap_sayi = sayfa,
                    Kitap_ID = id,
                    Kitap_yayinevi = textyayinevi.Text
                });
            }
            if (comboturu.Text == "Biyografi_otobiyografi")
            {
                f1.kitap.Add(new Biyografi_otobiyografi
                {
                    Kitap_ad = textkitapad.Text,
                    Kitap_yazar = textyazar.Text,
                    Kitap_sayi = sayfa,
                    Kitap_ID = id,
                    Kitap_yayinevi = textyayinevi.Text
                });
            }
            if (comboturu.Text == "Arastirma_inceleme")
            {
                f1.kitap.Add(new Arastirma_inceleme
                {
                    Kitap_ad = textkitapad.Text,
                    Kitap_yazar = textyazar.Text,
                    Kitap_sayi = sayfa,
                    Kitap_ID = id,
                    Kitap_yayinevi = textyayinevi.Text
                });
            }
            if(comboturu.Text == "Bilimkurgu")
            {
                f1.kitap.Add(new Bilimkurgu
                {
                    Kitap_ad = textkitapad.Text,
                    Kitap_yazar = textyazar.Text,
                    Kitap_sayi = sayfa,
                    Kitap_ID = id,
                    Kitap_yayinevi = textyayinevi.Text
                });
            }
            if(comboturu.Text == "Felsefi")
            {
                f1.kitap.Add(new Felsefi
                {
                    Kitap_ad = textkitapad.Text,
                    Kitap_yazar = textyazar.Text,
                    Kitap_sayi = sayfa,
                    Kitap_ID = id,
                    Kitap_yayinevi = textyayinevi.Text
                });
            }
            if(comboturu.Text == "Kisiselgelisim")
            {
                f1.kitap.Add(new Kisiselgelisim
                {
                    Kitap_ad = textkitapad.Text,
                    Kitap_yazar = textyazar.Text,
                    Kitap_sayi = sayfa,
                    Kitap_ID = id,
                    Kitap_yayinevi = textyayinevi.Text
                });
            }
            if (comboturu.Text == "cocukkitaplari")
            {
                f1.kitap.Add(new Cocukkitaplari
                {
                    Kitap_ad = textkitapad.Text,
                    Kitap_yazar = textyazar.Text,
                    Kitap_sayi = sayfa,
                    Kitap_ID = id,
                    Kitap_yayinevi = textyayinevi.Text
                });
            }

            f1.Show();
            this.Hide();
        }
    }
}
