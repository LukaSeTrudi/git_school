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
    public partial class Verification : Form
    {
        int id;
        string real_password = "";
        public Verification(string id_str)
        {
            InitializeComponent();
            id = Convert.ToInt32(id_str);
            using (SQLiteConnection conn = new SQLiteConnection("data source=prisotnost.db"))
            {
                conn.Open();
                using (SQLiteCommand com = new SQLiteCommand(conn))
                {
                    com.CommandText = "SELECT geslo, ime, priimek FROM zaposleni WHERE id = " + id;
                    SQLiteDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        real_password = reader.GetString(0);
                        label_name.Text = reader.GetString(1) + " " + reader.GetString(2);
                    }
                    com.Dispose();
                }
                conn.Close();
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(real_password == password_input.Text)
            {
                TimeAdd ad = new TimeAdd(id);
                ad.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Password is not correct");
            }
        }
    }
}
