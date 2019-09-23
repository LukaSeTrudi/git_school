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
using System.Diagnostics;

namespace Naloga1
{
    public partial class TimeAdd : Form
    {
        int id;
        private Timer delovnikTimer;
        private Timer malicaTimer;
        private DateTime delovnik_startTime = DateTime.MinValue;
        private DateTime malica_startTime = DateTime.MinValue;

        public void fillHistory()
        {
            history_listbox.Items.Clear();
            using (SQLiteConnection conn = new SQLiteConnection("data source=prisotnost.db"))
            {
                conn.Open();
                using (SQLiteCommand com = new SQLiteCommand(conn))
                {
                    com.CommandText = "SELECT c.prihod, c.odhod, t.ime FROM casovnik c INNER JOIN tipi t ON t.id = c.tip_id WHERE c.zaposlen_id = " + id + " ORDER BY c.id DESC";
                    SQLiteDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        history_listbox.Items.Add("Prihod: " + reader.GetString(0));
                        history_listbox.Items.Add("Odhod: " + reader.GetString(1));
                        history_listbox.Items.Add("Tip: " + reader.GetString(2));
                        history_listbox.Items.Add("---------------------------------------------");
                    }
                    com.Dispose();
                }
                conn.Close();
            }
        }

        public void startLogika()
        {
            using (SQLiteConnection conn = new SQLiteConnection("data source=prisotnost.db"))
            {
                conn.Open();
                using (SQLiteCommand com = new SQLiteCommand(conn))
                {
                    com.CommandText = "SELECT MAX(id), prihod, odhod FROM casovnik WHERE tip_id = 2 AND zaposlen_id ="+id;
                    SQLiteDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        try
                        {
                            if (reader.GetString(2).Equals("0"))
                            {
                                delovnik_startTime = Convert.ToDateTime(reader.GetString(1));
                                delovnikTimer.Start();
                                zacni_delovnik.Enabled = false;
                                koncaj_delovnik.Enabled = true;
                                zacni_malico.Enabled = true;
                                koncaj_malico.Enabled = false;
                            }
                        }
                        catch(Exception ex)
                        {
                        }
                    }
                    com.Dispose();
                }
                conn.Close();
            }
            using (SQLiteConnection conn = new SQLiteConnection("data source=prisotnost.db"))
            {
                conn.Open();
                using (SQLiteCommand com = new SQLiteCommand(conn))
                {
                    com.CommandText = "SELECT MAX(id), prihod, odhod FROM casovnik WHERE tip_id = 1 AND zaposlen_id =" + id;
                    SQLiteDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        try
                        {
                            if (reader.GetString(2).Equals("0"))
                            {
                                malica_startTime = Convert.ToDateTime(reader.GetString(1));
                                malicaTimer.Start();
                                koncaj_malico.Enabled = true;
                                zacni_malico.Enabled = false;
                                //koncaj_delovnik.Enabled = false,
                            }
                        }
                        catch (Exception ex)
                        {
                        }
                    }
                    com.Dispose();
                }
                conn.Close();
            }
        }

        private void malicaTimer_tick(object sender, EventArgs e)
        {
            var timeSinceStartTime = DateTime.Now - malica_startTime;
            timeSinceStartTime = new TimeSpan(timeSinceStartTime.Hours,
                                              timeSinceStartTime.Minutes,
                                              timeSinceStartTime.Seconds);
            malica_timer.Text = timeSinceStartTime.ToString();
        }

        private void delovnikTimer_tick(object sender, EventArgs e)
        {
            var timeSinceStartTime = DateTime.Now - delovnik_startTime;
            timeSinceStartTime = new TimeSpan(timeSinceStartTime.Hours,
                                              timeSinceStartTime.Minutes,
                                              timeSinceStartTime.Seconds);
            delovnik_timer.Text = timeSinceStartTime.ToString();
        }

        private void Zacni_delovnik_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection("data source=prisotnost.db"))
            {
                conn.Open();
                using (SQLiteCommand com = new SQLiteCommand(conn))
                {
                    com.CommandText = "INSERT INTO casovnik(prihod, tip_id, zaposlen_id) VALUES('" + DateTime.Now + "', 2, " + id + ")";
                    com.ExecuteNonQuery();
                    com.Dispose();
                }
                conn.Close();
            }
            delovnikTimer.Start();
            zacni_delovnik.Enabled = false;
            koncaj_malico.Enabled = false;
            zacni_malico.Enabled = true;
            koncaj_delovnik.Enabled = true;
            fillHistory();
            startLogika();
        }

        public TimeAdd(int zaposlen_id)
        {
            id = zaposlen_id;
            InitializeComponent();
            delovnikTimer = new Timer();
            delovnikTimer.Interval = 1000;
            delovnikTimer.Tick += new EventHandler(delovnikTimer_tick);
            malicaTimer = new Timer();
            malicaTimer.Interval = 1000;
            malicaTimer.Tick += new EventHandler(malicaTimer_tick);

            zacni_delovnik.Enabled = true;
            koncaj_malico.Enabled = false;
            zacni_malico.Enabled = false;
            koncaj_delovnik.Enabled = false;
            fillHistory();
            startLogika();
        }

        private void Koncaj_delovnik_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection("data source=prisotnost.db"))
            {
                conn.Open();
                using (SQLiteCommand com = new SQLiteCommand(conn))
                {
                    com.CommandText = "UPDATE casovnik SET odhod = '" + DateTime.Now + "' WHERE tip_id = 2 AND zaposlen_id = " + id + ";";
                    com.ExecuteNonQuery();
                    com.Dispose();
                }
                conn.Close();
            }
            delovnikTimer.Stop();
            delovnik_timer.Text = "00:00:00";
            zacni_delovnik.Enabled = true;
            koncaj_malico.Enabled = false;
            zacni_malico.Enabled = false;
            koncaj_delovnik.Enabled = false;
            
            fillHistory();
            startLogika();
        }

        private void Zacni_malico_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection("data source=prisotnost.db"))
            {
                conn.Open();
                using (SQLiteCommand com = new SQLiteCommand(conn))
                {
                    com.CommandText = "INSERT INTO casovnik(prihod, tip_id, zaposlen_id) VALUES('" + DateTime.Now + "', 1, " + id + ")";
                    com.ExecuteNonQuery();
                    com.Dispose();
                }
                conn.Close();
            }
            malicaTimer.Start();
            fillHistory();
            startLogika();
            zacni_delovnik.Enabled = false;
            koncaj_delovnik.Enabled = false;
            zacni_malico.Enabled = false;
            koncaj_malico.Enabled = true;
        }

        private void Koncaj_malico_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection("data source=prisotnost.db"))
            {
                conn.Open();
                using (SQLiteCommand com = new SQLiteCommand(conn))
                {
                    com.CommandText = "UPDATE casovnik SET odhod = '" + DateTime.Now + "' WHERE tip_id = 1 AND zaposlen_id = " + id + ";";
                    com.ExecuteNonQuery();
                    com.Dispose();
                }
                conn.Close();
            }
            malicaTimer.Stop();
            malica_timer.Text = "00:00:00";
            fillHistory();
            startLogika();
            zacni_delovnik.Enabled = false;
            koncaj_delovnik.Enabled = true;
            zacni_malico.Enabled = false;
            koncaj_malico.Enabled = false;
        }
    }
}
