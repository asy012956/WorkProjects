using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoftUniExam10April2014;

namespace OddEvenSumTestProject
{
    [TestClass]
    public class OddEvenSumTests
    {
        [TestMethod]
        public void TestZeroesOnly()
        {
            OddEvenSum runner = new OddEvenSum();
            int result = runner.AreOddEvenEqual(4);
            Assert.AreEqual(5, result);
        }
    }
}
