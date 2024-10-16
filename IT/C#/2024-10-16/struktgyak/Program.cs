using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace struktgyak
{
    class Program
    {
        /*Struktúra használata: összetartozó adatok esetén*/

        struct Adat
        {
            //definiáljuk, hogy milyen mezői vannak a struktúrának (field)
            public string név;
            public string város;
            public int fizetés;
        }

        static void Main(string[] args)
        {
            Adat pista,Feri;
            pista.név = "Savanya István";
            pista.város = "Szeged";
            pista.fizetés = 500000;
            Feri.név = "Fecó";
            Feri.város = "Törökszentmiklós";
            Feri.fizetés = 1200000;

            Console.WriteLine(pista.név);
            Console.WriteLine(Feri.fizetés);

            /*Olyan lista, ami Adat struktúrát tartalmaz */
            List<Adat> adatok = new List<Adat>();
            Adat temp;
            temp.név = "Madaras Fecó";
            temp.város = "Butapest";
            temp.fizetés = 3600000;
            adatok.Add(temp);
            temp.név = "Palik";
            temp.város = "Kecskemét";
            temp.fizetés = 1200000;
            adatok.Add(temp);

            /*Jelenítsük meg az adatok lista tartalmát*/
            foreach (Adat item in adatok)
            {
                Console.WriteLine($"Név: {item.név} Város: {item.város} Fizetés: {item.fizetés}");
            }

            Console.ReadKey();
        }   
    }
}
