
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
        public string ItemID { get; set; }
        public string ItemName { get; set; }
        public double Price { get; set; }

        public string ItemDesc { get; set; }
        public Item(string name, string desc, double price)
        {
            ItemID = null;
            ItemName = name;
            Price = price;
            ItemDesc = desc;
        }
        public Item(string id, string name, string desc, double price)
        {
            ItemID = id;
            ItemName = name;
            Price = price;
            ItemDesc = desc;
        }
        public Item()
        {
            ItemID = null;
            ItemName = null;
            Price = 0;
            ItemDesc = null;
        }
        public string ToStr()
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

        public void SaveItem(Item itemToSave)
        {
            using (con)
            {
                con.Open();
                using (SQLiteCommand com = new SQLiteCommand(con))
                {
                    com.CommandText = "INSERT INTO items(name, description, price) VALUES('" + itemToSave.ItemName + "','" + itemToSave.ItemDesc + "'," + itemToSave.Price + ")";
                    com.ExecuteNonQuery();
                    com.Dispose();
                }
                con.Close();
            }
            
        }
        public List<Item> ReadItems()
        {
            List<Item> items = new List<Item>();
            using (con)
            {
                con.Open();
                using (SQLiteCommand com = new SQLiteCommand(con))
                {
                    com.CommandText = "SELECT * FROM items";
                    SQLiteDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        Item newItem = new Item(reader.GetInt32(0).ToString(), reader.GetString(1), reader.GetString(2), reader.GetDouble(3));
                        items.Add(newItem);
                    }
                    com.Dispose();
                }
                con.Close();
            }
            return items;
        }
        public Item ReadItem(int id)
        {
            Item new_item = new Item();
            using (con)
            {
                con.Open();
                using (SQLiteCommand com = new SQLiteCommand(con))
                {
                    com.CommandText = "SELECT * FROM items WHERE id=" +id;
                    SQLiteDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        new_item = new Item(id.ToString(), reader.GetString(1), reader.GetString(2), reader.GetDouble(3));
                    }
                    com.Dispose();
                }
                con.Close();
            }
            return new_item;
        }
        public void UpdateItem(int id, Item itemToUpdate)
        {
            using (con)
            {
                con.Open();
                using (SQLiteCommand com = new SQLiteCommand(con))
                {
                    com.CommandText = "UPDATE items SET name='" + itemToUpdate.ItemName + "', description='" + itemToUpdate.ItemDesc + "', price=" + itemToUpdate.Price + "  WHERE id=" + id;
                    com.ExecuteNonQuery();
                    com.Dispose();
                }
                con.Close();
            }
        }
        public void DeleteItem(int id)
        {
            using (con)
            {
                con.Open();
                using (SQLiteCommand com = new SQLiteCommand(con))
                {
                    com.CommandText = "DELETE FROM items WHERE id=" + id;
                    com.ExecuteNonQuery();
                    com.Dispose();
                }
                con.Close();
            }
        }

    }
}
