using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Items
{
    public class Item
    {
        private string ItemID { get; set; }
        private string ItemName { get; set; }
        private double Price { get; set; }
        public Item(string id, string name, double price)
        {
            ItemID = id;
            ItemName = name;
            Price = price;
        }
        public string ToStr()
        {
            return ItemID + " " + ItemName + " " + Price;
        }
    }
    public class ItemsDatabase
    {
        private SQLiteConnection con;
    }
}
