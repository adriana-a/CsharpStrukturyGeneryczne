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
            var kolejka = new KolejkaKołowa();

            Assert.IsTrue(kolejka.IsEmpty);
        }


        [TestMethod]
        public void KolejkaIsNotEmptyAfterFreeSaves()
        {
            var kolejka = new KolejkaKołowa(pojemnosc : 3);
            kolejka.Save(4);
            kolejka.Save(7);
            kolejka.Save(6);

            Assert.IsTrue(kolejka.IsFull);
        }


        [TestMethod]
        public void FirstElementisFirstOut()
        {
            var kolejka = new KolejkaKołowa(pojemnosc: 3);

            var value1 = 6;
            var value2 = 7;
           


            kolejka.Save(value1);
            kolejka.Save(value2);

            Assert.AreEqual(value1, kolejka.Czytaj());
            Assert.AreEqual(value2, kolejka.Czytaj());
            Assert.IsTrue(kolejka.IsEmpty);
        }


        [TestMethod]
        public void OverwriteWhenIsBiggerThanPojemnosc()
        {
            var kolejka = new KolejkaKołowa(pojemnosc: 3);

            var value = new[] { 1, 2, 3, 4, 5, 6}; 
          
            foreach (var item in value)
            {
                kolejka.Save(item);
            }

            Assert.IsTrue(kolejka.IsFull);
            Assert.AreEqual(value[3], kolejka.Czytaj());
            Assert.AreEqual(value[4], kolejka.Czytaj());
            Assert.AreEqual(value[5], kolejka.Czytaj());

            Assert.IsTrue(kolejka.IsEmpty);



        }

    }
}
