using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Excel;

namespace ExcelTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ExcelBase26Test()
        {
            int excelColumnNumber = 700;
            int baseNumber = 26;
            string excelColumnName = Excel.Excel.GetColumnName(excelColumnNumber, baseNumber);

            Assert.AreEqual("ZX",excelColumnName);
        }

        [TestMethod]
        public void ExcelBase64Test()
        {
            int excelColumnNumber = 12;
            int baseNumber = 64;
            string excelColumnName = Excel.Excel.GetColumnName(excelColumnNumber, baseNumber);

            Assert.AreEqual("L", excelColumnName);
        }

        [TestMethod]
        public void ExcelBase2Test()
        {
            int excelColumnNumber = 351;
            int baseNumber = 2;
            string excelColumnName = Excel.Excel.GetColumnName(excelColumnNumber, baseNumber);

            Assert.AreEqual("ABBAAAAA", excelColumnName);
        }
    }
}
