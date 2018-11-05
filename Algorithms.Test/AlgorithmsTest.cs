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
            int[] arr = { 193, 710, -326, -212, 630, 434, -378, 728, 25, 702, -324, 719, -546, -754, -256, -254, 268, -718, -145, -28, 12, 125, 7, -565, 54, 594, 301, -267, 776, 532, 141, -555, -453, 663, -556, -607, 58, 734, 584, -632, 202, -304, 460, -405, 17, -97, 399, -551, 273, 400, 298, 699, -472, 275, 16, -741, 623, -78, 768, -421, 271, -264, 223, -288, 239, -502, 518, -337, -450, 539, 327, 77, 285, 73, 784, 778, -196, -707, -174, 654, 190, 683, 375, 744, 40, 749, 133, -122, 752, 404, -34, 456, -384, 671, -255, -745, 496, 626, -352, 347, -364, -563, 515, -321, -382, 389, -16, 348, -419, -370, 645, 648, -234, -676, 799, 138, -739, -592, 165, 659, 13, -475, 79, -553, -353, -169, 134, 513, -641, 151, 535, 325, 259, -672, 733, -376, 603, -580, -714, 546, -107, 439, -306, 462, -432, 560, -48, 8, -769, -363, -360, -47, -435, -94, 480, 721, -599, -493, -733, -69, 219, 674, -751, 419, -24, 323, -574, 50, -679, 670, 558, 310, -26, 413, 361, -355, 694, -348, -70, -215, -204, -708, -478, 100, 438, 368, 390, -618, 533, 262, 152, -722, 145, -689, -600, 762, -422, 43, -247, -216, -379, 321, 526, -396, 716, 452, 790, 83, 785, 493, -765, 553, -411, -33, -184, 569, 743, -703, -383, 89, -65, -500, 345, -428, -38, 46, 647, 724, -30, 364, -239, -68, 163, 32, 740, -316, -644, -698, -305, 206, -488, -111, -40, -209, -762, 382, 295, 741, -180, 291, 365, -654, -731, 177, -294, -498, -275, 673, 747, -685, -506, 218, -12, -198, -137, -572, 635, -307, 281, -5, -311, 566, 508, 381, 199, 672, -102, 617, 108, -621, 393, 94, 720, 66, -385, -150, 144, -388, 505, 150, 342, -627, 588, -142, 405, 472, -486, 629, 482, 712, 498, -281, 510, 286, 440, 380, 605, -242, -577, 751, 111, -681, 476, 258, 367, -64, -445, -540, -214, 409, -162, 781, 38, -690, 353, 486, -530, 633, 339, -323, -717, -328, 360, -159, 611, 478, 451, -300, 668, -51, 461, 48, 49, 658, -544, 112, -783, 127, -331, -394, 146, 294, 753, -227, 436, 320, -158, -798, -634, 175, -371, -266, 408, 166, -425, 178, -277, -408, 507, -31, -315, -289, -244, -119, -521, -318, -343, 524, -582, -25, 171, 764, -128, 242, 184, -766, -293, -367, -423, -271, -132, 512, 544, -206, -648, 331, -192, -138, 665, 29 };
            int[] expected = { -798, -783, -769, -766, -765, -762, -754, -751, -745, -741, -739, -733, -731, -722, -718, -717, -714, -708, -707, -703, -698, -690, -689, -685, -681, -679, -676, -672, -654, -648, -644, -641, -634, -632, -627, -621, -618, -607, -600, -599, -592, -582, -580, -577, -574, -572, -565, -563, -556, -555, -553, -551, -546, -544, -540, -530, -521, -506, -502, -500, -498, -493, -488, -486, -478, -475, -472, -453, -450, -445, -435, -432, -428, -425, -423, -422, -421, -419, -411, -408, -405, -396, -394, -388, -385, -384, -383, -382, -379, -378, -376, -371, -370, -367, -364, -363, -360, -355, -353, -352, -348, -343, -337, -331, -328, -326, -324, -323, -321, -318, -316, -315, -311, -307, -306, -305, -304, -300, -294, -293, -289, -288, -281, -277, -275, -271, -267, -266, -264, -256, -255, -254, -247, -244, -242, -239, -234, -227, -216, -215, -214, -212, -209, -206, -204, -198, -196, -192, -184, -180, -174, -169, -162, -159, -158, -150, -145, -142, -138, -137, -132, -128, -122, -119, -111, -107, -102, -97, -94, -78, -70, -69, -68, -65, -64, -51, -48, -47, -40, -38, -34, -33, -31, -30, -28, -26, -25, -24, -16, -12, -5, 7, 8, 12, 13, 16, 17, 25, 29, 32, 38, 40, 43, 46, 48, 49, 50, 54, 58, 66, 73, 77, 79, 83, 89, 94, 100, 108, 111, 112, 125, 127, 133, 134, 138, 141, 144, 145, 146, 150, 151, 152, 163, 165, 166, 171, 175, 177, 178, 184, 190, 193, 199, 202, 206, 218, 219, 223, 239, 242, 258, 259, 262, 268, 271, 273, 275, 281, 285, 286, 291, 294, 295, 298, 301, 310, 320, 321, 323, 325, 327, 331, 339, 342, 345, 347, 348, 353, 360, 361, 364, 365, 367, 368, 375, 380, 381, 382, 389, 390, 393, 399, 400, 404, 405, 408, 409, 413, 419, 434, 436, 438, 439, 440, 451, 452, 456, 460, 461, 462, 472, 476, 478, 480, 482, 486, 493, 496, 498, 505, 507, 508, 510, 512, 513, 515, 518, 524, 526, 532, 533, 535, 539, 544, 546, 553, 558, 560, 566, 569, 584, 588, 594, 603, 605, 611, 617, 623, 626, 629, 630, 633, 635, 645, 647, 648, 654, 658, 659, 663, 665, 668, 670, 671, 672, 673, 674, 683, 694, 699, 702, 710, 712, 716, 719, 720, 721, 724, 728, 733, 734, 740, 741, 743, 744, 747, 749, 751, 752, 753, 762, 764, 768, 776, 778, 781, 784, 785, 790, 799 };
            int minIdx = 0; // TODO: Initialize to an appropriate value
            int maxIdx = arr.Length - 1; // TODO: Initialize to an appropriate value
            Algorithms.QuickSort(arr, minIdx, maxIdx);
            CollectionAssert.AreEqual(expected, arr);
        }

        /// <summary>
        ///A test for QuickSort
        ///</summary>
        [TestMethod()]
        public void QuickSortTest_2()
        {
            // TODO: Initialize to an appropriate value
            int[] arr = { 10, 5, 16, 10, 14 };
            int[] expected = { 5, 10, 10, 14, 16 };
            int minIdx = 0; // TODO: Initialize to an appropriate value
            int maxIdx = arr.Length - 1; // TODO: Initialize to an appropriate value
            Algorithms.QuickSort(arr, minIdx, maxIdx);
            CollectionAssert.AreEqual(expected, arr);
        }

        /// <summary>
        ///A test for QuickSort
        ///</summary>
        [TestMethod()]
        public void QuickSortTest_3()
        {
            // TODO: Initialize to an appropriate value
            int[] arr = { 10, 5, 16, 11, 10, 14 };
            int[] expected = { 5, 10, 10, 11, 14, 16 };
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
        ///A test for InsertionSort
        ///</summary>
        [TestMethod()]
        public void InsertionSortTest()
        {
            int[] arr = { 2, 4, 6, 8, 3 };
            int[] expected = { 2, 3, 4, 6, 8 };
            Algorithms.InsertionSort(arr);
            CollectionAssert.AreEqual(expected, arr);
        }

        /// <summary>
        ///A test for HeapSort
        ///</summary>
        [TestMethod()]
        public void HeapSortTest()
        {
            int[] arr = { 2, 4, 6, 8, 3 };
            int[] expected = { 2, 3, 4, 6, 8 };
            Algorithms.HeapSort(arr);
            CollectionAssert.AreEqual(expected, arr);
        }

        /// <summary>
        ///A test for MergeSort_Recursive
        ///</summary>
        [TestMethod()]
        public void MergeSortRecursiveTest()
        {
            int[] arr = { 2, 4, 1, 8, 3 };
            int[] expected = { 1, 2, 3, 4, 8 };
            int left = 0;
            int right = arr.Length - 1;
            Algorithms.MergeSortRecursive(arr, left, right);
            CollectionAssert.AreEqual(expected, arr);
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
            Algorithms.Sort(arr);
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

        /// <summary>
        /// A test for DayOfProgrammer 
        ///</summary>
        [TestMethod()]
        public void DayOfProgrammer()
        {
            string actual = Algorithms.DayOfProgrammer(2017);
            Assert.AreEqual("13.09.2017", actual);
        }

        /// <summary>
        /// A test for FindGreatXor 
        ///</summary>
        [TestMethod()]
        public void FindGreatXor()
        {
            double actual = Algorithms.FindGreatXor(10);
            Assert.AreEqual(5, actual);
        }

        /// <summary>
        /// A test for GetSmallestLarger 
        ///</summary>
        [TestMethod()]
        public void GetSmallestLarger()
        {
            string actual = Algorithms.GetSmallestLarger("ab");
            Assert.AreEqual("ba", actual);
            actual = Algorithms.GetSmallestLarger("bb");
            Assert.AreEqual("no answer", actual);
            actual = Algorithms.GetSmallestLarger("hefg");
            Assert.AreEqual("hegf", actual);
            actual = Algorithms.GetSmallestLarger("dhck");
            Assert.AreEqual("dhkc", actual);
            actual = Algorithms.GetSmallestLarger("dkhc");
            Assert.AreEqual("hcdk", actual);
        }

        /// <summary>
        /// A test for Elevator 
        ///</summary>
        [TestMethod()]
        public void Elevator()
        {
            List<People> people = new List<People>
            {
                new People {Type = 1, ArriveTime = 2, Floor = 1 },
                new People {Type = 1, ArriveTime = 3, Floor = 1 },
                new People {Type = 2, ArriveTime = 4, Floor = 1 },
                new People {Type = 1, ArriveTime = 5, Floor = 2 },
                new People {Type = 2, ArriveTime = 6, Floor = 2 },
            };
            int actual = Algorithms.Elevator(5, 2, 2, 4, people);
            Assert.AreEqual(10, actual);
        }

        /// <summary>
        /// A test for Elevator 
        ///</summary>
        [TestMethod()]
        public void Elevator1()
        {
            List<People> people = new List<People>
            {
                new People {Type = 1, ArriveTime = 2, Floor = 1 },
                new People {Type = 1, ArriveTime = 3, Floor = 1 },
                new People {Type = 2, ArriveTime = 4, Floor = 1 },
                new People {Type = 1, ArriveTime = 5, Floor = 2 },
                new People {Type = 2, ArriveTime = 6, Floor = 2 },
            };
            int actual = Algorithms.Elevator(5, 3, 2, 4, people);
            Assert.AreEqual(12, actual);

        }

        /// <summary>
        /// A test for Elevator 
        ///</summary>
        [TestMethod()]
        public void Elevator3()
        {
            List<People> people = new List<People>
            {
                new People {Type = 1, ArriveTime = 2, Floor = 1 },
                new People {Type = 1, ArriveTime = 3, Floor = 1 },
                new People {Type = 2, ArriveTime = 4, Floor = 1 },
                new People {Type = 1, ArriveTime = 5, Floor = 2 },
                new People {Type = 2, ArriveTime = 6, Floor = 2 },
            };
            int actual = Algorithms.Elevator(5, 6, 2, 3, people);
            Assert.AreEqual(28, actual);

        }
        /// <summary>
        /// A test for Elevator 
        ///</summary>
        [TestMethod()]
        public void Elevator4()
        {
            List<People> people = new List<People>
            {
                new People {Type = 1, ArriveTime = 2, Floor = 1 },
                new People {Type = 1, ArriveTime = 3, Floor = 1 },
                new People {Type = 2, ArriveTime = 4, Floor = 1 },
                new People {Type = 1, ArriveTime = 5, Floor = 2 },
                new People {Type = 2, ArriveTime = 6, Floor = 2 },
            };
            int actual = Algorithms.Elevator(5, 6, 1, 3, people);
            Assert.AreEqual(44, actual);
        }

        /// <summary>
        /// A test for Elevator 
        ///</summary>
        [TestMethod()]
        public void Elevator5()
        {
            List<People> people = new List<People>
            {
                new People {Type = 2, ArriveTime = 2, Floor = 1 },
                new People {Type = 2, ArriveTime = 3, Floor = 1 },
                new People {Type = 2, ArriveTime = 4, Floor = 1 },
                new People {Type = 2, ArriveTime = 5, Floor = 2 },
                new People {Type = 2, ArriveTime = 6, Floor = 2 },
            };
            int actual = Algorithms.Elevator(5, 2, 2, 3, people);
            Assert.AreEqual(10, actual);
        }


        /// <summary>
        /// A test for Elevator 
        ///</summary>
        [TestMethod()]
        public void Elevator6()
        {
            List<People> people = new List<People>
            {
                new People {Type = 1, ArriveTime = 2, Floor = 1 },
                new People {Type = 1, ArriveTime = 3, Floor = 1 },
                new People {Type = 1, ArriveTime = 4, Floor = 1 },
                new People {Type = 1, ArriveTime = 5, Floor = 2 },
                new People {Type = 1, ArriveTime = 6, Floor = 2 },
            };
            int actual = Algorithms.Elevator(5, 6, 1, 4, people);
            Assert.AreEqual(44, actual);
        }


        /// <summary>
        /// A test for Elevator 
        ///</summary>
        [TestMethod()]
        public void Elevator7()
        {
            List<People> people = new List<People>
            {
                new People {Type = 1, ArriveTime = 2, Floor = 1 },
                new People {Type = 1, ArriveTime = 3, Floor = 1 },
                new People {Type = 1, ArriveTime = 4, Floor = 1 },
                new People {Type = 1, ArriveTime = 5, Floor = 2 },
                new People {Type = 1, ArriveTime = 6, Floor = 2 },
            };
            int actual = Algorithms.Elevator(5, 6, 1, 4, people);
            Assert.AreEqual(44, actual);
        }

        /// <summary>
        /// A test for Elevator 
        ///</summary>
        [TestMethod()]
        public void Elevator8()
        {
            List<People> people = new List<People>
            {
                new People {Type = 1, ArriveTime = 2, Floor = 1 },
            };
            int actual = Algorithms.Elevator(1, 5, 3, 0, people);
            Assert.AreEqual(8, actual);
        }
        /// <summary>
        /// A test for Elevator 
        ///</summary>
        [TestMethod()]
        public void Elevator9()
        {
            List<People> people = new List<People>
            {
                new People {Type = 1, ArriveTime = 2, Floor = 1 },
                new People {Type = 2, ArriveTime = 6, Floor = 1 },
                new People {Type = 2, ArriveTime = 7, Floor = 1 },
                new People {Type = 1, ArriveTime = 13, Floor = 2 },
            };
            int actual = Algorithms.Elevator(4, 3, 2, 3, people);
            Assert.AreEqual(18, actual);
        }

        /// <summary>
        /// A test for Elevator 
        ///</summary>
        [TestMethod()]
        public void Elevator10()
        {
            List<People> people = new List<People>
            {
                new People {Type = 1, ArriveTime = 2, Floor = 1 },
                new People {Type = 2, ArriveTime = 6, Floor = 1 },
                new People {Type = 2, ArriveTime = 7, Floor = 1 },
            };
            int actual = Algorithms.Elevator(3, 3, 2, 1, people);
            Assert.AreEqual(11, actual);

        }

        /// <summary>
        /// A test for Elevator 
        ///</summary>
        [TestMethod()]
        public void Elevator11()
        {
            List<People> people = new List<People>
            {
                new People {Type = 1, ArriveTime = 2, Floor = 1 },
                new People {Type = 2, ArriveTime = 6, Floor = 1 },
                new People {Type = 1, ArriveTime = 7, Floor = 1 },
                new People {Type = 1, ArriveTime = 13, Floor = 2 },
            };
            int actual = Algorithms.Elevator(4, 3, 2, 3, people);
            Assert.AreEqual(18, actual);
        }

        /// <summary>
        /// A test for Elevator 
        ///</summary>
        [TestMethod()]
        public void Elevator12()
        {
            List<People> people = new List<People>
            {
                new People {Type = 1, ArriveTime = 2, Floor = 1 },
                new People {Type = 2, ArriveTime = 6, Floor = 1 },
                new People {Type = 1, ArriveTime = 7, Floor = 1 },
                new People {Type = 1, ArriveTime = 13, Floor = 2 },
            };
            int actual = Algorithms.Elevator(4, 3, 2, 3, people);
            Assert.AreEqual(18, actual);
        }

        [TestMethod()]
        public void HasBalancedBrackets()
        {
            string str = ")([])";
            Assert.IsFalse(Algorithms.HasBalancedBrackets(str));

            str = "([])(";
            Assert.IsFalse(Algorithms.HasBalancedBrackets(str));

            str = "";
            Assert.IsTrue(Algorithms.HasBalancedBrackets(str));

            str = "[({})]<>";
            Assert.IsTrue(Algorithms.HasBalancedBrackets(str));

            str = "[he({lo})eerr]<dfdfe>";
            Assert.IsTrue(Algorithms.HasBalancedBrackets(str));
        }

        [TestMethod()]
        public void BstDistance()
        {
            int[] arr1 = { 5, 6, 3, 4, 2, 1 };
            var distance = Algorithms.BstDistance(arr1, 2, 5);
            Assert.AreEqual(3, distance);

            int[] arr2 = { 10, 11, 9, 8, 5, 12, 6, 3, 4, 2, 1 };
            distance = Algorithms.BstDistance(arr2, 12, 5);
            Assert.AreEqual(4, distance);

            int[] arr3 = { 10, 11, 9, 8, 5, 12, 6, 3, 4, 2, 1 };
            distance = Algorithms.BstDistance(arr3, 12, 20);
            Assert.AreEqual(-1, distance);
        }
        #endregion
    }
}
