using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feladat
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Olvasson be egy szöveget és tárolja el. 
            "Kérem adjon meg egy parancsot (kisebb,nagyobb):" 
            Ha nem kisebb és nem nagyobb, akkor írja ki, hogy értelmezehetetlen parancs.
            Ellenkező esetben olvasson be két long típusú számot majd ha a parancs kisebb volt írja ki a kisebbik számot,
            ha a parancs nagyobb volt, akkor írja ki a nagyobbik számot.
            ---------------------------------------------------------
            Kérem adjon meg egy parancsot (kisebb,nagyobb): csiga
            Értelmezhetetlen parancs!
            ----------------------------------------------------------
            Kérem adjon meg egy parancsot (kisebb,nagyobb): kisebb
            Kérem az első számot: 55
            Kérem a második számot:656

            Az 55 a kisebb szám.
            ----------------------------------------------------------
            Kérem adjon meg egy parancsot (kisebb,nagyobb): nagyobb
            Kérem az első számot: 55
            Kérem a második számot:656

            Az 656 a nagyobb szám.
             */

            Console.Write("Kérek egy parancsot (kisebb, nagyobb):");
            string parancs = Console.ReadLine();

            if (parancs != "kisebb" && parancs != "nagyobb")
            {
                Console.WriteLine("Értelmezhetetlen parancs!");

            }
            else
            {
                long a, b;
                Console.Write("Kérem az első számot:");
                a = long.Parse(Console.ReadLine());
                Console.Write("Kérem a második számot:");
                b = long.Parse(Console.ReadLine());
                if(parancs == "kisebb")
                {
                    if(a < b)
                        Console.WriteLine($"A {a} szám volt a kisebb.");
                    else
                        Console.WriteLine($"A {b} szám volt a kisebb.");

                }
                else//nagyobb
                {
                    if (a < b)
                        Console.WriteLine($"A {b} szám volt a nagyobb.");
                    else
                        Console.WriteLine($"A {a} szám volt a nagyobb.");
                }
            }

            Console.ReadKey();
        }
    }
}
