using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExamSolved
{
    [TestClass]
    public class ExamTests
    {
        [TestMethod]
        public void MelonsAndWatermelons()
        {
            MelonsAndWatermelons tester = new MelonsAndWatermelons();
            string result = tester.MelonsAndWatermelonsSolved(1, 0);
            Assert.AreEqual("Equal amount: 0", result, "A");

            result = tester.MelonsAndWatermelonsSolved(4, 2);
            Assert.AreEqual("2 more watermelons", result, "B");

            result = tester.MelonsAndWatermelonsSolved(6, 102);
            Assert.AreEqual("2 more melons", result, "C");

            result = tester.MelonsAndWatermelonsSolved(7, 350);
            Assert.AreEqual("Equal amount: 350", result, "D");

            result = tester.MelonsAndWatermelonsSolved(3, 222);
            Assert.AreEqual("1 more watermelons", result, "E");

            result = tester.MelonsAndWatermelonsSolved(5, 555);
            Assert.AreEqual("1 more melons", result, "F");

            result = tester.MelonsAndWatermelonsSolved(2, 1111);
            Assert.AreEqual("1 more melons", result, "G");

            result = tester.MelonsAndWatermelonsSolved(3, 10356);
            Assert.AreEqual("2 more watermelons", result, "H");

            result = tester.MelonsAndWatermelonsSolved(7, 7777);
            Assert.AreEqual("Equal amount: 7777", result, "I");

            result = tester.MelonsAndWatermelonsSolved(4, 100000);
            Assert.AreEqual("2 more watermelons", result, "J");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void MelonsAndWatermelonsFailed()
        {
            MelonsAndWatermelons tester = new MelonsAndWatermelons();
            string result = tester.MelonsAndWatermelonsSolved(-1, 0);
            Assert.AreEqual("Day of week cannot be zero or negative!", result, "A");

            result = tester.MelonsAndWatermelonsSolved(1, -5);
            Assert.AreEqual("The number of days cannot be negative!", result, "B");
        }
    }
}
