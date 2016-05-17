using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoftUniExam10April2014;

namespace VolleyballTestProject
{
    [TestClass]
    public class VolleyballTests
    {
        [TestMethod]
        public void TestZeroesLeap()
        {
            Volleyball runner = new Volleyball();
            int result = runner.CalculateGames("leap", 0, 0);
            Assert.AreEqual(41, result);
        }

        [TestMethod]
        public void TestZeroesNormal()
        {
            Volleyball runner = new Volleyball();
            int result = runner.CalculateGames("normal", 0, 0);
            Assert.AreEqual(36, result);
        }

        [TestMethod]
        public void TestOnesLeap()
        {
            Volleyball runner = new Volleyball();
            int result = runner.CalculateGames("leap", 1, 1);
            Assert.AreEqual(42, result);
        }

        [TestMethod]
        public void TestOnesNormal()
        {
            Volleyball runner = new Volleyball();
            int result = runner.CalculateGames("normal", 1, 1);
            Assert.AreEqual(36, result);
        }

        [TestMethod]
        public void TestRandom1()
        {
            Volleyball runner = new Volleyball();
            int result = runner.CalculateGames("leap", 0, 30);
            Assert.AreEqual(50, result);
        }
    }
}
