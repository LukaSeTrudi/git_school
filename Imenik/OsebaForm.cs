using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Imenik
{
    public partial class OsebaForm : Form
    {
        bool spreminjaj = false;
        Imenik im;
        Oseba os;
        Form1 f1;
        public OsebaForm(Imenik i, Form1 f)
        {
            InitializeComponent();
            im = i;
            f1 = f;
        }
        public OsebaForm(Oseba o, Imenik i, Form1 f)
        {
            InitializeComponent();
            textBox_ime.Text = o.ime;
            textBox_priimek.Text = o.priimek;
            textBox_naslov.Text = o.naslov;
            textBox_email.Text = o.email;
            textBox_tel.Text = o.telefonska;
            button_add.Text = "Spremeni";
            spreminjaj = true;
            os = o;
            im = i;
            f1 = f;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            Oseba o = new Oseba(textBox_ime.Text, textBox_priimek.Text, textBox_naslov.Text,
                    textBox_tel.Text, textBox_email.Text);
            if (spreminjaj)
            {
                im.PosodobiOsebo(os.ime, os.priimek, o);
            }
            else
            {
                im.DodajOsebo(o);
            }
            f1.RefreshList(im);
            this.Close();
        }
    }
}
