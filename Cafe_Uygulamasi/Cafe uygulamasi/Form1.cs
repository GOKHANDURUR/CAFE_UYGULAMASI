using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_uygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDown1.Enabled= false;
            numericUpDown2.Enabled= false;
            numericUpDown3.Enabled= false;
            numericUpDown4.Enabled= false;
            numericUpDown5.Enabled= false;
            numericUpDown6.Enabled= false;
            textBox2.Text = "0";
            textBox10.Text= "0";
            textBox3.Text= "0";
            textBox14.Text= "0";
            textBox15.Text= "0";
            numericUpDown7.Enabled = false;
            numericUpDown8.Enabled = false;
            numericUpDown9.Enabled = false;
            numericUpDown10.Enabled = false;
            numericUpDown11.Enabled = false;
            numericUpDown12.Enabled = false;
            textBox5.Text = "0";
            textBox11.Text = "0";
            textBox6.Text = "0";
            textBox16.Text = "0";
            numericUpDown13.Enabled = false;
            numericUpDown14.Enabled = false;
            numericUpDown15.Enabled = false;
            numericUpDown16.Enabled = false;
            numericUpDown17.Enabled = false;
            numericUpDown18.Enabled = false;
            textBox8.Text = "0";
            textBox12.Text = "0";
            textBox9.Text = "0";
            textBox17.Text = "0";
            timer1.Start();




        }

        private void button5_Click(object sender, EventArgs e)
        {
            decimal odenen = Convert.ToDecimal(textBox16.Text) + Convert.ToDecimal(textBox11.Text);
            textBox11.Text = Convert.ToString(odenen);
            decimal bahsis = Convert.ToDecimal(textBox14.Text) + Convert.ToDecimal(textBox6.Text);
            textBox14.Text = Convert.ToString(bahsis);

            button2.Text = "MASA2 (BOŞ)";
            button2.Enabled = true;
            numericUpDown7.Value = 0;
            numericUpDown8.Value = 0;
            numericUpDown9.Value = 0;
            numericUpDown10.Value = 0;
            numericUpDown11.Value = 0;
            numericUpDown12.Value = 0;
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";
            textBox16.Text = "0";
            numericUpDown7.Enabled = false;
            numericUpDown8.Enabled = false;
            numericUpDown9.Enabled = false;
            numericUpDown10.Enabled = false;
            numericUpDown11.Enabled = false;
            numericUpDown12.Enabled = false;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "MASA1 DOLU";
            numericUpDown1.Enabled = true;
            numericUpDown2.Enabled = true;
            numericUpDown3.Enabled = true;
            numericUpDown4.Enabled = true;
            numericUpDown5.Enabled = true;
            numericUpDown6.Enabled = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            decimal hesap1 = (numericUpDown1.Value * 5) + (numericUpDown2.Value * 25) 
                + (numericUpDown3.Value * 5) + (numericUpDown4.Value * 5) 
                + (numericUpDown5.Value * 10) + (numericUpDown6.Value * 3);
            textBox1.Text = Convert.ToString(hesap1);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            decimal indirimli1= Convert.ToDecimal(textBox1.Text)-((Convert.ToDecimal(textBox1.Text)*Convert.ToDecimal(textBox2.Text))/100);
            textBox15.Text=Convert.ToString(indirimli1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            decimal odenen = Convert.ToDecimal(textBox15.Text) + Convert.ToDecimal(textBox10.Text);
            textBox10.Text = Convert.ToString(odenen);
            decimal bahsis = Convert.ToDecimal(textBox14.Text) + Convert.ToDecimal(textBox3.Text);
            textBox14.Text = Convert.ToString(bahsis);

            button1.Text = "MASA1 (BOŞ)";
            button1.Enabled= true;
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            numericUpDown4.Value = 0;
            numericUpDown5.Value = 0;
            numericUpDown6.Value = 0;
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox15.Text = "0";
            numericUpDown1.Enabled = false;
            numericUpDown2.Enabled = false;
            numericUpDown3.Enabled = false;
            numericUpDown4.Enabled = false;
            numericUpDown5.Enabled = false;
            numericUpDown6.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = "MASA2 DOLU";
            numericUpDown7.Enabled = true;
            numericUpDown8.Enabled = true;
            numericUpDown9.Enabled = true;
            numericUpDown10.Enabled = true;
            numericUpDown11.Enabled = true;
            numericUpDown12.Enabled = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            decimal hesap2 = (numericUpDown7.Value * 5) + (numericUpDown8.Value * 25)
                + (numericUpDown9.Value * 5) + (numericUpDown10.Value * 5)
                + (numericUpDown11.Value * 10) + (numericUpDown12.Value * 3);
            textBox4.Text = Convert.ToString(hesap2);

        }

        private void button10_Click(object sender, EventArgs e)
        {
            decimal indirimli2 = Convert.ToDecimal(textBox4.Text) - ((Convert.ToDecimal(textBox4.Text) * Convert.ToDecimal(textBox5.Text)) / 100);
            textBox16.Text = Convert.ToString(indirimli2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = "MASA3 DOLU";
            numericUpDown13.Enabled = true;
            numericUpDown14.Enabled = true;
            numericUpDown15.Enabled = true;
            numericUpDown16.Enabled = true;
            numericUpDown17.Enabled = true;
            numericUpDown18.Enabled = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            decimal hesap3 = (numericUpDown13.Value * 5) + (numericUpDown14.Value * 25)
                + (numericUpDown15.Value * 5) + (numericUpDown16.Value * 5)
                + (numericUpDown17.Value * 10) + (numericUpDown18.Value * 3);
            textBox7.Text = Convert.ToString(hesap3);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            decimal indirimli2 = Convert.ToDecimal(textBox7.Text) - ((Convert.ToDecimal(textBox7.Text) * Convert.ToDecimal(textBox8.Text)) / 100);
            textBox17.Text = Convert.ToString(indirimli2);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            decimal odenen = Convert.ToDecimal(textBox17.Text) + Convert.ToDecimal(textBox12.Text);
            textBox12.Text = Convert.ToString(odenen);
            decimal bahsis = Convert.ToDecimal(textBox14.Text) + Convert.ToDecimal(textBox9.Text);
            textBox14.Text = Convert.ToString(bahsis);

            button3.Text = "MASA3 (BOŞ)";
            button3.Enabled = true;
            numericUpDown13.Value = 0;
            numericUpDown14.Value = 0;
            numericUpDown15.Value = 0;
            numericUpDown16.Value = 0;
            numericUpDown17.Value = 0;
            numericUpDown18.Value = 0;
            textBox7.Text = "0";
            textBox8.Text = "0";
            textBox9.Text = "0";
            textBox17.Text = "0";
            numericUpDown13.Enabled = false;
            numericUpDown14.Enabled = false;
            numericUpDown15.Enabled = false;
            numericUpDown16.Enabled = false;
            numericUpDown17.Enabled = false;
            numericUpDown18.Enabled = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            decimal toplam = Convert.ToDecimal(textBox10.Text) + Convert.ToDecimal(textBox11.Text) + Convert.ToDecimal(textBox12.Text);
            textBox13.Text = Convert.ToString(toplam);
           
        }
    }
}
