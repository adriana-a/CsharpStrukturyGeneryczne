using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Typu_yGeneryczne
{
    class Program
    {
        static void Main(string[] args)
        {


            var kolejka = new KolejkaKołowa(pojemnosc: 3);
            


            while (true)
            {
                var startValue = Console.ReadLine();
                double value = 0;

                if (double.TryParse(startValue, out value))
                {
                    kolejka.Save(value);
                    continue;
                }

                break;

            }

            Console.WriteLine("W naszej kolejce jest:  ");

            while (!kolejka.IsEmpty)
            {
                Console.WriteLine("\t\t" + kolejka.Czytaj()); 
            }

            Console.ReadKey();
        
        }


    }
}
