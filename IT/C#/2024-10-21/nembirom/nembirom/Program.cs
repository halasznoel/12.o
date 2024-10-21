using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace szovegfajlbairas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            /* 2020 óta List<int> numbers2 = new() */

            string nevek = "Horvát-Fock Erik Tamás, Juhász Lajos Csaba, Terbán Kamilla";
            //szeretnénk szétválasztani a ,-vel tagolt elemeket
            string[] names = nevek.Split(','); //a split parancs egy tömböt ad eredményül Split('határolójel');

            //Írjuk ki a neveket egy szövegfájlba
            StreamWriter fp = new StreamWriter("nevek.txt",false,Encoding.UTF8); //false jelenti, hogy nem hozzáfűzés (append) van hanem törlődik a file tartalma
            foreach (var item in names) //a names tömb minden elemét végigolvasom, a lista elemei egymás után az item változóba kerülnek
            {
                fp.WriteLine(item);
            }
            fp.Close();

            Console.ReadKey();
        }
    }
}
