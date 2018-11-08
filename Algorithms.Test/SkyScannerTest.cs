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
    public class SkyScannerTest
    {
        #region Destintion Poppularity
       
        [TestMethod()]
        public void Simple()
        {
            SkyScanner.OutputMostPopularDestination(2);
        }

        #endregion

    }
}
