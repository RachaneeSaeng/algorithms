using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Algorithms.Test
{
    /// <summary>
    ///This is a test class for AlgorithmsTest and is intended
    ///to contain all AlgorithmsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class AlgorithmsTest
    {
        #region Array
        /// <summary>
        ///A test for CheckDuplicate1
        ///</summary>
        [TestMethod()]
        public void CheckDuplicate1Test()
        {
            int[] arr1 = { 1, 45, 8, 9, 10, 2, 3, 4, 5, 6, 9 };
            bool expected = true;
            bool actual = Algorithms.CheckDuplicate1(arr1);
            Assert.AreEqual(expected, actual);

            int[] arr2 = { 1, 45, 8, 9, 10, 2, 3, 4, 5, 6 };
            expected = false;
            actual = Algorithms.CheckDuplicate1(arr2);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for CheckDuplicate2
        ///</summary>
        [TestMethod()]
        public void CheckDuplicate2Test()
        {
            int[] arr1 = { 1, 45, 8, 9, 10, 2, 3, 4, 5, 6, 9 };
            bool expected = true;
            bool actual = Algorithms.CheckDuplicate2(arr1);
            Assert.AreEqual(expected, actual);

            int[] arr2 = { 1, 45, 8, 9, 10, 2, 3, 4, 5, 6 };
            expected = false;
            actual = Algorithms.CheckDuplicate2(arr2);
            Assert.AreEqual(expected, actual);
        }

        #endregion

        #region Sorting
        /// <summary>
        ///A test for QuickSort
        ///</summary>
        [TestMethod()]
        public void QuickSortTest()
        {
            // TODO: Initialize to an appropriate value
            int[] arr = { 1, 45, 8, 9, 10, 2, 3, 6, 5, 4 };
            int[] expected = { 1, 2, 3, 4, 5, 6, 8, 9, 10, 45 };
            int minIdx = 0; // TODO: Initialize to an appropriate value
            int maxIdx = arr.Length - 1; // TODO: Initialize to an appropriate value
            Algorithms.QuickSort(arr, minIdx, maxIdx);
            CollectionAssert.AreEqual(expected, arr);
        }


        /// <summary>
        ///A test for BubleSort
        ///</summary>
        [TestMethod()]
        public void BubleSortTest()
        {
            int[] arr = { 1, 45, 8, 9, 10, 2, 3, 4, 5, 6, 9 };
            int[] expected = { };
            Algorithms.BubleSort(arr);
            CollectionAssert.AreEqual(expected, arr);
        }

        /// <summary>
        ///A test for FindMin
        ///</summary>
        [TestMethod()]
        public void FindMinTest()
        {
            int[] arr = null;
            int startIdx = 0;
            int toIdx = 0;
            int expected = 0;
            int actual;
            actual = Algorithms.FindMin(arr, startIdx, toIdx);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetTwoBig
        ///</summary>
        [TestMethod()]
        public void GetTwoBigTest()
        {
            int[] arr = null;
            List<int> expected = null;
            List<int> actual;
            actual = Algorithms.GetTwoBig(arr);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for InsertionSort
        ///</summary>
        [TestMethod()]
        public void InsertionSortTest()
        {
            int[] arr = { 1, 45, 8, 9, 10, 2, 3, 4, 5, 6, 9 };
            int[] expected = { 1, 2, 3, 4, 5, 6, 8, 9, 9, 10, 45 };
            Algorithms.InsertionSort(arr);
            CollectionAssert.AreEqual(expected, arr);
        }

        /// <summary>
        ///A test for MergeSort_Recursive
        ///</summary>
        [TestMethod()]
        public void MergeSortRecursiveTest()
        {
            int[] numbers = null;
            int left = 0;
            int right = 0;
            Algorithms.MergeSortRecursive(numbers, left, right);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for SelectionSort
        ///</summary>
        [TestMethod()]
        public void SelectionSortTest()
        {
            int[] a = null;
            Algorithms.SelectionSort(a);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for ShellSort
        ///</summary>
        [TestMethod()]
        public void ShellSortTest()
        {
            int[] arr = null;
            Algorithms.ShellSort(arr);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Sort
        ///</summary>
        [TestMethod()]
        public void SortTest()
        {
            int[] arr = null;
            SortDirection dir = new SortDirection();
            Algorithms.Sort(arr, dir);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        #endregion

        #region Searching
        /// <summary>
        ///A test for BinarySearch
        ///</summary>
        [TestMethod()]
        public void BinarySearchTest()
        {
            int[] arr = { 1, 3, 9, 12, 14, 15, 18, 20, 21, 23, 24, 25, 26, 27, 28, 30 };
            int val = 30;
            int expected = 15;
            int actual = Algorithms.BinarySearch(arr, val);
            Assert.AreEqual(expected, actual);
        }

        #endregion

        #region Distance

        #endregion
        /// <summary>
        ///A test for Factorial
        ///</summary>
        [TestMethod()]
        public void FindClosetPointDistanceTest()
        {
            List<Point> points = new List<Point> {
                new Point(10,6),
                new Point(5,8),
                new Point(3,9),
                new Point(7,4),
                new Point(8,9)
            };
            double expected = Algorithms.FindClosetPointDistanceNormal(points);
            double actual = Algorithms.FindClosetPointDistance(points);
            Assert.AreEqual(expected, actual);
        }

        #region Math
        /// <summary>
        ///A test for Factorial
        ///</summary>
        [TestMethod()]
        public void FactorialTest()
        {
            int n = 0;
            int expected = 0;
            int actual;
            actual = Algorithms.Factorial(n);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Fibonacci
        ///</summary>
        [TestMethod()]
        public void FibonacciTest()
        {
            int n = 0;
            int expected = 0;
            int actual;
            actual = Algorithms.Fibonacci(n);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsPrime
        ///</summary>
        [TestMethod()]
        public void IsPrimeTest()
        {
            int number = 12;
            //bool expected = false; 
            bool actual;
            actual = Algorithms.IsPrime(number);
            Assert.IsFalse(actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for PrintPair
        ///</summary>
        [TestMethod()]
        public void PrintPairTest()
        {
            int[] arr = null;
            int n = 0;
            Algorithms.PrintPair(arr, n);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Random
        ///</summary>
        [TestMethod()]
        public void RandomTest()
        {
            char expected = '\0';
            char actual;
            actual = Algorithms.Random();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Random2
        ///</summary>
        [TestMethod()]
        public void Random2Test()
        {
            char expected = '\0';
            char actual;
            actual = Algorithms.Random2();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for CompareString
        ///</summary>
        [TestMethod()]
        public void GetLogTest()
        {
            int value = 8;
            int baseVal = 2;
            var result = Algorithms.GetLog(value, baseVal);
            Assert.AreEqual(3, result);

            value = 9;
            baseVal = 2;
            result = Algorithms.GetLog(value, baseVal);
            Assert.AreEqual(3, result);

            value = 10;
            baseVal = 10;
            result = Algorithms.GetLog(value, baseVal);
            Assert.AreEqual(1, result);

            value = -10;
            baseVal = 10;
            result = Algorithms.GetLog(value, baseVal);
            Assert.AreEqual(0, result);

            value = 1;
            baseVal = 2;
            result = Algorithms.GetLog(value, baseVal);
            Assert.AreEqual(0, result);

            value = 0;
            baseVal = 2;
            result = Algorithms.GetLog(value, baseVal);
            Assert.AreEqual(0, result);
        }

        #endregion

        #region String
        /// <summary>
        ///A test for IndexOfWord
        ///</summary>
        [TestMethod()]
        public void IndexOfWordTest()
        {
            string str = string.Empty;
            string word = string.Empty;
            int expected = 0;
            int actual;
            actual = Algorithms.IndexOfWord(str, word);
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ReverseString
        ///</summary>
        [TestMethod()]
        public void ReverseStringTest()
        {
            string str = "abcdefg";
            string expected = "gfedcba";
            string actual = Algorithms.ReverseString(str);
            Assert.AreEqual(expected, actual);

            str = "abcdefgh";
            expected = "hgfedcba";
            actual = Algorithms.ReverseString(str);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for ReverseString2
        ///</summary>
        [TestMethod()]
        public void ReverseString2Test()
        {
            string str = "abcdefg";
            string expected = "gfedcba";
            string actual = Algorithms.ReverseString2(str);
            Assert.AreEqual(expected, actual);

            str = "abcdefgh";
            expected = "hgfedcba";
            actual = Algorithms.ReverseString(str);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for CompareString
        ///</summary>
        [TestMethod()]
        public void CompareStringTest()
        {
            string str1 = "abc123";
            string str2 = "abc123";
            bool expected = true;
            bool actual = Algorithms.CompareString(str1, str2);
            Assert.AreEqual(expected, actual);

            str1 = "abc123";
            str2 = "abc 123";
            expected = false;
            actual = Algorithms.CompareString(str1, str2);
            Assert.AreEqual(expected, actual);
        }

        #endregion

        #region Other

        /// <summary>
        ///A test for Knapsack
        ///</summary>
        [TestMethod()]
        public void KnapsackTest()
        {
            int[] arr = { 25, 3, 5, 9, 21, 12 };
            int startIdx = 0;
            int totalWeight = 20;
            int[] expected = { 3, 5, 12 };
            int[] actual = Algorithms.Knapsack(arr, startIdx, totalWeight);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for ClockAngle
        ///</summary>
        [TestMethod()]
        public void ClockAngleTest()
        {
            int h = 10;
            int m = 15;
            double expected = 142.5F;
            double actual = Algorithms.ClockAngle(h, m);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for HanoiTower 
        ///</summary>
        [TestMethod()]
        public void HanoiTowerTest()
        {
            int diskNum = 0;
            int fromTower = 0;
            int toTower = 0;
            Algorithms.HanoiTower(diskNum, fromTower, toTower);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        /// A test for HanoiTower 
        ///</summary>
        [TestMethod()]
        public void FindKey()
        {           
            var actual = Algorithms.FindKey();
            Assert.AreEqual("042", actual);
        }

        #endregion
    }
}
