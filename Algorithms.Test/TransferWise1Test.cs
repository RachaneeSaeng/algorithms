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
    public class TransferWise1Test
    {
        [TestMethod()]
        public void Simple()
        {
            var result = TransferWise1.Method1();
            Assert.AreEqual(1, result);
        }

    }
}
