using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestDiscount
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BigCostWithDiscount_True()
        {
            decimal cost = 10000;
            DateTime date = new DateTime(2022, 10, 29);
            decimal ex = 8900;
            decimal res = Tartuga_Simonov.Clases.SumWithDiscount.Sum(date, cost);
            Assert.AreEqual(res, ex);
        }
        [TestMethod]
        public void SmallCostWithDiscount_True()
        {
            decimal cost = 200;
            DateTime date = new DateTime(2022, 10, 29);
            decimal ex = 178;
            decimal res = Tartuga_Simonov.Clases.SumWithDiscount.Sum(date, cost);
            Assert.AreEqual(res, ex);
        }
        [TestMethod]
        public void DataInCorrect_False()
        {
            decimal cost = 100;
            DateTime date = new DateTime(2022, 10, 20);
            decimal ex = 100;
            decimal res = Tartuga_Simonov.Clases.SumWithDiscount.Sum(date, cost);
            Assert.AreEqual(res, ex);
        }
    }
}
