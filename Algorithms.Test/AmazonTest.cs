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
    public class AmazonTest
    {
        #region #1

        [TestMethod()]
        public void Sample1()
        {
            var str = "rose is a flower rose is pond a flower rose flower in garden garden garden pond pond rose is a rose is a rose is a rose is a";
            var excluded = new List<string> { "rose", "is", "a" };
            List<string> expected = new List<string> { "flower", "pond", "garden" };

            var result = Amazon.retrieveMostFrequentlyUsedWords(str, excluded);
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void Sample2()
        {
            var str = "romeo romeo wherefore art thou romeo";
            var excluded = new List<string> { "art", "thou" };
            List<string> expected = new List<string> { "romeo" };

            var result = Amazon.retrieveMostFrequentlyUsedWords(str, excluded);
            CollectionAssert.AreEqual(expected, result);
        }


        [TestMethod()]
        public void Sample3()
        {
            var str = "jack and jill went to the market to buy bread and cheese cheese is jack favorite food";
            var excluded = new List<string> { "and", "he", "the", "to", "is" };
            List<string> expected = new List<string> { "jack", "cheese" };

            var result = Amazon.retrieveMostFrequentlyUsedWords(str, excluded);
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void EmptyString()
        {
            var str = "";
            var excluded = new List<string> { "art", "thou" };
            List<string> expected = new List<string> { };

            var result = Amazon.retrieveMostFrequentlyUsedWords(str, excluded);
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void NullString()
        {
            string str = null;
            var excluded = new List<string> { "art", "thou" };
            List<string> expected = new List<string> { };

            var result = Amazon.retrieveMostFrequentlyUsedWords(str, excluded);
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void NoExclude()
        {
            var str = "jack and jill went to the market to buy bread and cheese cheese is jack favorite food";
            var excluded = new List<string> { };
            List<string> expected = new List<string> { "jack", "and", "to", "cheese" };

            var result = Amazon.retrieveMostFrequentlyUsedWords(str, excluded);
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void NullExclude()
        {
            var str = "jack and jill went to the market to buy bread and cheese cheese is jack favorite food";
            List<string> excluded = null;
            List<string> expected = new List<string> { "jack", "and", "to", "cheese" };

            var result = Amazon.retrieveMostFrequentlyUsedWords(str, excluded);
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void AllExclude()
        {
            var str = "jack and jill";
            List<string> excluded = new List<string> { "jack", "and", "jill" };
            List<string> expected = new List<string> { };

            var result = Amazon.retrieveMostFrequentlyUsedWords(str, excluded);
            CollectionAssert.AreEqual(expected, result);
        }

        #endregion

        #region #2
        [TestMethod()]
        public void reorderLines_1()
        {            
            var logLines = new string[] { "a1 9 2 3 1", "g1 act car", "zo4 4 7", "ab1 off key dog", "a8 act zoo" };
            var expected = new List<string> { "g1 act car", "a8 act zoo", "ab1 off key dog", "a1 9 2 3 1", "zo4 4 7" };

            var result = Amazon.reorderLines(logLines.Length, logLines);
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void reorderLines_2()
        {
            var result = Amazon.MoveIdentifierToLast("a1 9 2 3 1");
            Assert.AreEqual("9 2 3 1 a1", result);
        }
        #endregion
    }
}
