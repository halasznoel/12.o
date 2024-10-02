using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelseswitch
{
    class Program
    {
        static void Main(string[] args)
        {
            float súly, magasság, bmi, magasságméterben;

            Console.Write("Kérem adja meg a magasságát cm-ben:");
            magasság = float.Parse(Console.ReadLine());
            Console.Write("Kérem adja meg a súlyát kg-ban:");
            súly = float.Parse(Console.ReadLine());
            magasságméterben = magasság / 100;
            bmi = súly / (magasságméterben * magasságméterben);
            //Ebben a szerkezetben ha az egyik feltétel teljesül a többi ágat már nem nézi meg.
            //Ha egyik if vagy else if ág sem teljesül, akkor az else ág fog mindenféleképpen végrehajtódni.
            if(bmi < 18.5)
                Console.WriteLine("Alulsúlyos");
            else if (bmi < 25)
                Console.WriteLine("Optimális");
            else if (bmi < 30)
                Console.WriteLine("Túlsúlyos");
            else if (bmi < 35)
                Console.WriteLine("Elsőfokú elhízás");
            else if (bmi < 40)
                Console.WriteLine("Másodfokú elhízás");
            else
                Console.WriteLine("Harmadfokú elhízás");

            Console.ReadKey();
        }
    }
}
