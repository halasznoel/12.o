using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {   
            //kampitas.hu letöltések/programozási anyagok/programozasialapok.pps változó típusok, és operátorok (dolgozatban)
            //A változókat deklarálni kell (meg kell mondani, hogy a változónak mi a típusa)
            string duma = "rawr..."; //a duma változó string típusú lesz
            string lala; //a lala változó string típusú, de az értékét még nem adtam meg
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(duma);
            byte magasság = 255;
            magasság++;
            Console.WriteLine(magasság);
            /*0 lesz a magasság, mert a byte típus maximum 255-ig tárolhat. 255 + 1 az ebben az esetben 0 lesz, mert túlcsordul a  változó*/

            int number = 100;
            Console.WriteLine(++number); //előbb növel
            Console.WriteLine(number);
            Console.WriteLine("------------------------------------");
            int number2 = 100;
            Console.WriteLine(number2++); //előbb az eredeti értéket adja eredményül aztán növel
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(number2);

            

            Console.ReadKey();
        }
    }
}
