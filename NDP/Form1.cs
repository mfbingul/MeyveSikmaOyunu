/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2014-2015 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........:proje
**				ÖĞRENCİ ADI............:
**				ÖĞRENCİ NUMARASI.......:
**              DERSİN ALINDIĞI GRUP...:
****************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NDP
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        int random, tmpA,tmpC,tmpSP;
        public Form1()
        {
            InitializeComponent();
        }

        private void basla_button3_Click(object sender, EventArgs e)
        {
            random = r.Next(0, 6);
            pictureBox1.Image = ımageList1.Images[random];
            if (random == 0)
            {
                Elma nesne = new Elma();
                nesne.Pure();
                label1.Text = nesne.MeyveAdi + "\n\nAğirlik - " + nesne.AgirlikGR + "\nVitamin A - " + nesne.Avit + "\nVitamin C - " + nesne.Cvit;
                tmpA = nesne.Avit;
                tmpC = nesne.Cvit;
                tmpSP = nesne.PureAgirlik;
            }
            else if (random == 1)
            {
                Armut nesne = new Armut();
                nesne.Pure();
                label1.Text = nesne.MeyveAdi + "\n\nAğirlik - " + nesne.AgirlikGR + "\nVitamin A - " + nesne.Avit + "\nVitamin C - " + nesne.Cvit;
                tmpA = nesne.Avit;
                tmpC = nesne.Cvit;
                tmpSP = nesne.PureAgirlik;
            }
            else if (random == 2)
            {
                Cilek nesne = new Cilek();
                nesne.Pure();
                label1.Text = nesne.MeyveAdi + "\n\nAğirlik - " + nesne.AgirlikGR + "\nVitamin A - " + nesne.Avit + "\nVitamin C - " + nesne.Cvit;
                tmpA = nesne.Avit;
                tmpC = nesne.Cvit;
                tmpSP = nesne.PureAgirlik;
            }
            else if (random == 3)
            {
                Portakal nesne = new Portakal();
                nesne.Sivi();
                label1.Text = nesne.MeyveAdi + "\n\nAğirlik - " + nesne.AgirlikGR + "\nVitamin A - " + nesne.Avit + "\nVitamin C - " + nesne.Cvit;
                tmpA = nesne.Avit;
                tmpC = nesne.Cvit;
                tmpSP = nesne.PureAgirlik;
            }
            else if (random == 4)
            {
                Mandalina nesne = new Mandalina();
                nesne.Sivi();
                label1.Text = nesne.MeyveAdi + "\n\nAğirlik - " + nesne.AgirlikGR + "\nVitamin A - " + nesne.Avit + "\nVitamin C - " + nesne.Cvit;
                tmpA = nesne.Avit;
                tmpC = nesne.Cvit;
                tmpSP = nesne.PureAgirlik;
            }
            else if (random == 5)
            {
                Greyfurt nesne = new Greyfurt();
                nesne.Sivi();
                label1.Text = nesne.MeyveAdi + "\n\nAğirlik - " + nesne.AgirlikGR + "\nVitamin A - " + nesne.Avit + "\nVitamin C - " + nesne.Cvit;
                tmpA = nesne.Avit;
                tmpC = nesne.Cvit;
                tmpSP = nesne.PureAgirlik;
            }
            timer1.Enabled = true;
            k_button1.Enabled = true;
            s_button2.Enabled = true;
            basla_button3.Enabled = false;
            basla_button3.Text = "60";
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            basla_button3.Text = Convert.ToString(Convert.ToInt32(basla_button3.Text) + (Convert.ToInt32(basla_button3.Text) - Convert.ToInt32(basla_button3.Text) - 1));
            if (basla_button3.Text == "0")
            {
                k_button1.Enabled = false;
                s_button2.Enabled = false;
                basla_button3.Enabled = true;
                basla_button3.Text = "BAŞLA";
                label1.Text = "";
                timer1.Stop();
            }
        }
        
        private void k_button1_Click(object sender, EventArgs e)
        {
            if(random<3)
            {
                textBox1.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) + tmpA);
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox2.Text) + tmpC);
                textBox4.Text = Convert.ToString(Convert.ToInt32(textBox4.Text) + tmpSP);
                random = r.Next(0, 6);
                pictureBox1.Image = ımageList1.Images[random];
                if (random == 0)
                {
                    Elma nesne = new Elma();
                    nesne.Pure();
                    label1.Text = nesne.MeyveAdi + "\n\nAğirlik - " + nesne.AgirlikGR + "\nVitamin A - " + nesne.Avit + "\nVitamin C - " + nesne.Cvit;
                    tmpA = nesne.Avit;
                    tmpC = nesne.Cvit;
                    tmpSP = nesne.PureAgirlik;
                }
                else if (random == 1)
                {
                    Armut nesne = new Armut();
                    nesne.Pure();
                    label1.Text = nesne.MeyveAdi + "\n\nAğirlik - " + nesne.AgirlikGR + "\nVitamin A - " + nesne.Avit + "\nVitamin C - " + nesne.Cvit;
                    tmpA = nesne.Avit;
                    tmpC = nesne.Cvit;
                    tmpSP = nesne.PureAgirlik;
                }
                else if (random == 2)
                {
                    Cilek nesne = new Cilek();
                    nesne.Pure();
                    label1.Text = nesne.MeyveAdi + "\n\nAğirlik - " + nesne.AgirlikGR + "\nVitamin A - " + nesne.Avit + "\nVitamin C - " + nesne.Cvit;
                    tmpA = nesne.Avit;
                    tmpC = nesne.Cvit;
                    tmpSP = nesne.PureAgirlik;
                }
                else if (random == 3)
                {
                    Portakal nesne = new Portakal();
                    nesne.Sivi();
                    label1.Text = nesne.MeyveAdi + "\n\nAğirlik - " + nesne.AgirlikGR + "\nVitamin A - " + nesne.Avit + "\nVitamin C - " + nesne.Cvit;
                    tmpA = nesne.Avit;
                    tmpC = nesne.Cvit;
                    tmpSP = nesne.PureAgirlik;
                }
                else if (random == 4)
                {
                    Mandalina nesne = new Mandalina();
                    nesne.Sivi();
                    label1.Text = nesne.MeyveAdi + "\n\nAğirlik - " + nesne.AgirlikGR + "\nVitamin A - " + nesne.Avit + "\nVitamin C - " + nesne.Cvit;
                    tmpA = nesne.Avit;
                    tmpC = nesne.Cvit;
                    tmpSP = nesne.PureAgirlik;
                }
                else if (random == 5)
                {
                    Greyfurt nesne = new Greyfurt();
                    nesne.Sivi();
                    label1.Text = nesne.MeyveAdi + "\n\nAğirlik - " + nesne.AgirlikGR + "\nVitamin A - " + nesne.Avit + "\nVitamin C - " + nesne.Cvit;
                    tmpA = nesne.Avit;
                    tmpC = nesne.Cvit;
                    tmpSP = nesne.PureAgirlik;
                }
            }
        }
        
        private void s_button2_Click(object sender, EventArgs e)
        {
            if(random>2)
            {
                textBox1.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) + tmpA);
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox2.Text) + tmpC);
                textBox3.Text = Convert.ToString(Convert.ToInt32(textBox3.Text) + tmpSP);
                random = r.Next(0, 6);
                pictureBox1.Image = ımageList1.Images[random];
                if (random == 0)
                {
                    Elma nesne = new Elma();
                    nesne.Pure();
                    label1.Text = nesne.MeyveAdi + "\n\nAğirlik - " + nesne.AgirlikGR + "\nVitamin A - " + nesne.Avit + "\nVitamin C - " + nesne.Cvit;
                    tmpA = nesne.Avit;
                    tmpC = nesne.Cvit;
                    tmpSP = nesne.PureAgirlik;
                }
                else if (random == 1)
                {
                    Armut nesne = new Armut();
                    nesne.Pure();
                    label1.Text = nesne.MeyveAdi + "\n\nAğirlik - " + nesne.AgirlikGR + "\nVitamin A - " + nesne.Avit + "\nVitamin C - " + nesne.Cvit;
                    tmpA = nesne.Avit;
                    tmpC = nesne.Cvit;
                    tmpSP = nesne.PureAgirlik;
                }
                else if (random == 2)
                {
                    Cilek nesne = new Cilek();
                    nesne.Pure();
                    label1.Text = nesne.MeyveAdi + "\n\nAğirlik - " + nesne.AgirlikGR + "\nVitamin A - " + nesne.Avit + "\nVitamin C - " + nesne.Cvit;
                    tmpA = nesne.Avit;
                    tmpC = nesne.Cvit;
                    tmpSP = nesne.PureAgirlik;
                }
                else if (random == 3)
                {
                    Portakal nesne = new Portakal();
                    nesne.Sivi();
                    label1.Text = nesne.MeyveAdi + "\n\nAğirlik - " + nesne.AgirlikGR + "\nVitamin A - " + nesne.Avit + "\nVitamin C - " + nesne.Cvit;
                    tmpA = nesne.Avit;
                    tmpC = nesne.Cvit;
                    tmpSP = nesne.PureAgirlik;
                }
                else if (random == 4)
                {
                    Mandalina nesne = new Mandalina();
                    nesne.Sivi();
                    label1.Text = nesne.MeyveAdi + "\n\nAğirlik - " + nesne.AgirlikGR + "\nVitamin A - " + nesne.Avit + "\nVitamin C - " + nesne.Cvit;
                    tmpA = nesne.Avit;
                    tmpC = nesne.Cvit;
                    tmpSP = nesne.PureAgirlik;
                }
                else if (random == 5)
                {
                    Greyfurt nesne = new Greyfurt();
                    nesne.Sivi();
                    label1.Text = nesne.MeyveAdi + "\n\nAğirlik - " + nesne.AgirlikGR + "\nVitamin A - " + nesne.Avit + "\nVitamin C - " + nesne.Cvit;
                    tmpA = nesne.Avit;
                    tmpC = nesne.Cvit;
                    tmpSP = nesne.PureAgirlik;
                }
            }
        }
    }
}
