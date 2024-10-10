using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace halaszn
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             Tároljunk el 5 számot egy tömbben.
            A tömb olyan adatszerkezet, amely több azonos típusú értéket tárolhat és nem bővíthető.
             */

            int[] numbers = new int[5];
            numbers[0] = 500;
            numbers[1] = 1500;
            numbers[2] = 50;
            numbers[3] = 15;
            numbers[4] = 3;

            /* 
             Tömb deklarálása előre megadott értékekkel
             */

            long[] values = {1231,54543,543534512,312342,342342,654654,432,4,655,3,223,54 };
            string[] dumák = new string[5] { "csak","mert","heló","szia","szevasz"};

            /* 
             Lista használata. Nem kell előre megmondani a méretét. Bővíthető.
             */

            List<string> nevek = new List<string>();
            nevek.Add("Cseppcsányi Elemér");
            nevek.Add("Gáspár Laci");
            nevek.Add("Fecó");


            /* 
             Lista deklarálás előre megadott érétkekkel. Bővíthető.
             */

            List<byte> susmus = new List<byte> { 3,5,6,7,4,5,4,3,3};


            /* 
             Feladat:
                Deklaráljon egy 5 elemű int típusú tömböt, majd töltse fel a billenytűzetről beolvasott értékekkel.
             */
            int[] nums = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Adjon meg egy számot! ");
                nums[i] = int.Parse(Console.ReadLine());
            }

            Console.ReadKey();
        }
    }
}
