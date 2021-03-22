using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Typu_yGeneryczne
{
    public class KolejkaKołowa <T>
    {

        private T[] bufor;
        private int startOfBufor;
        private int endOfBufor;

        public KolejkaKołowa() : this(pojemnosc: 5)
        {

        }

        public KolejkaKołowa(int pojemnosc)
        {

            bufor = new T[pojemnosc + 1];
            startOfBufor = 0;
            endOfBufor = 0;

        }


        public void Save(T wartosc)
        {
            bufor[endOfBufor] = wartosc;
            endOfBufor = (endOfBufor + 1) % bufor.Length;

            if (endOfBufor == startOfBufor)
                startOfBufor = (startOfBufor + 1) % bufor.Length;

        }

        public T Czytaj()
        {
            var result = bufor[startOfBufor];
            startOfBufor = (startOfBufor + 1) % bufor.Length;
            return result;


        }

        public int Pojemnosc
        {
            get
            {
                return bufor.Length;
            }

        
        }

        public bool IsEmpty
        {
            get
            {
                return endOfBufor == startOfBufor;
            }
        }

        public bool IsFull
        {
            get
            {
                return (endOfBufor + 1) % bufor.Length == startOfBufor;
            }
        }

    }
}