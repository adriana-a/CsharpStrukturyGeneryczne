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


            var kolejka = new KolejkaKołowa<double>(pojemnosc: 3);
            var kolejkaInt = new KolejkaKołowa<int>();





            WprowadzanieDanych(kolejka);

            double suma = PrzetwarzanieDanych(kolejka);

            Console.WriteLine(suma);

            Console.ReadKey();

        }

        private static double PrzetwarzanieDanych(KolejkaKołowa<double> kolejka)
        {
            double suma = 0;
            Console.WriteLine("W naszej kolejce jest:  ");

            while (!kolejka.IsEmpty)
            {

                suma += (double)kolejka.Czytaj();

            }

            return suma;
        }

        private static void WprowadzanieDanych(KolejkaKołowa<double> kolejka)
        {
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
        }
    }





}
