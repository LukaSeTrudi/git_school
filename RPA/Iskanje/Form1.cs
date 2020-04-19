using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iskanje
{
    public partial class Form1 : Form
    {
        Tab tab;
        Timer tim;
        public Form1()
        {
            InitializeComponent();
            tab = new Tab();
            tim = new Timer();
            tim.Show();
        }

        private void button_dodaj_Click(object sender, EventArgs e)
        {
            tab.Dodaj(Convert.ToInt32(textBox1.Text));
            result.Text = tab.ToString();
        }

        private void button_vsebuje_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tab.Vsebuje(Convert.ToInt32(textBox1.Text)) ? "Ja vsebuje" : "ne vsebuje");
        }

        private void button_min_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tab.Min().ToString());
        }

        private void button_max_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tab.Max().ToString());
        }

        private void button_vsota_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tab.Vsota().ToString());
        }

        private void button_povprecje_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tab.Povprecje().ToString());
        }

        private void button_vsebujebinarno_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(tab.VsebujeBinarno(Convert.ToInt32(textBox1.Text)) ? "Ja vsebuje" : "Ne vsebuje");
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }

        private void button_hitrouredi_Click(object sender, EventArgs e)
        {
            tab.Vstavi();
            result.Text = tab.ToString();
        }

        private void result_Click(object sender, EventArgs e)
        {

        }

        private void button_urediizbiranjem_Click(object sender, EventArgs e)
        {
            tim.Start("UrediIzbiranje");
            tab.Uredi();
            result.Text = tab.ToString();
            tim.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tim.Start("QuickSort");
            tab.QuickSort(0, tab.dolzina-1);
            result.Text = tab.ToString();
            tim.Stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tab.Vstavi();
            tab.QuickSort(0, tab.dolzina - 1);
            result.Text = tab.ToString();
        }

        private void button_uredimehurcki_Click(object sender, EventArgs e)
        {
            tim.Start("BubbleSort");
            tab.Bubble();
            result.Text = tab.ToString();
            tim.Stop();

        }

    }
    public class Tab
    {
        private int[] Tabela;
        public int dolzina;
        public Tab()
        {
            Tabela = new int[1000];
            dolzina = 0;
        }
        public void Dodaj(int x)
        {
            //Dodaj (int x) - število x vstavi na konec tabele in poveča dolžino tabele
            Tabela[dolzina++] = x;
        }

        public bool Vsebuje(int x)
        {
            for (int i = 0; i < dolzina; i++)
            {
                if (Tabela[i] == x)
                    return true;
            }
            //Vsebuje (int x) - vrne true, če tabela vsebuje število x; če ne, vrne false
            return false;
        }
        public override string ToString()
        {
            string l = "";
            //ToString() - vrne elemente tabele, ločene z vejicami
            for (int i = 0; i < dolzina; i++)
            {
                string st = i % 7 == 0 ? "\n" : " ";
                l += Tabela[i] + ", " + st;
            }
            return l;
        }
        public int Vsota()
        {
            int vs = 0;
            //Vsota() - vrne vsoto vseh elementov v tabeli
            for (int i = 0; i < dolzina; i++)
            {
                vs += Tabela[i];
            }
            return vs;
        }
        public int Min()
        {
            int min = Tabela[0];
            //Min() - vrne minimalno število v tabeli
            for (int i = 0; i < dolzina; i++)
            {
                if (min > Tabela[i])
                {
                    min = Tabela[i];
                }
            }
            return min;
        }
        public int Max()
        {
            int max = Tabela[0];
            for (int i = 0; i < dolzina; i++)
            {
                if (max < Tabela[i])
                {
                    max = Tabela[i];
                }
            }
            return max;
            //Max() - vrne maksimalno število v tabeli
        }
        public void Vstavi()
        {
            Random rnd = new Random();
            dolzina = 1000;
            for(int i = 0; i < 1000; i++)
            {
                Tabela[i] = rnd.Next(0, 1000);
            }
        }
        public double Povprecje()
        {
            //Povprečje() - vrne povprečje števil v tabeli
            return Vsota() / dolzina;
        }
        public void Bubble()
        {
            bool zamenjava; 
            int i, tmp;

            do 
            {
                zamenjava = false;

                for (i = 0; i < dolzina-1; i++) 
                {
                    if (Tabela[i] > Tabela[i + 1]) 
                    {
                       
                        tmp = Tabela[i];
                        Tabela[i] = Tabela[i + 1];
                        Tabela[i + 1] = tmp;
                        zamenjava = true; 
                    }
                }
            } 
            while (zamenjava);

        }
        public void QuickSort(int lo, int hi)
        {
            int i = lo, j = hi, h;
            int x = Tabela[(lo + hi) / 2];

            do
            {
                while (Tabela[i] < x) i++;
                while (Tabela[j] > x) j--;
                if (i <= j)
                {
                    h = Tabela[i]; Tabela[i] = Tabela[j]; Tabela[j] = h;
                    i++; j--;
                }
            } while (i <= j);
            if (lo < j) QuickSort(lo, j);
            if (i < hi) QuickSort(i, hi);
        }
        public bool VsebujeBinarno(int x)
        {
            //VsebujeBinarno(int x) - vrne true, če tabela vsebuje število x; če ne, vrne false - z BINARNIM iskanjem

            int min = 0;
            int mid;
            int max = dolzina - 1;
            do
            {
                mid = (min + max) / 2;
                if (x == Tabela[mid])
                    return true;
                else if (x < Tabela[mid])
                    max = mid - 1;
                else
                    min = mid + 1;
            } while (min <= max);
            return false;
        }
        public void Uredi()
        {
            //Uredi() - uredi tabelo z algoritmom Navadno izbiranje
            int temp;

            for (int i = 0; i < dolzina - 1; i++)
                {
                for (int j = i + 1; j < dolzina; j++)
                { 
                    if (Tabela[i] > Tabela[j])
                    {
                        temp = Tabela[i];
                        Tabela[i] = Tabela[j];
                        Tabela[j] = temp;
                    }
                }
            }
        }
        public void DodajInUredi(int x)
        {
            //DodajInUredi(int x) - doda element v tabelo z algoritmom Navadno vstavljanje
        }
        public void UrediMehurcki()
        {
            //UrediMehurcki() - uredi tabelo z algoritmom BubbleSort
        }
    }
}
