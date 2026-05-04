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
        public string username;
        public Form1()
        {
            InitializeComponent();
        }


        private void kitapeklebtn_Click(object sender, EventArgs e)
        {
            kitapeklemesayfasi kitapeklebtn = new kitapeklemesayfasi();
            kitapeklebtn.Show();
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
            listboxyenile();
        }

        public void listboxyenile()
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

        private void Form1_Load(object sender, EventArgs e)
        {
            listboxyenile();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
