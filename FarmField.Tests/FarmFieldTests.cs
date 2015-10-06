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
            int width = 230;
            int totalSurface = 770000;
            int a = 1;
            double initialSurface = FarmField.CalculateInitialSurface(a, width, -totalSurface);

            Assert.AreEqual(592900,initialSurface,"Initial Surface not correct");
        }
    }
}
