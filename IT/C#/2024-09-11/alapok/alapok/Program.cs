using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alapok
{
    class Program
    {
        static void Main(string[] args)
        {
            //Szöveg beolvasása billentyűzetről és eltárolása egy változóban.
            Console.Write("Kérem adja meg a nevét: ");
            string name = Console.ReadLine();//A ReadLine olvassa be a szöveget
            Console.WriteLine($"Szia {name}!"); //A $-jel hatására a {} között levő kifejezés értéke fog kiíródni
            
            //int típusú érték beolvasása
            Console.Write("Kérem adja meg a fizetését: ");
            int fizu = int.Parse(Console.ReadLine());//int.Parse(szöveg) a szöveget int típusúvá alakítja
            //van long.Parse, byte.Parse stb. is
            if (fizu < 350000)
                Console.WriteLine("Keress új munkahelyet!");
            else
                Console.WriteLine("Nem rossz, de azért még lehet fejlődni.");



            Console.ReadKey();//Vár egy billentyű leütésre
        }
    }
}
