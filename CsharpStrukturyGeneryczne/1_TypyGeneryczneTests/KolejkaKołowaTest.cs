using System;
using _1_Typu_yGeneryczne;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _1_TypyGeneryczneTests
{
    [TestClass]
    public class KolejkaKołowaTest
    {
        [TestMethod]
        public void NewKolejkaIsEmpty()
        {
            var kolejka = new KolejkaKołowa<int>();

            Assert.IsTrue(kolejka.IsEmpty);
        }


        [TestMethod]
        public void KolejkaIsNotEmptyAfterFreeSaves()
        {
            var kolejka = new KolejkaKołowa<double>(pojemnosc : 3);
            kolejka.Save(4);
            kolejka.Save(7);
            kolejka.Save(6);

            Assert.IsTrue(kolejka.IsFull);
        }


        [TestMethod]
        public void FirstElementisFirstOut()
        {
            var kolejka = new KolejkaKołowa<double>(pojemnosc: 3);

            var value1 = 6;
            var value2 = 7;
           


            kolejka.Save(value1);
            kolejka.Save(value2);

            Assert.AreEqual(value1, kolejka.Czytaj());
            Assert.AreEqual(value2, kolejka.Czytaj());
            Assert.IsTrue(kolejka.IsEmpty);
        }


        

    }
}
