using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExamSolved
{
    [TestClass]
    public class CinemaTests
    {
        [TestMethod]
        public void TestPremiere()
        {
            Cinema tester = new Cinema();
            string result = tester.CinemaSolved("Premiere", 88, 19);
            Assert.AreEqual("20064.00 leva", result);

            result = tester.CinemaSolved("Premiere", 1, 44);
            Assert.AreEqual("528.00 leva", result);

            result = tester.CinemaSolved("Premiere", 44, 1);
            Assert.AreEqual("528.00 leva", result);

            result = tester.CinemaSolved("Premiere", 80, 20);
            Assert.AreEqual("19200.00 leva", result);

            result = tester.CinemaSolved("Premiere", 133, 6759);
            Assert.AreEqual("10787364.00 leva", result);

            result = tester.CinemaSolved("Premiere", 0, 2325);
            Assert.AreEqual("0.00 leva", result);

            result = tester.CinemaSolved("Premiere", 45784, 0);
            Assert.AreEqual("0.00 leva", result);
        }

        [TestMethod]
        public void TestNormal()
        {
            Cinema tester = new Cinema();
            string result = tester.CinemaSolved("Normal", 56, 23);
            Assert.AreEqual("9660.00 leva", result);

            result = tester.CinemaSolved("Normal", 1, 101);
            Assert.AreEqual("757.50 leva", result);

            result = tester.CinemaSolved("Normal", 200, 300);
            Assert.AreEqual("450000.00 leva", result);

            result = tester.CinemaSolved("Normal", 4369, 9037);
            Assert.AreEqual("296119897.50 leva", result);

            result = tester.CinemaSolved("Normal", 7384538, 1);
            Assert.AreEqual("55384035.00 leva", result);

            result = tester.CinemaSolved("Normal", 0, 2352);
            Assert.AreEqual("0.00 leva", result);

            result = tester.CinemaSolved("Normal", 45723, 0);
            Assert.AreEqual("0.00 leva", result);
        }

        [TestMethod]
        public void TestDiscount()
        {
            Cinema tester = new Cinema();
            string result = tester.CinemaSolved("Discount", 12, 56);
            Assert.AreEqual("3360.00 leva", result);

            result = tester.CinemaSolved("Discount", 223, 436);
            Assert.AreEqual("486140.00 leva", result);

            result = tester.CinemaSolved("Discount", 346346, 2);
            Assert.AreEqual("3463460.00 leva", result);

            result = tester.CinemaSolved("Discount", 1, 384346);
            Assert.AreEqual("1921730.00 leva", result);

            result = tester.CinemaSolved("Discount", 6985621, 1);
            Assert.AreEqual("34928105.00 leva", result);

            result = tester.CinemaSolved("Discount", 0, 24692);
            Assert.AreEqual("0.00 leva", result);

            result = tester.CinemaSolved("Discount", 3896, 0);
            Assert.AreEqual("0.00 leva", result);
        }
    }
}
