using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InterestRate
{
    [TestClass]
    public class InterestRate
    {
        [TestMethod]
        public static double CalculateRate(int loan, double rate, int duration, int rateOfMonth)
        {
            float capital = 0;
            double monthlyRate = 0;
            double rata = 0;
            capital = loan / (duration*12);
            monthlyRate = rate / 12;
            rata = capital + (monthlyRate) / 100 * (loan - capital * rateOfMonth);
            return rata;   
        }
    }
}
