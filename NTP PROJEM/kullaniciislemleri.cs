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
    public partial class kullaniciislemleri : Form
    {
        Form1 f1 = new Form1();
        public List<kitaplık> kitap = new List<kitaplık>();
        public List<emanet> emanet = new List<emanet>();
        public List<kullanicilar> kullanici = new List<kullanicilar>();
        public kullaniciislemleri()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            f1.Show();
            f1.kitap = this.kitap;
            f1.kullanici = this.kullanici;
            f1.emanet = this.emanet;
            f1.kitaplistboxyenile();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kullanici.Add(new kullanicilar
            {
                Kisi_ad = textBox3.Text,
                Kisi_soyad = textBox4.Text,
                username = textBox1.Text,
                Password = textBox2.Text
            });
             MessageBox.Show("Kullanıcı Eklendi");
        }
    }
}
