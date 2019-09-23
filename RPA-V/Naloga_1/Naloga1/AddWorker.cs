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
    public partial class AddWorker : Form
    {
        Form1 frm;
        public AddWorker(Form1 form1)
        {
            InitializeComponent();
            frm = form1;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string name = input_firstname.Text;
            string last_name = input_lastname.Text;
            string birth = date_birth.Value.ToString();
            string joined = date_joined.Value.ToString();
            string pass = input_pass.Text;

            using (SQLiteConnection conn = new SQLiteConnection("data source=prisotnost.db"))
            {
                conn.Open();
                using (SQLiteCommand com = new SQLiteCommand(conn))
                {
                    com.CommandText = "INSERT INTO zaposleni(ime, priimek, geslo, datum_r, datum_pridruzitve) VALUES (" +
                        "'"+name+"','"+last_name+"','"+pass+"','"+birth+"','"+joined+"')";
                    com.ExecuteNonQuery();
                    com.Dispose();
                }
                conn.Close();
            }
            frm.buildZaposleniList();
            this.Close();
        }
    }
}
