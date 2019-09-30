using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VajaVozilo
{
    class Vozilo
    {
        public uint stKoles { get; set; }
        public string imeLastnika { get; set; }
        public string priimekLastnika { get; set; }

        public string vrniMe()
        {
            return imeLastnika + " " + priimekLastnika;
        }
        public void zamenjajLastnika(string ime, string priimek)
        {
            imeLastnika = ime;
            priimekLastnika = priimek;
        }


        public Vozilo()
        {
            stKoles = 0;
            imeLastnika = "Janez";
            priimekLastnika = "Novak";
        }
        public Vozilo(uint st)
        {
            stKoles = st;
            imeLastnika = "Janez";
            priimekLastnika = "Novak";
        }
        public Vozilo(uint st, string ime, string priimek)
        {
            stKoles = st;
            imeLastnika = ime;
            priimekLastnika = priimek;
        }
    }
}
