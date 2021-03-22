using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _2_KolekcjeGeneryczneTests
{
    [TestClass]
    public class ListaTest
    {
        [TestMethod]
        public void ListWeCanAddAtTheEnd()
        {
            List<int> listOfNumbers = new List<int> { 1, 4, 5 };
            listOfNumbers.Add(5);

            Assert.AreEqual(5, listOfNumbers[3]);
            
    
       }

        [TestMethod]
        public void ListWeCanAddOnPosition()
        {
            List<int> listOfNumbers = new List<int> { 1, 4, 5 };
            listOfNumbers.Insert(2, 6);

            Assert.AreEqual(6, listOfNumbers[2]);

        }


        [TestMethod]
        public void ListWeCanAddRangeOfNumbers()
        {
            List<int> listOfNumbers = new List<int> { 1, 4, 5 };

            var range = new List<int> { 4, 5, 6 };
            listOfNumbers.AddRange(range);

            Assert.AreEqual(6, listOfNumbers[5]);


        }

        [TestMethod]
        public void ListWeCanRemoveAnElement()
        {
            List<int> listOfNumbers = new List<int> { 1, 4, 5 };
            listOfNumbers.Remove(4);

            Assert.IsTrue(listOfNumbers.SequenceEqual(new[] { 1, 5 }));

        }

        [TestMethod]
        public void ListWeCanRemoveAnElementOnPosition()
        {
            List<int> listOfNumbers = new List<int> { 1, 4, 5 };
            listOfNumbers.RemoveAt(0);

            Assert.IsTrue(listOfNumbers.SequenceEqual(new[] { 4, 5 }));

        }

        [TestMethod]
        public void ListWeCanSearchAnIndex()
        {
            List<int> listOfNumbers = new List<int> { 1, 4, 5 };

            Assert.AreEqual(listOfNumbers.IndexOf(5), 2);

        }

        [TestMethod]
        public void ListWeCanSearchIfContains()
        {
            List<int> listOfNumbers = new List<int> { 1, 4, 5 };

            Assert.IsTrue(listOfNumbers.Contains(1));

        }


    }

}
