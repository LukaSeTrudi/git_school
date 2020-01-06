using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Threading.Tasks;

namespace Imenik
{
    public class Imenik
    {
        public string ime { get; set; }
        public List<Oseba> SeznamOseb { get; set; }
        public int st_oseb { get { return SeznamOseb.Count(); } }

        public Imenik(string _ime)
        {
            ime = _ime;
        }
        public static List<string> refreshImeniki()
        {
            List<string> imeniki = new List<string>();
            using (SQLiteConnection conn = new SQLiteConnection("data source= imenik.db"))
            {
                conn.Open();
                using (SQLiteCommand com = new SQLiteCommand(conn))
                {
                    com.CommandText = "SELECT ime FROM imeniki";
                    SQLiteDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        imeniki.Add(reader.GetString(0));
                    }
                    com.Dispose();
                }
                conn.Close();
            }
            return imeniki;
        }
        public void OdpriImenik(string _ime)
        {
            SeznamOseb = new List<Oseba>();
            //         /* - OdpriImenik(imeImenika): iz podatkovne baze prebere osebe za podani imenik in jih shrani v SeznamOseb
            using (SQLiteConnection conn = new SQLiteConnection("data source= imenik.db"))
            {
                conn.Open();
                using(SQLiteCommand com = new SQLiteCommand(conn))
                {
                    com.CommandText = "SELECT o.ime, o.priimek, o.naslov, o.telefonska, o.email FROM osebe o INNER JOIN imeniki i ON i.id = o.imenik_id WHERE i.ime='"+_ime+"';";
                    SQLiteDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        Oseba o = new Oseba(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4));
                        SeznamOseb.Add(o);
                    }
                    com.Dispose();
                }
                conn.Close();
            }
        }
        public static void DodajImenik(string _ime)
        {
            using (SQLiteConnection conn = new SQLiteConnection("data source=imenik.db"))
            {
                conn.Open();
                using(SQLiteCommand com = new SQLiteCommand(conn))
                {
                    com.CommandText = "INSERT INTO imeniki(ime) VALUES ('"+_ime+"')";
                    com.ExecuteNonQuery();
                }
                conn.Close();
            }
            //            - DodajImenik(imeImenika): v podatkovni bazi doda nov imenik (novo tabelo)

        }
        public void DodajOsebo(Oseba o)
        {
            //            - DodajOsebo(novaOseba): v podatkovno bazo doda (v izbrani imenik) novo osebo
            using (SQLiteConnection conn = new SQLiteConnection("data source=imenik.db"))
            {
                conn.Open();
                using (SQLiteCommand com = new SQLiteCommand(conn))
                {
                    com.CommandText = "INSERT INTO osebe(ime,priimek, naslov,telefonska,email,imenik_id) VALUES ('"+o.ime+"','"+o.priimek+"','"+o.naslov+"','"+o.telefonska+"','"+o.email+"'," +
                        "(SELECT id FROM imeniki WHERE ime='"+ime+"'))";
                    com.ExecuteNonQuery();
                }
            }
        }
        public Oseba VrneOsebo(string _ime, string _priimek)
        {
            //            - VrnoOsebo(ime, priimek): vrne osebo (v izbranem imeniku) s podanim imenom in priimkom
            Oseba o = new Oseba("null","null");
            using (SQLiteConnection conn = new SQLiteConnection("data source=imenik.db"))
            {
                conn.Open();
                using (SQLiteCommand com = new SQLiteCommand(conn))
                {
                    com.CommandText = "SELECT o.ime, o.priimek, o.naslov, o.telefonska, o.email FROM osebe o INNER JOIN imeniki i ON i.id = o.imenik_id" +
                        " WHERE o.ime = '"+_ime+"' AND o.priimek='"+_priimek+"' AND i.ime = '"+ime+"'";
                    SQLiteDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        o = new Oseba(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4));
                    }
                }
            }
            return o;
        }
        public void IzbrisiOsebo(string _ime, string _priimek)
        {
            //            - IzbrisiOsebo(ime, priimek): izbriše osebo (v izbranem imeniku) s podanim imenom in priimkom
            using (SQLiteConnection conn = new SQLiteConnection("data source=imenik.db"))
            {
                conn.Open();
                using (SQLiteCommand com = new SQLiteCommand(conn))
                {
                    com.CommandText = "DELETE FROM osebe WHERE ime='"+_ime+"' AND priimek='"+_priimek+"' AND imenik_id=(SELECT id FROM imeniki WHERE ime='"+ime+"')";
                    com.ExecuteNonQuery();
                }
            }
        }
        public void PosodobiOsebo(string _ime, string _priimek, Oseba o)
        {
            //            - PosodobiOsebo(ime, priimek, spremenjenaOseba): posodobi osebo (v izbranem imeniku) s podanim imenom in priimkom
            using (SQLiteConnection conn = new SQLiteConnection("data source=imenik.db"))
            {
                conn.Open();
                using (SQLiteCommand com = new SQLiteCommand(conn))
                {
                    com.CommandText = "UPDATE osebe SET ime='"+o.ime+"', priimek='"+o.priimek+"', naslov='"+o.naslov+"', telefonska='"+o.telefonska+"'," +
                        " email='"+o.email+"' WHERE ime='"+_ime+"' AND priimek='"+_priimek+"' AND imenik_id=(SELECT id FROM imeniki WHERE ime='" + ime + "')";
                    com.ExecuteNonQuery();
                }
            }
        }
        public void SortirajPoPriimku(bool reverse)
        {
            //            - SotrirajPoPriimku(): SeznamOseb sortira po priimku
            SeznamOseb.Clear();
            using (SQLiteConnection conn = new SQLiteConnection("data source= imenik.db"))
            {
                conn.Open();
                using (SQLiteCommand com = new SQLiteCommand(conn))
                {
                    com.CommandText = "SELECT o.ime, o.priimek, o.naslov, o.telefonska, o.email FROM osebe o INNER JOIN imeniki i ON i.id = o.imenik_id WHERE i.ime='" + ime + "' ORDER BY o.priimek ASC;";
                    SQLiteDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        Oseba o = new Oseba(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4));
                        SeznamOseb.Add(o);
                    }
                    com.Dispose();
                }
                conn.Close();
            }
            if(reverse)
                SeznamOseb.Reverse();
        }
        public void SortirajPoImenu(bool reverse)
        {
            //            - SotrirajPoImenu(): SeznamOseb sortira po imenu
            SeznamOseb.Clear();
            using (SQLiteConnection conn = new SQLiteConnection("data source= imenik.db"))
            {
                conn.Open();
                using (SQLiteCommand com = new SQLiteCommand(conn))
                {
                    com.CommandText = "SELECT o.ime, o.priimek, o.naslov, o.telefonska, o.email FROM osebe o INNER JOIN imeniki i ON i.id = o.imenik_id WHERE i.ime='" + ime + "' ORDER BY o.ime ASC;";
                    SQLiteDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        Oseba o = new Oseba(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4));
                        SeznamOseb.Add(o);
                    }
                    com.Dispose();
                }
                conn.Close();
            }
            if (reverse)
                SeznamOseb.Reverse();
        }
    }
    public class Oseba
    {
        public string ime { get; set; }
        public string priimek { get; set; }
        public string naslov { get; set; }
        public string telefonska { get; set; }
        public string email { get; set; }

        public Oseba(string _ime, string _priimek)
        {
            ime = _ime;
            priimek = _priimek;
        }
        public Oseba(string _ime, string _priimek, string _naslov, string _telefonska, string _email):this(_ime, _priimek)
        {
            naslov = _naslov;
            telefonska = _telefonska;
            email = _email;
        }
    }
}
