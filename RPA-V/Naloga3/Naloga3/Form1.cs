using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Naloga3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Izpis_btn_Click(object sender, EventArgs e)
        {
            IzpisForm izpis_f = new IzpisForm();
            izpis_f.Show();
        }

        private void Dodaj_btn_Click(object sender, EventArgs e)
        {
            dodajForm dodaj_form = new dodajForm();
            dodaj_form.Show();
        }

        private void spremeni_btn_Click(object sender, EventArgs e)
        {
            Spreminjaj aj = new Spreminjaj();
            aj.Show();
        }
    }
}
