using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progik
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int sum = 0;
            int min = int.MaxValue;
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"{i + 1}. szám:");
                number = int.Parse(Console.ReadLine());
                sum += number;
                //minimum rész
                if (number < min)
                {
                    min = number;
                }
            }
            Console.WriteLine($"A számok összege {sum}.\nA számok átlaga {sum / 5}.\nA legkisebb szám {min}.");

            Console.ReadKey();
        }
    }
}
