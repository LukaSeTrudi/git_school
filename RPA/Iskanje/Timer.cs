using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iskanje
{
    public partial class Timer : Form
    {
        DateTime now;
        string smth;
        public Timer()
        {
            InitializeComponent();
        }

        public void Start(string _smth)
        {
            smth = _smth;
            now = DateTime.Now;
        }
       
        public void Stop()
        {
            TimeSpan intr = DateTime.Now - now;
            listBox1.Items.Add(smth + " Total Number of Milliseconds: " + intr.TotalMilliseconds);
            Console.WriteLine(intr.TotalMilliseconds);
            smth = "";
            now = DateTime.Now;

        }

    }
}
