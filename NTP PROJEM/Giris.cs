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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "1234")
            {
                Form1 f1 = new Form1();
                f1.Show();
                f1.username = "admin";
                this.Hide();
            }
            else
            {
                MessageBox.Show("Lütfen Giriş Bilgilerini Kontrol Ediniz.");
            }
        }

        private void Giris_Load(object sender, EventArgs e)
        {

        }
    }
}
