using System;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            Feladat: Olvassuk be egy város nevét.
            Mennyi az adott városhoz tartozó emberek fizetésének az összege?

            szóköz a határoló jel 
            */
            Console.Write("Kérem a várost: ");
            string varos = Console.ReadLine();
            StreamReader fp = new StreamReader("adatok.txt", Encoding.UTF8);
            long sum = 0;
            while(!fp.EndOfStream)
            {
                string sor = fp.ReadLine();
                string[] parts = sor.Split(' '); //parts[0] lesz a név, parts[1] lesz a város és parts[2] a tartozás
                 if (parts[1] == varos)
                sum += int.Parse(parts[2]);
            }

            fp.Close();
            Console.WriteLine($"{sum} a számok összege a {varos} esetén.");
            Console.ReadKey();
        }
    }
}
