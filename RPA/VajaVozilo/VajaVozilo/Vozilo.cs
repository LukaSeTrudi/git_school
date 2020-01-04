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
    class Kolo : Vozilo
    {
        bool imaBlatnike { get; set; }
        private int stPrestav;
        public int StPrestav
        {
            get
            {
                return stPrestav;
            }
            set
            {
                if((value) > 0)
                {
                    stPrestav = value;
                }
            }
        }
        private int prestava;
        public int Prestava
        {
            get
            {
                return prestava;
            }
            set
            {
                if(((value) > 0) && (value <= stPrestav))
                {
                    prestava = value;
                }
            }
        }
        private char zenskoMosko;
        public char ZenskoMosko
        {
            get
            {
                return zenskoMosko;
            }
            set
            {
                if(value == 'm' || value == 'z')
                {
                    zenskoMosko = value;
                }
            }
        }

        public string pozvoni()
        {
            return ("Cin cin !!!");
        }
        public void vVisjoPrestavo()
        {
            if(prestava + 1 <= stPrestav)
            {
                prestava++;
            }
        }
        public void vNizjoPrestavo()
        {
            if (prestava-1 > 0)
            {
                prestava--;
            }
        }
        public string izpisiLastnosti()
        {
            string str = imeLastnika + " " + priimekLastnika + " " + stPrestav + " " +prestava + " " + imaBlatnike + " " + zenskoMosko;
            return str;
        }

        public Kolo() : base(2, "Janez", "Novak")
        {
        }
        public Kolo(string ime, string priimek) : base(2, ime, priimek)
        {
        }

    }

    class Avto : Vozilo
    {
        private char tipMotorja;
        public char TipMotorja
        {
            get
            {
                return tipMotorja;
            }
            set
            {
                if (value == 'b' || value == 'd')
                {
                    tipMotorja = value;
                }
            }
        }
        public int stVrat;
        public int prostornina;
        public int stPrestav;
        public int prestava;

        public Avto(string ime, string priimek) : base(4, ime, priimek)
        {
            stVrat = 4;
            stPrestav = 6;
        }
        public Avto() : base(4, "Janez", "Novak")
        {
            stVrat = 4;
            stPrestav = 6;
        }

        public string hupaj()
        {
            return ("Bip bip!!!");
        }
        public void vVisjoPrestavo()
        {
            if (prestava + 1 <= stPrestav)
            {
                prestava++;
            }
        }
        public void vNizjoPrestavo()
        {
            if (prestava - 1 > 0)
            {
                prestava--;
            }
        }
        public string izpisiLastnosti()
        {
            string str = tipMotorja + " " + stVrat + " " + prostornina + " " + stPrestav + " " + prestava;
            return str;
        }
        public void zamenjajMotor(int prostor, char tipMotor)
        {
            prostornina = prostor;
            tipMotorja = tipMotor;
        }
    }
    class TerenskiAvto : Avto
    {
        public bool pogon4x4 { get; set; }
    }
    class SportniAvto : Avto
    {
        public double pospesekDo100 { get; set; }
    }
}
