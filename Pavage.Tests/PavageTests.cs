using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pavage;

namespace Pavage.Tests
{
    [TestClass]
    public class PavageTests
    {
        [TestMethod]
        public void PavageTest1()
        {
            double fieldLength = 6;
            double fieldWidth = 6;
            double stoneLength = 4;

            double nrOfCubicStones = Pavage.CalculateCubicStones(fieldLength,fieldWidth,stoneLength);

            Assert.AreEqual(4,nrOfCubicStones,"Number of cubic stones needed is not correct");
        }
    }
}
