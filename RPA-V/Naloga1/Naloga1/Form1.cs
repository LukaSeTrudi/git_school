using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Naloga1
{
    public partial class Form1 : Form
    {
        public void zaposlen_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Verification ver = new Verification(btn.Name);
            ver.Show();
        }
        public void buildZaposleniList()
        {
            zaposleni_panel.Controls.Clear();
            using (SQLiteConnection conn = new SQLiteConnection("data source=prisotnost.db"))
            {
                conn.Open();
                using (SQLiteCommand com = new SQLiteCommand(conn))
                {
                    com.CommandText = "SELECT * FROM zaposleni";
                    SQLiteDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        Button zaposlen = new Button();
                        zaposlen.Text = reader.GetString(1) + " " + reader.GetString(2);
                        zaposlen.Left = 10;
                        zaposlen.Name = reader.GetInt32(0).ToString();
                        zaposlen.Size = new Size(100,50);
                        zaposlen.Top = 15;
                        zaposlen.Click += zaposlen_click;
                        zaposleni_panel.Controls.Add(zaposlen);

                    }
                    com.Dispose();
                }
                conn.Close();
            }
        }
        public Form1()
        {
            InitializeComponent();
            buildZaposleniList();
        }

        private void Dodaj_zaposlene_Click(object sender, EventArgs e)
        {
            AddWorker add_form = new AddWorker(this);
            add_form.Show();
        }
    }
}
