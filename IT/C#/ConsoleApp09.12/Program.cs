using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp09._12
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Olvasson be egy szöveget és tárolja el,
                "Kérem adjon meg egy parancsot (kisebb, nagyobb):"
                Ha nem kisebb és nem nagyobb, akkor írja ki, hogy értelmezhetetlen parancs.
                Ellenkező esetben olvasson be két long típusú számot majd ha a parancs kisebb volt írja
                ki a kisebbik számot, ha a parancs nagyobb volt, akkor írja ki a nagyobbik számot.
                ---------------------------------------------------------
                Kérem adjon meg egy parancsot (kisebb, nagyobb): csiga
                Értelmezhetetlen parancs!
                ---------------------------------------------------------
                Kérem adjon meg egy parancsot (kisebb, nagyobb): kisebb
                Kérem az első számot: 55
                Kérem a második számot: 656

                Az 55 a kisebb szám.
                
                ---------------------------------------------------------
                Kérem adjon meg egy parancsot (kisebb, nagyobb): nagyobb
                Kérem az első számot: 55
                Kérem a második számot: 656

                A 656 a nagyobb szám.
                  
            */

            Console.Write("Kérem adjon meg egy parancsot (kisebb, nagyobb): ");
            string choice = Console.ReadLine();
            Console.Write("Kérem az első számot: ");
            long elso1 = long.Parse(Console.ReadLine());
            Console.Write("Kérem a második számot: ");
            long masodik2 = long.Parse(Console.ReadLine());

            if (choice != "nagyobb" && choice != "kisebb")
                Console.Write("Értelmezhetetlen parancs!");

            else
            {
                if (choice == "nagyobb")

                    if (elso1 > masodik2)
                    {
                        Console.WriteLine($"A(z) {elso1} a nagyobb szám.");
                    }

                    else 
                    {
                        Console.WriteLine($"A(z) {masodik2} a nagoybb szám.");
                    }
                if (choice == "kisebb")
                {
                    if (elso1 < masodik2)
                    {
                        Console.WriteLine($"A(z) {elso1} a kisebb szám.");
                    }
                    else
                    {
                        Console.WriteLine($"A(z) {masodik2} a kisebb szám.");
                    }
                }
            }


            Console.ReadKey();
                
        }
    }
}
