using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FarmField;

namespace FarmField.Tests
{
    [TestClass]
    public class FarmFieldTests
    {
        [TestMethod]
        public void InitialSurfaceTest1()
        {
            double initialSurface = FarmField.CalculateInitialSurface();

            Assert.AreEqual(592900,initialSurface,"Initial Surface not correct");
        }
    }
}
