using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InterestRate;

namespace InterestRate.Tests
{
    [TestClass]
    public class InterestRateTests
    {
        [TestMethod]
        public void InterestRateTest1()
        {
            int loan= 40000;
            double rate= 7.57;
            int duration = 20;
            int rateOfMonth = 39; //luna martie a celui de-al 4-lea an

            double rateToBePaid = InterestRate.CalculateRate(loan, rate, duration, rateOfMonth);
            Assert.AreEqual(377.49,Math.Round(rateToBePaid,2));
        }
    }
}
