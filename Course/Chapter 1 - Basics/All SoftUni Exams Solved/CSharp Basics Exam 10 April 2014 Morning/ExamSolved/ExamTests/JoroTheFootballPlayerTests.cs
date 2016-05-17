using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExamSolved
{
    [TestClass]
    public class JoroTheFootballPlayerTests
    {
        [TestMethod]
        public void TestingJoroTheFootballPlayer()
        {
            JoroTheFootballPlayer tester = new JoroTheFootballPlayer();
            int result = tester.JoroTheFootballPlayerSolved('t', 1, 1);
            Assert.AreEqual(38, result);

            result = tester.JoroTheFootballPlayerSolved('t', 40, 10);
            Assert.AreEqual(61, result);

            result = tester.JoroTheFootballPlayerSolved('f', 40, 10);
            Assert.AreEqual(58, result);

            result = tester.JoroTheFootballPlayerSolved('t', 100, 30);
            Assert.AreEqual(97, result);

            result = tester.JoroTheFootballPlayerSolved('f', 60, 0);
            Assert.AreEqual(64, result);

            result = tester.JoroTheFootballPlayerSolved('t', 300, 30);
            Assert.AreEqual(197, result);

            result = tester.JoroTheFootballPlayerSolved('f', 100, 10);
            Assert.AreEqual(88, result);

            result = tester.JoroTheFootballPlayerSolved('t', 0, 30);
            Assert.AreEqual(47, result);

            result = tester.JoroTheFootballPlayerSolved('f', 298, 1);
            Assert.AreEqual(184, result);

            result = tester.JoroTheFootballPlayerSolved('t', 199, 47);
            Assert.AreEqual(152, result);
        }
    }
}
