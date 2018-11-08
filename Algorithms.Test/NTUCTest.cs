using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System.Collections.Generic;
using static Algorithms.Algorithms;

namespace Algorithms.Test
{
    /// <summary>
    ///This is a test class for AlgorithmsTest and is intended
    ///to contain all AlgorithmsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class NTUCTest
    {
        #region #1


        [TestMethod()]
        public void AllNegative()
        {
            var testData = new int[] { -1, -2 };

            var s = new NTUC();
            var result = s.Solution(testData);
            Assert.AreEqual(1, result);
        }

        [TestMethod()]
        public void AllNegative_Missing()
        {
            var testData = new int[] { -1, -2, 1, 3 };

            var s = new NTUC();
            var result = s.Solution(testData);
            Assert.AreEqual(2, result);
        }

        [TestMethod()]
        public void NoMissing()
        {
            var testData = new int[] { 1, 2, 3 };

            var s = new NTUC();
            var result = s.Solution(testData);
            Assert.AreEqual(4, result);
        }

        [TestMethod()]
        public void HighValue()
        {
            var testData = new int[] { 1, 2, 3 };

            var s = new NTUC();
            var result = s.Solution(testData);
            Assert.AreEqual(4, result);
        }

        [TestMethod()]
        public void Mix()
        {
            var testData = new int[] { 1,1,2,5 };

            var s = new NTUC();
            var result = s.Solution(testData);
            Assert.AreEqual(3, result);
        }

        [TestMethod()]
        public void BigData()
        {
            var testDataSet = new List<int>();
            for (int i = 0; i <= 100000; i++)
            {
                testDataSet.Add(i);
            }

            var s = new NTUC();
            var result = s.Solution(testDataSet.ToArray());
            Assert.AreEqual(100001, result);
        }
        #endregion

    }
}
