using System;
using System.Windows.Forms;


namespace BilgiYarismasi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int soruno = 0;
        int dogru = 0;
        int yanlis = 0;
        int bos = 0;
        int sure = 120;
        Sorular sorular = new Sorular();
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            sure = 120;
            label11.Text = sure.ToString();
            button1.Text = "İLERİ";
            soruno++;
            label4.Text = soruno.ToString() + "/26";
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            #region sorusor           
            if (soruno == 1)
            {
                richTextBox1.Text = sorular.soru1;
                button3.Text = sorular.soru1_a;
                button4.Text = sorular.soru1_b;
                button5.Text = sorular.soru1_c;
                button6.Text = sorular.soru1_d;
                label9.Text = sorular.soru1dogru;

            }
            else if (soruno == 2)
            {
                richTextBox1.Text = sorular.soru2;
                button3.Text = sorular.soru2_a;
                button4.Text = sorular.soru2_b;
                button5.Text = sorular.soru2_c;
                button6.Text = sorular.soru2_d;
                label9.Text = sorular.soru2dogru;
            }
            else if (soruno == 3)
            {
                richTextBox1.Text = sorular.soru3;
                button3.Text = sorular.soru3_a;
                button4.Text = sorular.soru3_b;
                button5.Text = sorular.soru3_c;
                button6.Text = sorular.soru3_d;
                label9.Text = sorular.soru3dogru;
            }
            else if (soruno == 4)
            {
                richTextBox1.Text = sorular.soru4;
                button3.Text = sorular.soru4_a;
                button4.Text = sorular.soru4_b;
                button5.Text = sorular.soru4_c;
                button6.Text = sorular.soru4_d;
                label9.Text = sorular.soru4dogru;
            }
            else if (soruno == 5)
            {
                richTextBox1.Text = sorular.soru5;
                button3.Text = sorular.soru5_a;
                button4.Text = sorular.soru5_b;
                button5.Text = sorular.soru5_c;
                button6.Text = sorular.soru5_d;
                label9.Text = sorular.soru5dogru;
            }
            else if (soruno == 6)
            {
                richTextBox1.Text = sorular.soru6;
                button3.Text = sorular.soru6_a;
                button4.Text = sorular.soru6_b;
                button5.Text = sorular.soru6_c;
                button6.Text = sorular.soru6_d;
                label9.Text = sorular.soru6dogru;
            }
            else if (soruno == 7)
            {
                richTextBox1.Text = sorular.soru7;
                button3.Text = sorular.soru7_a;
                button4.Text = sorular.soru7_b;
                button5.Text = sorular.soru7_c;
                button6.Text = sorular.soru7_d;
                label9.Text = sorular.soru7dogru;
            }
            else if (soruno == 8)
            {
                richTextBox1.Text = sorular.soru8;
                button3.Text = sorular.soru8_a;
                button4.Text = sorular.soru8_b;
                button5.Text = sorular.soru8_c;
                button6.Text = sorular.soru8_d;
                label9.Text = sorular.soru8dogru;
            }
            else if (soruno == 9)
            {
                richTextBox1.Text = sorular.soru9;
                button3.Text = sorular.soru9_a;
                button4.Text = sorular.soru9_b;
                button5.Text = sorular.soru9_c;
                button6.Text = sorular.soru9_d;
                label9.Text = sorular.soru9dogru;
            }
            else if (soruno == 10)
            {
                richTextBox1.Text = sorular.soru10;
                button3.Text = sorular.soru10_a;
                button4.Text = sorular.soru10_b;
                button5.Text = sorular.soru10_c;
                button6.Text = sorular.soru10_d;
                label9.Text = sorular.soru10dogru;
            }
            else if (soruno == 11)
            {
                richTextBox1.Text = sorular.soru11;
                button3.Text = sorular.soru11_a;
                button4.Text = sorular.soru11_b;
                button5.Text = sorular.soru11_c;
                button6.Text = sorular.soru11_d;
                label9.Text = sorular.soru11dogru;
            }
            else if (soruno == 12)
            {
                richTextBox1.Text = sorular.soru12;
                button3.Text = sorular.soru12_a;
                button4.Text = sorular.soru12_b;
                button5.Text = sorular.soru12_c;
                button6.Text = sorular.soru12_d;
                label9.Text = sorular.soru12dogru;
            }
            else if (soruno == 13)
            {
                richTextBox1.Text = sorular.soru13;
                button3.Text = sorular.soru13_a;
                button4.Text = sorular.soru13_b;
                button5.Text = sorular.soru13_c;
                button6.Text = sorular.soru13_d;
                label9.Text = sorular.soru13dogru;
            }
            else if (soruno == 14)
            {
                richTextBox1.Text = sorular.soru14;
                button3.Text = sorular.soru14_a;
                button4.Text = sorular.soru14_b;
                button5.Text = sorular.soru14_c;
                button6.Text = sorular.soru14_d;
                label9.Text = sorular.soru14dogru;
            }
            else if (soruno == 15)
            {
                richTextBox1.Text = sorular.soru15;
                button3.Text = sorular.soru15_a;
                button4.Text = sorular.soru15_b;
                button5.Text = sorular.soru15_c;
                button6.Text = sorular.soru15_d;
                label9.Text = sorular.soru15dogru;
            }
            else if (soruno == 16)
            {
                richTextBox1.Text = sorular.soru16;
                button3.Text = sorular.soru16_a;
                button4.Text = sorular.soru16_b;
                button5.Text = sorular.soru16_c;
                button6.Text = sorular.soru16_d;
                label9.Text = sorular.soru16dogru;
            }
            else if (soruno == 17)
            {
                richTextBox1.Text = sorular.soru17;
                button3.Text = sorular.soru17_a;
                button4.Text = sorular.soru17_b;
                button5.Text = sorular.soru17_c;
                button6.Text = sorular.soru17_d;
                label9.Text = sorular.soru17dogru;
            }
            else if (soruno == 18)
            {
                richTextBox1.Text = sorular.soru18;
                button3.Text = sorular.soru18_a;
                button4.Text = sorular.soru18_b;
                button5.Text = sorular.soru18_c;
                button6.Text = sorular.soru18_d;
                label9.Text = sorular.soru18dogru;
            }
            else if (soruno == 19)
            {
                richTextBox1.Text = sorular.soru19;
                button3.Text = sorular.soru19_a;
                button4.Text = sorular.soru19_b;
                button5.Text = sorular.soru19_c;
                button6.Text = sorular.soru19_d;
                label9.Text = sorular.soru19dogru;
            }
            else if (soruno == 20)
            {
                richTextBox1.Text = sorular.soru20;
                button3.Text = sorular.soru20_a;
                button4.Text = sorular.soru20_b;
                button5.Text = sorular.soru20_c;
                button6.Text = sorular.soru20_d;
                label9.Text = sorular.soru20dogru;
            }
            else if (soruno == 21)
            {
                richTextBox1.Text = sorular.soru21;
                button3.Text = sorular.soru21_a;
                button4.Text = sorular.soru21_b;
                button5.Text = sorular.soru21_c;
                button6.Text = sorular.soru21_d;
                label9.Text = sorular.soru21dogru;
            }
            else if (soruno == 22)
            {
                richTextBox1.Text = sorular.soru22;
                button3.Text = sorular.soru22_a;
                button4.Text = sorular.soru22_b;
                button5.Text = sorular.soru22_c;
                button6.Text = sorular.soru22_d;
                label9.Text = sorular.soru22dogru;
            }
            else if (soruno == 23)
            {
                richTextBox1.Text = sorular.soru23;
                button3.Text = sorular.soru23_a;
                button4.Text = sorular.soru23_b;
                button5.Text = sorular.soru23_c;
                button6.Text = sorular.soru23_d;
                label9.Text = sorular.soru23dogru;
            }
            else if (soruno == 24)
            {
                richTextBox1.Text = sorular.soru24;
                button3.Text = sorular.soru24_a;
                button4.Text = sorular.soru24_b;
                button5.Text = sorular.soru24_c;
                button6.Text = sorular.soru24_d;
                label9.Text = sorular.soru24dogru;
            }
            else if (soruno == 25)
            {
                richTextBox1.Text = sorular.soru25;
                button3.Text = sorular.soru25_a;
                button4.Text = sorular.soru25_b;
                button5.Text = sorular.soru25_c;
                button6.Text = sorular.soru25_d;
                label9.Text = sorular.soru25dogru;
            }
            else if (soruno == 26)
            {
                richTextBox1.Text = sorular.soru26;
                button3.Text = sorular.soru26_a;
                button4.Text = sorular.soru26_b;
                button5.Text = sorular.soru26_c;
                button6.Text = sorular.soru26_d;
                label9.Text = sorular.soru26dogru;
            }
            else if (soruno == 27)
            {
                MessageBox.Show("Sorular bitmiştir", "bitiş");
                timer1.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button1.Enabled = false;
                button7.Enabled = true;
            }           
            #endregion
        }
        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            label8.Text = button3.Text;
            if (label8.Text == label9.Text)
            {
                dogru++;
                label6.Text = dogru.ToString();
            }
            else
            {
                yanlis++;
                label7.Text = yanlis.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            label8.Text = button4.Text;
            if (label8.Text == label9.Text)
            {
                dogru++;
                label6.Text = dogru.ToString();
            }
            else
            {
                yanlis++;
                label7.Text = yanlis.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            label8.Text = button5.Text;
            if (label8.Text == label9.Text)
            {
                dogru++;
                label6.Text = dogru.ToString();
            }
            else
            {
                yanlis++;
                label7.Text = yanlis.ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer1.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            label8.Text = button6.Text;
            if (label8.Text == label9.Text)
            {
                dogru++;
                label6.Text = dogru.ToString();
            }
            else
            {
                yanlis++;
                label7.Text = yanlis.ToString();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure = Convert.ToInt32(label11.Text);
            sure -= 1;
            label11.Text = sure.ToString();
            if (sure == 0)
            {
                timer1.Enabled = false;
                bos++;
                label13.Text = bos.ToString();
                timer1.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            MessageBox.Show("matematik soruları için kalem kağıt hazırlayınız ", "dikkat");
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Restart();

        }
    }
}
