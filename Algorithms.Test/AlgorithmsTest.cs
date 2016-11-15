using Algorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
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


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for Algorithms Constructor
        ///</summary>
        [TestMethod()]
        public void AlgorithmsConstructorTest()
        {
            Algorithms target = new Algorithms();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for BinarySearch
        ///</summary>
        [TestMethod()]
        public void BinarySearchTest()
        {
            Algorithms target = new Algorithms(); 
            int[] arr = { 1, 45, 8, 9, 10, 2, 3, 4, 5, 6, 9 }; 
            int val = 4; 
            int expected = 7; 
            int actual = target.BinarySearch(arr, val);
            Assert.AreEqual(expected, actual);            
        }

        /// <summary>
        ///A test for BubleSort
        ///</summary>
        [TestMethod()]
        public void BubleSortTest()
        {
            Algorithms target = new Algorithms(); 
            int[] arr = { 1, 45, 8, 9, 10, 2, 3, 4, 5, 6, 9 };
            int[] expected = { };
            target.BubleSort(arr);
            CollectionAssert.AreEqual(expected, arr);
        }

        /// <summary>
        ///A test for CheckDuplicate1
        ///</summary>
        [TestMethod()]
        public void CheckDuplicate1Test()
        {
            Algorithms target = new Algorithms(); 
            int[] arr1 = { 1, 45, 8, 9, 10, 2, 3, 4, 5, 6, 9 };
            bool expected = true; 
            bool actual = target.CheckDuplicate1(arr1);
            Assert.AreEqual(expected, actual);

            int[] arr2 = { 1, 45, 8, 9, 10, 2, 3, 4, 5, 6 };
            expected = false; 
            actual = target.CheckDuplicate1(arr2);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for CheckDuplicate2
        ///</summary>
        [TestMethod()]
        public void CheckDuplicate2Test()
        {
            Algorithms target = new Algorithms();
            int[] arr1 = { 1, 45, 8, 9, 10, 2, 3, 4, 5, 6, 9 };
            bool expected = true;
            bool actual = target.CheckDuplicate2(arr1);
            Assert.AreEqual(expected, actual);

            int[] arr2 = { 1, 45, 8, 9, 10, 2, 3, 4, 5, 6 };
            expected = false;
            actual = target.CheckDuplicate2(arr2);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for ClockAngle
        ///</summary>
        [TestMethod()]
        public void ClockAngleTest()
        {
            Algorithms target = new Algorithms(); 
            int h = 10; 
            int m = 15; 
            double expected = 142.5F; 
            double actual = target.ClockAngle(h, m);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for DoMerge
        ///</summary>
        [TestMethod()]
        public void DoMergeTest()
        {
            Algorithms target = new Algorithms(); 
            int[] numbers = null; 
            int left = 0; 
            int mid = 0; 
            int right = 0; 
            target.DoMerge(numbers, left, mid, right);
            Assert.Inconclusive("I can't remember what I did in this method anymore. Let find out later.");
        }

        /// <summary>
        ///A test for SetValue
        ///</summary>
        [TestMethod()]
        public void SetValueTest()
        {
            Algorithms target = new Algorithms();
            target.SetValue();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for SetValue
        ///</summary>
        [TestMethod()]
        public void SetValueTest1()
        {
            Algorithms target = new Algorithms(); 
            int y = 0;
            target.SetValue(y);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Factorial
        ///</summary>
        [TestMethod()]
        public void FactorialTest()
        {
            Algorithms target = new Algorithms(); 
            int n = 0; 
            int expected = 0; 
            int actual;
            actual = target.Factorial(n);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Fibonacci
        ///</summary>
        [TestMethod()]
        public void FibonacciTest()
        {
            Algorithms target = new Algorithms(); 
            int n = 0; 
            int expected = 0; 
            int actual;
            actual = target.Fibonacci(n);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FindMin
        ///</summary>
        [TestMethod()]
        public void FindMinTest()
        {
            Algorithms target = new Algorithms(); 
            int[] arr = null; 
            int startIdx = 0; 
            int toIdx = 0; 
            int expected = 0; 
            int actual;
            actual = target.FindMin(arr, startIdx, toIdx);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetTwoBig
        ///</summary>
        [TestMethod()]
        public void GetTwoBigTest()
        {
            Algorithms target = new Algorithms(); 
            int[] arr = null; 
            List<int> expected = null; 
            List<int> actual;
            actual = target.GetTwoBig(arr);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for HanoiTower
        ///</summary>
        [TestMethod()]
        public void HanoiTowerTest()
        {
            Algorithms target = new Algorithms(); 
            int diskNum = 0; 
            int fromTower = 0; 
            int toTower = 0; 
            target.HanoiTower(diskNum, fromTower, toTower);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for IndexOfWord
        ///</summary>
        [TestMethod()]
        public void IndexOfWordTest()
        {
            Algorithms target = new Algorithms(); 
            string str = string.Empty; 
            string word = string.Empty; 
            int expected = 0; 
            int actual;
            actual = target.IndexOfWord(str, word);
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for InsertionSort
        ///</summary>
        [TestMethod()]
        public void InsertionSortTest()
        {
            Algorithms target = new Algorithms(); 
            int[] arr = { 1, 45, 8, 9, 10, 2, 3, 4, 5, 6, 9 }; 
            int[] expected = { 1, 2, 3, 4, 5, 6, 8, 9, 9, 10, 45 };
            target.InsertionSort(arr);
            CollectionAssert.AreEqual(expected, arr);
        }

        /// <summary>
        ///A test for IsPrime
        ///</summary>
        [TestMethod()]
        public void IsPrimeTest()
        {
            Algorithms target = new Algorithms(); 
            int number = 12; 
            //bool expected = false; 
            bool actual;
            actual = target.IsPrime(number);
            Assert.IsFalse(actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Knapsack
        ///</summary>
        [TestMethod()]
        public void KnapsackTest()
        {
            Algorithms target = new Algorithms(); 
            int[] arr = null; 
            int startIdx = 0; 
            int totalWeight = 0; 
            int[] expected = null; 
            int[] actual;
            actual = target.Knapsack(arr, startIdx, totalWeight);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for MergeSort_Recursive
        ///</summary>
        [TestMethod()]
        public void MergeSort_RecursiveTest()
        {
            Algorithms target = new Algorithms(); 
            int[] numbers = null; 
            int left = 0; 
            int right = 0; 
            target.MergeSort_Recursive(numbers, left, right);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for PrintPair
        ///</summary>
        [TestMethod()]
        public void PrintPairTest()
        {
            Algorithms target = new Algorithms(); 
            int[] arr = null; 
            int n = 0; 
            target.PrintPair(arr, n);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Random
        ///</summary>
        [TestMethod()]
        public void RandomTest()
        {
            Algorithms target = new Algorithms(); 
            char expected = '\0'; 
            char actual;
            actual = target.Random();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Random2
        ///</summary>
        [TestMethod()]
        public void Random2Test()
        {
            Algorithms target = new Algorithms(); 
            char expected = '\0'; 
            char actual;
            actual = target.Random2();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ReverseString
        ///</summary>
        [TestMethod()]
        public void ReverseStringTest()
        {
            Algorithms target = new Algorithms(); 
            string str = "abcdefg"; 
            string expected = "gfedcba"; 
            string actual = target.ReverseString(str);
            Assert.AreEqual(expected, actual);

            str = "abcdefgh";
            expected = "hgfedcba";
            actual = target.ReverseString(str);
            Assert.AreEqual(expected, actual);    
        }

        /// <summary>
        ///A test for ReverseString2
        ///</summary>
        [TestMethod()]
        public void ReverseString2Test()
        {
            Algorithms target = new Algorithms();
            string str = "abcdefg";
            string expected = "gfedcba"; 
            string actual = target.ReverseString2(str);
            Assert.AreEqual(expected, actual);

            str = "abcdefgh";
            expected = "hgfedcba";
            actual = target.ReverseString(str);
            Assert.AreEqual(expected, actual); 
        }

        /// <summary>
        ///A test for SelectionSort
        ///</summary>
        [TestMethod()]
        public void SelectionSortTest()
        {
            Algorithms target = new Algorithms(); 
            int[] a = null; 
            target.SelectionSort(a);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for ShellSort
        ///</summary>
        [TestMethod()]
        public void ShellSortTest()
        {
            Algorithms target = new Algorithms(); 
            int[] arr = null; 
            target.ShellSort(arr);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Sort
        ///</summary>
        [TestMethod()]
        public void SortTest()
        {
            Algorithms target = new Algorithms(); 
            int[] arr = null; 
            SortDirection dir = new SortDirection(); 
            target.Sort(arr, dir);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for CompareString
        ///</summary>
        [TestMethod()]
        public void CompareStringTest()
        {
            Algorithms target = new Algorithms(); 
            string str1 = "abc123";
            string str2 = "abc123"; 
            bool expected = true; 
            bool actual = target.CompareString(str1, str2);
            Assert.AreEqual(expected, actual);

            str1 = "abc123";
            str2 = "abc 123";
            expected = false;
            actual = target.CompareString(str1, str2);
            Assert.AreEqual(expected, actual);
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
    }
}
