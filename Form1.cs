using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ilgi_yarışması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        int soruno = 0, dogru = 0, yanlış = 0;

        private void BtnB_Click(object sender, EventArgs e)
        {
            button5.Enabled = true;
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;

           
            if (label5.Text == BtnB.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                BtnA.BackColor = Color.Red;
                BtnB.BackColor = Color.Green;
                BtnC.BackColor = Color.Red;
                BtnD.BackColor = Color.Red;
                

            }
            else
            {
                yanlış++;
                LblYanlış.Text = yanlış.ToString();
                BtnB.BackColor = Color.Red;

            }





        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            button5.Enabled = true;
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;

            
            if (label5.Text == BtnC.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                BtnA.BackColor = Color.Red;
                BtnB.BackColor = Color.Red;
                BtnC.BackColor = Color.Green;
                BtnD.BackColor = Color.Red;

            }
            else
            {
                yanlış++;
                LblYanlış.Text = yanlış.ToString();
                BtnC.BackColor = Color.Red;

            }
        }

        private void BtnD_Click(object sender, EventArgs e)
        {
            button5.Enabled = true;
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;

            
            if (label5.Text == BtnD.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                BtnA.BackColor = Color.Red;
                BtnB.BackColor = Color.Red;
                BtnC.BackColor = Color.Red;
                BtnD.BackColor = Color.Green;


            }
            else
            {
                yanlış++;
                LblYanlış.Text = yanlış.ToString();
                BtnD.BackColor = Color.Red;


            }
        }

        private void BtnA_Click(object sender, EventArgs e)
        {
            button5.Enabled = true;
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;

            
            if (label5.Text==BtnA.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                BtnA.BackColor = Color.Green;
                BtnB.BackColor = Color.Red;
                BtnC.BackColor = Color.Red;
                BtnD.BackColor = Color.Red;


            }
            else
            {
                yanlış++;
                LblYanlış.Text = yanlış.ToString();
                BtnA.BackColor = Color.Red;
                


            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Enabled = false;
            BtnA.Enabled = true;
            BtnB.Enabled = true;
            BtnC.Enabled = true;
            BtnD.Enabled = true;
            soruno++;
            LblSoruno.Text = soruno.ToString();

            if (soruno==1)
            {
                richTextBox1.Text = "CUMHURİYET KAÇ YILINDA İLAN EDİLDİ ? ";
                BtnA.Text= "1920";
                BtnB.Text = "1923";
                BtnC.Text = "1922";
                BtnD.Text = "1921";
                label5.Text = "1923";
                BtnA.BackColor = Color.White;
                BtnB.BackColor = Color.White;
                BtnC.BackColor = Color.White;
                BtnD.BackColor = Color.White;


            }
            if (soruno == 2)
            {
                richTextBox1.Text = "HANGİ İLİMİZ EGE BÖLGESİNDE DEGİLDİR ? ";
                BtnA.Text = "MANİSA";
                BtnB.Text = "İZMİR";
                BtnC.Text = "BALIKESİR";
                BtnD.Text = "AYDIN";
                label5.Text = "BALIKESİR";
                BtnA.BackColor = Color.White;
                BtnB.BackColor = Color.White;
                BtnC.BackColor = Color.White;
                BtnD.BackColor = Color.White;

            }

            if (soruno == 3)
            {
                richTextBox1.Text = "ÇALIKUŞU HANGİ YAZAMIZA AİTTİR ? ";
                BtnA.Text = "REŞAT NURİ";
                BtnB.Text = "PEYAMİ SAFA";
                BtnC.Text = "HALİDE EDİP";
                BtnD.Text = "MEHMET AKİF ";
                label5.Text = "REŞAT NURİ";
                button5.Text = "SONUÇLAR";
                BtnA.BackColor = Color.White;
                BtnB.BackColor = Color.White;
                BtnC.BackColor = Color.White;
                BtnD.BackColor = Color.White;
            }
            if (soruno==4)
            {
                BtnA.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;
                button5.Enabled = false;
                MessageBox.Show("DOGRU : "  + dogru + "\n" + "YANLIŞ : " + yanlış + "\n" );
            }
        }
    }
}
