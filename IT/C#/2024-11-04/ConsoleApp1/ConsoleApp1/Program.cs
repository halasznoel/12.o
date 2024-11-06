using System;
using System.IO;
using System.Text;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Fájl olvasása soronként, amíg nem jutunk el a végére */
            StreamReader fp = new StreamReader("adatok.txt",Encoding.UTF8);
            StreamWriter igen = new StreamWriter("kicsi.txt",false,Encoding.UTF8);
            long sum = 0;
            while(!fp.EndOfStream) //Addig olvasok amíg nem jutok a végére
            {
                string sor = fp.ReadLine(); //Kiolvasom a következő sor
                long szam = long.Parse(sor);

                sum += szam;
                if (szam < 3000) //ha kisebb, mint 3000, akkor kiírom a kicsi.txt-be
                    igen.WriteLine(szam);
                
            }
            fp.Close();
            igen.Close();
            Console.WriteLine($"{sum} a számok összege.");
            Console.ReadKey();

        }
    }
}
