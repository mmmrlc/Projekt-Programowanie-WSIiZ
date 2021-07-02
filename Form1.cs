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
            int xxxx;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
            modyfikatory.Add(int.Parse(textBox1.Text));
            kosci.Add(new Kostka(int.Parse(listBox1.SelectedItem.ToString())));
            if (textBox1.Text == "0")
                textBox2.Text = textBox2.Text + listBox1.SelectedItem.ToString() + ", ";
            else if (int.Parse(textBox1.Text) > 0)
                textBox2.Text = textBox2.Text + listBox1.SelectedItem.ToString() + "+" + textBox1.Text + ", ";
            else
                textBox2.Text = textBox2.Text + listBox1.SelectedItem.ToString() + textBox1.Text + ", ";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
