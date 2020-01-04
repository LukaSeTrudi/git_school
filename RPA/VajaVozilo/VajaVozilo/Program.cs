using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VajaVozilo
{
    class Program
    {
        static void Main(string[] args)
        {
            Vozilo v1 = new Vozilo(); //stKoles nastavi na 0, ime na "Janez", priimek na "Novak"
            Vozilo v2 = new Vozilo(4); //stKoles nastavi na podano vrednost
            Vozilo v3 = new Vozilo(2, "Peter", "Klepec"); //stKoles, ime in priimek nastavi na podane vrednost

            //Console.WriteLine(v1.vrniMe());
            //Console.ReadLine();

            Kolo k1 = new Kolo();
            Kolo k2 = new Kolo("Peter", "Klepec");
            //Console.WriteLine(k2.izpisiLastnosti());
            //Console.ReadLine();

            Avto a1 = new Avto();
            Avto a2 = new Avto("Peter", "Klepec");

            Console.WriteLine(a2.izpisiLastnosti());
            Console.ReadLine();

        }
    }
}
