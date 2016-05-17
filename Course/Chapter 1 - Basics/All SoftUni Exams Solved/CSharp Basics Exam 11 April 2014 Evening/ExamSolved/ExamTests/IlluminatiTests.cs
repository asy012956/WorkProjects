using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExamSolved
{
    [TestClass]
    public class IlluminatiTests
    {
        [TestMethod]
        public void TestingIlluminati()
        {
            Illuminati tester = new Illuminati();
            IlluminatiAddOn result = tester.IlluminatiSolved("Listen very carefully, I shall say this only once.");
            Assert.AreEqual(13, result.NumberOfVowels);
            Assert.AreEqual(933, result.SumOfVowels);

            result = tester.IlluminatiSolved("alajasja");
            Assert.AreEqual(4, result.NumberOfVowels);
            Assert.AreEqual(260, result.SumOfVowels);

            result = tester.IlluminatiSolved("Hey, don't do that!");
            Assert.AreEqual(4, result.NumberOfVowels);
            Assert.AreEqual(292, result.SumOfVowels);

            result = tester.IlluminatiSolved("I'll be back!I'll be back!I'll be back!I'll be back!");
            Assert.AreEqual(12, result.NumberOfVowels);
            Assert.AreEqual(828, result.SumOfVowels);

            result = tester.IlluminatiSolved("Goooood morning, VietnamGoooood morning, VietnamGoooood morning, VietnamGoooood morning, VietnamGoooood morning, VietnamGoooood morning, Vietnam");
            Assert.AreEqual(60, result.NumberOfVowels);
            Assert.AreEqual(4524, result.SumOfVowels);

            result = tester.IlluminatiSolved("aaaaaaaaaaaaaaaaaaaaaa");
            Assert.AreEqual(22, result.NumberOfVowels);
            Assert.AreEqual(1430, result.SumOfVowels);
        }
    }
}
