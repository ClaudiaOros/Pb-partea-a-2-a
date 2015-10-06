using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Excel;

namespace ExcelTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ExcelTest1()
        {
            int excelColumnNumber = 700;
            string excelColumnName = Excel.Excel.GetColumnName(excelColumnNumber);

            Assert.AreEqual("ZX",excelColumnName);
        }
    }
}
