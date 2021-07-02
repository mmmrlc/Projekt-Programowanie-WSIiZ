using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_Programowanie_WSIiZ
{
    public partial class Form1 : Form
    {
        List<Kostka> kosci = new List<Kostka>();
        List<int> modyfikatory = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox4.Text = "";
            List<int> rzuty = new List<int>();
            int iloscKosci = kosci.Count();
            for (int i = 0; i < iloscKosci; i++)
            {
                rzuty.Add(kosci[i].rzut() + modyfikatory[i]);
                textBox3.Text = textBox3.Text + rzuty[i].ToString() + ", ";
                if (rzuty[i] < 1)
                    rzuty[i] = 1;
            }

            try
            {
                if (checkBox1.Checked || iloscKosci == 1)
                {

                    int najwyzszy = rzuty.Max();
                    Kostka najwyzszaKostka = kosci[rzuty.IndexOf(najwyzszy)];
                    textBox4.Text = najwyzszy.ToString();
                    if (najwyzszy >= najwyzszaKostka.getWielkosc())
                        textBox4.Text = textBox4.Text + " - krytyczny sukces ";
                    else if (najwyzszy == 1)
                        textBox4.Text = textBox4.Text + " - krytyczna porazka ";

                }


                else
                    textBox4.Text = rzuty.Sum().ToString();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Musisz dodac kosc!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = 0;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            checkBox1.Checked = false;
            listBox1.SelectedIndex = 0;
            kosci.Clear();
            modyfikatory.Clear();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int modyfikator = int.Parse(textBox1.Text);
            modyfikatory.Add(modyfikator);
            
                kosci.Add(new Kostka(int.Parse(listBox1.SelectedItem.ToString())));

                switch (modyfikator)
                {
                    case 0:
                        textBox2.Text = textBox2.Text + listBox1.SelectedItem.ToString() + ", ";
                        break;
                    case > 0:
                        textBox2.Text = textBox2.Text + listBox1.SelectedItem.ToString() + "+" + textBox1.Text + ", ";
                        break;

                    case < 0:
                        textBox2.Text = textBox2.Text + listBox1.SelectedItem.ToString() + textBox1.Text + ", ";
                        break;

                }
            
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int mod = int.Parse(textBox1.Text);
            mod += 1;
            textBox1.Text = mod.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int mod = int.Parse(textBox1.Text);
            mod -= 1;
            textBox1.Text = mod.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }
    }
}
