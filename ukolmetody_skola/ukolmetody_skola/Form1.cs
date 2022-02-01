using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ukolmetody_skola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int pocetprvku;
        public int[] pole;
        public void Generace()
        {
            
            pocetprvku = Int32.Parse(textBox1.Text);
            int x = Int32.Parse(textBox3.Text);
            int y = Int32.Parse(textBox2.Text);
            Random rnd = new Random();
            pole = new int[pocetprvku];
            for (int i = 0; i < pocetprvku; i++)
            {
                int randomcislo = rnd.Next(x, y);
                pole[i] = randomcislo;
            }
        }
        public void Zobrazeni()
        {
            foreach (int cislo in pole)
            {
                listBox1.Items.Add(cislo);
            }
        }
        public void Vypocet()
        {
            int soucet = 0;
            int pocetlichych = 0;
            foreach (int cislo in pole)
            {            
                if (cislo % 2 == 0) {

                    soucet += cislo;
                    
                }
                if (cislo % 2 == 1)
                {
                    pocetlichych++;
                }
            }
            label5.Text = soucet.ToString();
            label6.Text = pocetlichych.ToString();
        }
        public void Rostouci()
        {
            for (int i = 1; i < pocetprvku; i++)
            {
                if (pole[i] < pole[i - 1])
                {
                    label9.Text = "Není to rostoucí pole";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Generace();
            Zobrazeni();
            Vypocet();
            Rostouci();

            /*  int i = 0;
               bool find = false;
               int min = 5;
               while (i < textBox1.Lines.Count() && !find)
               {
                   int cislo = Convert.ToInt32(textBox1.Lines[i]);
                   if(cislo % 2 == 0) { min = cislo; find = true; i++; }

               }*/
        }
    }
}
