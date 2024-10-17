using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listas
{
    class Program
    {
        struct Adat
        {
            public string rendszám;
            public string típus;
            public string szín;
        }
        static void Main(string[] args)
        {
            List<Adat> adatok = new List<Adat>();
            for (int i = 0; i < 4; i++)
            {
                Adat auto;
                Console.Write("Add meg az autó rendszámát: ");
                auto.rendszám = Console.ReadLine();
                Console.Write("Add meg az autó típusát: ");
                auto.típus = Console.ReadLine();
                Console.Write("Add meg az autó színét: ");
                auto.szín = Console.ReadLine();
                adatok.Add(auto);

            }
            foreach (Adat item in adatok)
            {
                Console.WriteLine($"Rendszám: {item.rendszám} Típus: {item.típus} Szín: {item.szín}");
            }
            Console.ReadKey();
        }
    }
}
