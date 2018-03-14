using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domaha;

namespace UnitTestHome
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Discount_Above_100()
        {
            TestClass test = new TestClass();
            decimal total = 200;
            var discountedTotal = test.TestCllas(total);

            Assert.AreEqual(total * 0.9M, discountedTotal);
        }
        [TestMethod]
        public void Discount_Between_10_And_100()
        {
            TestClass test = new TestClass();
            decimal TenDollarDiscount = test.TestCllas(10);
            decimal HundredDollarDiscount = test.TestCllas(100);
            decimal FiftyDollarDiscount = test.TestCllas(50);
            Assert.AreEqual(5, TenDollarDiscount, "$10 discount is wrong");
            Assert.AreEqual(95, HundredDollarDiscount, "$100 discount is wrong");
            Assert.AreEqual(45, FiftyDollarDiscount, "$50 discount is wrong");
        }
        [TestMethod]
        public void Discount_Less_Than_10()
        {
            TestClass test = new TestClass();
            decimal discount5 = test.TestCllas(5);
            decimal discount0 = test.TestCllas(0);
            Assert.AreEqual(5, discount5);
            Assert.AreEqual(0, discount0);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Discount_Negative_Total()
        {
            TestClass test = new TestClass();
            test.TestCllas(-1);
        }
    }
}