using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExamSolved
{
    [TestClass]
    public class ExamTests
    {
        [TestMethod]
        public void CartesianTests()
        {
            CartesianCoordinateSystem tester = new CartesianCoordinateSystem();
            int result = tester.CartesianSolved(0, 0);
            Assert.AreEqual(0, result);

            result = tester.CartesianSolved(0, 123);
            Assert.AreEqual(5, result);

            result = tester.CartesianSolved(123, 0);
            Assert.AreEqual(6, result);

            result = tester.CartesianSolved(1.5, 2.5);
            Assert.AreEqual(1, result);

            result = tester.CartesianSolved(-123.312, -132.231231232);
            Assert.AreEqual(3, result);

            result = tester.CartesianSolved(-2000000000001337, 2000000000001337);
            Assert.AreEqual(2, result);

            result = tester.CartesianSolved(2000000000001336.263565423, -2000000000001336.263565423);
            Assert.AreEqual(4, result);

            result = tester.CartesianSolved(-12345689.12345678, 0);
            Assert.AreEqual(6, result);

            result = tester.CartesianSolved(-1001342000001337.26356542312, -2000000000001336.26356542312);
            Assert.AreEqual(3, result);

            result = tester.CartesianSolved(0, -2000000000001336.26356542312);
            Assert.AreEqual(5, result);
        }
    }
}
