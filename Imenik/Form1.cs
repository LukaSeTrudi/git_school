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
    public partial class Form1 : Form
    {
        Imenik i;
        string sort = "";
        public Form1()
        {
            InitializeComponent();
            loadImenike();
        }
        public void loadImenike()
        {
            comboBox_imeniki.Items.Clear();
            foreach(string ime in Imenik.refreshImeniki())
            {
                comboBox_imeniki.Items.Add(ime);
            }
        }
        private void button_addOseba_Click(object sender, EventArgs e)
        {
            OsebaForm of = new OsebaForm(i, this);
            of.Show();
        }

        private void button_addImenik_Click(object sender, EventArgs e)
        {
            Imenik.DodajImenik(textBox_novImenik.Text);
            textBox_novImenik.Text = "";
            loadImenike();
        }

        private void comboBox_imeniki_SelectedIndexChanged(object sender, EventArgs e)
        {
            i = new Imenik(comboBox_imeniki.SelectedItem.ToString());
            i.OdpriImenik(i.ime);
            groupBox1.Enabled = true;
            RefreshList(i);
            button_editOseba.Enabled = false;
            button_deletOseba.Enabled = false;
        }
        public void RefreshList(Imenik i)
        {
            if (sort == "")
            {
                i.OdpriImenik(i.ime);
            } else if(sort == "NAME")
            {
                i.SortirajPoImenu(false);
            } else if(sort == "LASTNAME")
            {
                i.SortirajPoPriimku(false);
            } else if (sort == "REVERSENAME")
            {
                i.SortirajPoImenu(true);
            } else if (sort == "REVERSELASTNAME")
            {
                i.SortirajPoPriimku(true);
            }
            listBox1.Items.Clear();
            foreach (Oseba o in i.SeznamOseb)
            {
                string neki = o.ime + " " + o.priimek + ", " + o.naslov + ", " + o.telefonska + ", " + o.email;
                listBox1.Items.Add(neki);
            }
            button_editOseba.Enabled = false;
            button_deletOseba.Enabled = false;
        }

        private void button_editOseba_Click(object sender, EventArgs e)
        {
            int l = listBox1.SelectedIndex;
            OsebaForm of = new OsebaForm(i.VrneOsebo(i.SeznamOseb[l].ime, i.SeznamOseb[l].priimek), i, this);
            of.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex > -1)
            {
                button_editOseba.Enabled = true;
                button_deletOseba.Enabled = true;
            }
        }

        private void button_deletOseba_Click(object sender, EventArgs e)
        {
            int l = listBox1.SelectedIndex;
            i.IzbrisiOsebo(i.SeznamOseb[l].ime, i.SeznamOseb[l].priimek);
            RefreshList(i);
        }

        private void button_sortname_Click(object sender, EventArgs e)
        {
            sort = "NAME" == sort ? "REVERSENAME" : "NAME";
            RefreshList(i);
        }

        private void button_sortlast_Click(object sender, EventArgs e)
        {
            sort = "LASTNAME" == sort ? "REVERSELASTNAME" : "LASTNAME";
            RefreshList(i);
        }
    }
}
