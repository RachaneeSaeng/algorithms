using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    [TestClass()]
    public class AlgorithmsTests
    {
        /// <summary>
        ///This is a test class for AlgorithmsTest and is intended
        ///to contain all AlgorithmsTest Unit Tests
        ///</summary>
        [TestClass()]
        public class LeetCodeTest
        {
            private Algorithms ag = new Algorithms();

            [TestMethod()]
            public void MaxCoins()
            {
                var result = ag.MaxCoins(new int[] {2,4,1,2,7,8 });

            }

            [TestMethod()]
            public void GetKeyOccurency_Null()
            {
                var result = ag.AllPossibleFBT(7);
            }

            [TestMethod()]
            public void MyAtoi()
            {
                var result = ag.MyAtoi("42");
            }

            [TestMethod()]
            public void Divide()
            {
                var result = ag.Divide(204000, 31);
            }

            [TestMethod()]
            public void UniquePaths()
            {
                var result = ag.UniquePaths(3, 2);
            }

            [TestMethod()]
            public void FindCoinsCombination()
            {
                var result = ag.CoinChange(new int[] {186,419,83,408}, 6249);
            }
        }
    }
}