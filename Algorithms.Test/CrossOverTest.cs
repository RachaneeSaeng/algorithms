using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using static Algorithms.Algorithms;

namespace Algorithms.Test
{
    /// <summary>
    ///This is a test class for AlgorithmsTest and is intended
    ///to contain all AlgorithmsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class CrossOverTest
    {
        #region Sort by 1's in binary
       
        [TestMethod()]
        public void Simple()
        {
            int[] arr = { 1, 2, 3 };
            int[] expected = { 1, 2, 3 };
           
            var result = CrossOver.Rearrange(arr);
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void Duplicated()
        {
            int[] arr = { 5, 3, 7, 10, 14 };
            int[] expected = { 3, 5, 10, 7, 14};

            var result = CrossOver.Rearrange(arr);
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void Duplicated_2()
        {
            int[] arr = { 10, 5, 3, 7, 10, 14 };
            int[] expected = { 3, 5, 10, 10, 7, 14 };

            var result = CrossOver.Rearrange(arr);
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void EdgeCase()
        {
            int[] arr = { 10, 5, 3, 0, 10, 14 };
            int[] expected = { 0, 3, 5, 10, 10, 14 };

            var result = CrossOver.Rearrange(arr);
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void EdgeCase_2()
        {
            int[] arr = { 999979999, 999999999, 888888888, 444444444, 111111111, 111111222, 999979998 };
            int[] expected = { 111111222, 111111111, 444444444, 888888888, 999979998, 999999999, 999979999 };

            var result = CrossOver.Rearrange(arr);
            CollectionAssert.AreEqual(expected, result);
        }

        #endregion

        #region Expression balance
        [TestMethod()]
        public void CheckFindingUnbalance_1()
        {
            string[] testStr = {"", "<>>>", "<>>>>", "<>", "<>><" };
            int[] replacements = {1, 2, 2, 2, 1 };
            int[] expectedOutput = { 0, 1, 0, 1, 0 };

            var result = CrossOver.FindUnbalanceCharaters(testStr, replacements);
            CollectionAssert.AreEqual(expectedOutput, result);
        }
        
        #endregion
    }
}
