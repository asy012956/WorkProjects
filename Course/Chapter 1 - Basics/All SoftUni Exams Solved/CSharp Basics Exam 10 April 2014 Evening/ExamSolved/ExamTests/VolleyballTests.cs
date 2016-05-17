using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExamSolved
{
    [TestClass]
    public class VolleyballTests
    {
        [TestMethod]
        public void TestingVolleyball()
        {
            Volleyball tester = new Volleyball();
            int result = tester.VolleyballSolved("leap", 1, 1);
            Assert.AreEqual(42, result);

            result = tester.VolleyballSolved("leap", 40, 10);
            Assert.AreEqual(74, result);

            result = tester.VolleyballSolved("normal", 40, 10);
            Assert.AreEqual(65, result);

            result = tester.VolleyballSolved("leap", 100, 30);
            Assert.AreEqual(126, result);

            result = tester.VolleyballSolved("normal", 60, 0);
            Assert.AreEqual(76, result);

            result = tester.VolleyballSolved("leap", 300, 30);
            Assert.AreEqual(280, result);

            result = tester.VolleyballSolved("normal", 100, 10);
            Assert.AreEqual(105, result);

            result = tester.VolleyballSolved("leap", 0, 30);
            Assert.AreEqual(50, result);

            result = tester.VolleyballSolved("normal", 298, 1);
            Assert.AreEqual(234, result);

            result = tester.VolleyballSolved("leap", 199, 47);
            Assert.AreEqual(207, result);
        }
    }
}
