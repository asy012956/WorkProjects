using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zadachi;

namespace CSharpBasicsTests
{
    [TestClass]
    public class Task2Tests
    {
        [TestMethod]
        public void TestGetFibonachiSequenceUntilIfItWorks()
        {
            Task2 runner = new Task2();
            int[] result = runner.GetFibonachiSequenceUntil(10);
            int[] expectedResult = new int[] { 0, 1, 1, -2, 3, 5, -8, 13, 21, -34 };

            Assert.AreEqual(expectedResult.Length, result.Length, "Because the length is not the same!");

            for (int i = 0; i < result.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], result[i]);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestGetFibonachiSequenceUntilWithZero()
        {
            Task2 runner = new Task2();
            int[] result = runner.GetFibonachiSequenceUntil(0);
        }

        [TestMethod]
        public void TestGetFibonachiSequenceUntilWithOnes()
        {
            Task2 runner = new Task2();
            int[] result = runner.GetFibonachiSequenceUntil(1);

            int[] expectedResult = new int[] { 0 };
            CollectionAssert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void TestFibonachiSequenceUntilWithUIntMax()
        {
            Task2 runner = new Task2();
            int[] result = runner.GetFibonachiSequenceUntil(uint.MaxValue);
        }
    }
}
