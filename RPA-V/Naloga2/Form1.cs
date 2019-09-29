using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Naloga2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_addIzdelek_Click(object sender, EventArgs e)
        {
            form_dodajIzdelek frm = new form_dodajIzdelek();
            frm.Show();
        }

        private void Btn_showIzdelke_Click(object sender, EventArgs e)
        {
            Izdelki izd = new Izdelki();
            izd.Show();
        }

        private void Btn_deleteIzdelke_Click(object sender, EventArgs e)
        {

        }
    }
}
