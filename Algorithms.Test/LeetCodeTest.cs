using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using static Algorithms.Algorithms;
using System;

namespace Algorithms.Test
{
    /// <summary>
    ///This is a test class for AlgorithmsTest and is intended
    ///to contain all AlgorithmsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class LeetCodeTest
    {
        private LeetCode lc = new LeetCode();

        [TestMethod()]
        public void MaxCoins()
        {
            var result = LeetCode.MaxCoins(new int[] {2,4,1,2,7,8 });

        }

        [TestMethod()]
        public void GetKeyOccurency_Null()
        {
            var result = LeetCode.AllPossibleFBT(7);
        }

        [TestMethod()]
        public void MyAtoi()
        {
            var result = lc.MyAtoi("42");
        }

        [TestMethod()]
        public void Divide()
        {
           var result = lc.Divide(204000, 31);
        }

    }
}
