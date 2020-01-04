
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga2_Items
{
    public class Item
    {
        public int bazaId { get; set; }
        public string ItemID { get; set; }
        public string ItemName { get; set; }
        public double Price { get; set; }
        public string type { get; set; }
        public string ItemDesc { get; set; }
        public Item(string name, double price)
        {
            ItemID = null;
            ItemName = name;
            Price = price;
        }
        public Item(string name, string desc, double price)
        {
            ItemID = null;
            ItemName = name;
            Price = price;
            ItemDesc = desc;
        }
        public Item(string id, string name, double price, string _type)
        {
            ItemID = id;
            ItemName = name;
            Price = price;
            type = _type;
        }
        public Item(int baza, string id, string name, double price, string _type)
        {
            bazaId = baza;
            ItemID = id;
            ItemName = name;
            Price = price;
            type = _type;
        }
        public Item()
        {
            ItemID = null;
            ItemName = null;
            Price = 0;
            ItemDesc = null;
        }
        public override string ToString()
        {
            return ItemID + " " + ItemName + " " + Price;
        }
    }
    public class ItemsDatabase
    {
        private SQLiteConnection con;

        public ItemsDatabase()
        {
            con = new SQLiteConnection("data source=itemsDB.db");
            
        }
        public List<Item> ReadItems()
        {
            List<Item> items = new List<Item>();
            using (con)
            {
                con.Open();
                using(SQLiteCommand com = new SQLiteCommand(con))
                {
                    com.CommandText = "SELECT i.id,i.code, i.name, i.price, t.name FROM items i INNER JOIN types t ON t.id = i.type_id";
                    using(SQLiteDataReader reader = com.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Item i = new Item(reader.GetInt32(0),reader.GetString(1), reader.GetString(2), reader.GetDouble(3), reader.GetString(4));
                            items.Add(i);
                        }
                    }
                }
                con.Close();
            }
            return items;
        }
        public void SaveItem(SoftwareItem si)
        {
            using (con)
            {
                con.Open();
                using (SQLiteCommand com = new SQLiteCommand(con))
                {
                    
                    com.CommandText = "INSERT INTO items(name, code, price, sizeInMB, " +
                        "license, version, type_id)" +
                        "VALUES ('"+si.ItemName+"', '"+si.ItemID+"', "+si.Price+", " +
                        si.SizeInMB+", '"+si.LicenseKey+"', '"+si.version+"', 4)";
                    Console.WriteLine(com.CommandText);
                    com.ExecuteNonQuery();
                    com.Dispose();
                }
                con.Close();
            }
        }
        public void SaveItem(HardwareItem si)
        {
            using (con)
            {
                con.Open();
                using (SQLiteCommand com = new SQLiteCommand(con))
                {
                    com.CommandText = "INSERT INTO items(name, code, price, weight, " +
                        ", type_id)" +
                        "VALUES ('" + si.ItemName + "', '" + si.ItemID + "', " + si.Price + ", " +
                        si.weight + ", 1')";
                    com.ExecuteNonQuery();
                    com.Dispose();
                }
                con.Close();
            }
        }
        public void SaveItem(Computer si)
        {
            using (con)
            {
                con.Open();
                using (SQLiteCommand com = new SQLiteCommand(con))
                {
                    com.CommandText = "INSERT INTO items(name, code, price, weight, " +
                        "num_cores, ram, hdd, type_id)" +
                        "VALUES ('" + si.ItemName + "', '" + si.ItemID + "', " + si.Price + ", " +
                        si.weight + ","+si.NoOfCores+", "+si.AmountOfRam+", "+si.HDDSize+", 2)";
                    com.ExecuteNonQuery();
                    com.Dispose();
                }
                con.Close();
            }

        }

        public void SaveItem(Monitor si)
        {
            using (con)
            {
                con.Open();
                using (SQLiteCommand com = new SQLiteCommand(con))
                {
                    com.CommandText = "INSERT INTO items(name, code, price, weight, " +
                        "resolution,size, monitor_type, type_id)" +
                        "VALUES ('" + si.ItemName + "', '" + si.ItemID + "', " + si.Price + ", " +
                        si.weight + ",'"+si.Resolution+"',+"+si.diag+",'"+si.MonitorType+"', 3)";
                    Console.WriteLine(com.CommandText);
                    com.ExecuteNonQuery();
                    com.Dispose();
                }
                con.Close();
            }
        }
        public Item ReadItem(string code)
        {
            Item i = new Item();
            using (con)
            {
                con.Open();
                using(SQLiteCommand com = new SQLiteCommand(con))
                {
                    com.CommandText = "SELECT i.id,i.code, i.name, i.price, t.name FROM items i INNER JOIN types t ON t.id = i.type_id WHERE i.code ='"+ code+"'";
                    using (SQLiteDataReader reader = com.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            i = new Item(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDouble(3), reader.GetString(4));
                        }
                    }
                }
            }
            return i;
        }
        public Monitor ReadMonitor(string code)
        {
            // Monitor(string ime, string _itemId, double _price, double _weight, string diagonala, string _resolution, string _monitorType)
            Monitor m = new Monitor();
            using (con)
            {
                con.Open();
                using (SQLiteCommand com = new SQLiteCommand(con))
                {
                    com.CommandText = "SELECT name, code, price, weight, size, resolution, monitor_type FROM items WHERE code ='" + code + "'";
                    using (SQLiteDataReader reader = com.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            m = new Monitor(reader.GetString(0), reader.GetString(1), reader.GetDouble(2), reader.GetDouble(3), reader.GetDouble(4).ToString(), reader.GetString(5), reader.GetString(6));
                        }
                    }
                }
            }
            return m;
        }
        public Computer ReadComputer(string code)
        {
            // public Computer(string ime, string _itemId, double _price, double _weight, int _cores, int _rams, int _hdd) : base(ime, _itemId, _price, _weight)
            Computer c = new Computer();
            using (con)
            {
                con.Open();
                using (SQLiteCommand com = new SQLiteCommand(con))
                {
                    com.CommandText = "SELECT name, code, price, weight, num_cores, ram, hdd FROM items WHERE code ='" + code + "'";
                    using (SQLiteDataReader reader = com.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            c = new Computer(reader.GetString(0), reader.GetString(1), reader.GetDouble(2), reader.GetDouble(3), reader.GetInt32(4), reader.GetInt32(5), reader.GetInt32(6));
                        }
                    }
                }
            }
            return c;
        }
        public SoftwareItem ReadSoftware(string code)
        {
            // SoftwareItem(string ime, string code, double velikostMB, double _price, string _licenseKey, string version_) : base(code,ime, _price, "Software Item")
            SoftwareItem s = new SoftwareItem();
            using (con)
            {
                con.Open();
                using (SQLiteCommand com = new SQLiteCommand(con))
                {
                    com.CommandText = "SELECT name, code, sizeInMB, price, license, version FROM items WHERE code ='" + code + "'";
                    using (SQLiteDataReader reader = com.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            s = new SoftwareItem(reader.GetString(0), reader.GetString(1), reader.GetDouble(2),reader.GetDouble(3), reader.GetString(4), reader.GetString(5));
                        }
                    }
                }
            }
            return s;
        }
        public void UpdateItem(SoftwareItem si, string code)
        {
            using (con)
            {
                con.Open();
                using (SQLiteCommand com = new SQLiteCommand(con))
                {
                    //                 SoftwareItem si = new SoftwareItem(ime, code, size, price, license, verzija);

                    com.CommandText = "UPDATE items SET name = '"+si.ItemName+"', price = "+si.Price+", sizeInMB="+si.SizeInMB+",license='"+si.LicenseKey+"',version" +
                        "='"+si.version +"' WHERE code = '"+code+"'";
                    com.ExecuteNonQuery();
                    com.Dispose();
                }
                con.Close();
            }
        }
        public void UpdateItem(Computer si, string code)
        {
            using (con)
            {
                con.Open();
                using (SQLiteCommand com = new SQLiteCommand(con))
                {
                    //                 Computer c = new Computer(ime, code, price, teza, cores, ram, hdd);
                    com.CommandText = "UPDATE items SET name='"+si.ItemName+"', price="+si.Price+", weight="+si.weight+",num_cores="+si.NoOfCores +
                        ", ram="+si.AmountOfRam+", hdd="+si.HDDSize+" WHERE code='"+code+"'";
                    com.ExecuteNonQuery();
                    com.Dispose();
                }
                con.Close();
            }

        }

        public void UpdateItem(Monitor si, string code)
        {
            using (con)
            {
                con.Open();
                using (SQLiteCommand com = new SQLiteCommand(con))
                {
                    com.CommandText = "UPDATE items SET name='"+si.ItemName+"', " +
                        ", price="+si.Price+", weight="+si.weight+", " +
                        "resolution='"+si.Resolution+"', monitor_type='"+si.MonitorType+"'" +
                        "WHERE code = "+ code;
                    com.ExecuteNonQuery();
                    com.Dispose();
                }
                con.Close();
            }
        }
        public void RemoveItem(string code)
        {
            using (con)
            {
                con.Open();
                using (SQLiteCommand com = new SQLiteCommand(con))
                {
                    com.CommandText = "DELETE FROM items WHERE code = '" + code + "';";
                    com.ExecuteNonQuery();
                    com.Dispose();
                }
                con.Close();
            }
        }

    }
    public class SoftwareItem : Item
    {
        public string LicenseKey;
        public double SizeInMB;
        public string version;

        public SoftwareItem(string ime, string code, double velikostMB, double _price, string _licenseKey, string version_) : base(code,ime, _price, "Software Item")
        {
            LicenseKey = _licenseKey;
            SizeInMB = velikostMB;
            version = version_;
        }
        public SoftwareItem() { }
        public override string ToString()
        {
            return null;
        }
    }
    public class HardwareItem : Item
    {
        public double weight;
        public HardwareItem()
        {

        }
        public HardwareItem(string ime, string _itemId, double _price, double _weight) : base(_itemId, ime, _price, "Strojna Oprema")
        {
            weight = _weight;
        }
        public override string ToString()
        {
            return null;
        }
    }
    public class Computer : HardwareItem
    {
        public int NoOfCores;
        public int AmountOfRam;
        public int HDDSize;

        public Computer(string ime, string _itemId, double _price, double _weight, int _cores, int _rams, int _hdd) : base(ime, _itemId, _price, _weight)
        {
            NoOfCores = _cores;
            AmountOfRam = _rams;
            HDDSize = _hdd;
        }
        public Computer()
        {

        }
        public override string ToString()
        {
            return null;
        }
    }
    public class Monitor : HardwareItem
    {
        public string Resolution;
        public string MonitorType;
        public string diag;
        public Monitor(string ime, string _itemId, double _price, double _weight, string diagonala, string _resolution, string _monitorType) : base(ime, _itemId, _price, _weight)
        {
            Resolution = _resolution;
            MonitorType = _monitorType;
            diag = diagonala;
        }
        public Monitor()
        {

        }
        public override string ToString()
        {
            return null;
        }
    }


}
