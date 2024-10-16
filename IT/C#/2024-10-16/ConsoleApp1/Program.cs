using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nevek = new List<string>();
            for (int db = 0; db < 5; db++)
            {
                Console.Write("Írj egy nevet: ");
                nevek.Add(Console.ReadLine());
            }
            int i = 0;
            foreach (string nev in nevek)
            {
                i++;
                Console.WriteLine($"{i}. {nev}");
            }
            Console.ReadLine();

            Console.ReadKey();
        }
    }
}
