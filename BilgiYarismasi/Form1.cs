using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgiYarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kullanicilar kullanici = new Kullanicilar();
            string gelenisim = textBox1.Text;
            string gelensoyisim = textBox2.Text;
            string gelenyas = textBox3.Text;
            if (gelenisim != "" && gelensoyisim != "" && gelenyas != "")
            {
                kullanici.isim = gelenisim;
                kullanici.soyisim = gelensoyisim;
                kullanici.yas = gelenyas;
                Form2 anasayfa = new Form2();
                anasayfa.Show();
                this.Hide();
                anasayfa.label1.Text = "İsim: "+kullanici.isim;
                anasayfa.label2.Text = "Soyisim: "+kullanici.soyisim;
                anasayfa.label3.Text = "Yaş: "+kullanici.yas;

            }
            else
            {
                MessageBox.Show("lütfen bilgileri eksiksiz giriniz");
            }
        }
    }
}
