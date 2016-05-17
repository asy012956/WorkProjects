using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicsGraduation;
using System.Diagnostics;

namespace BasicGraduationTests
{
    [TestClass]
    public class PrimeSeekerTest
    {
        [TestMethod]
        public void CheckIsPrimeTrue()
        {
            PrimeSeeker seeker = new PrimeSeeker();
            bool actual = seeker.IsPrime(13);

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void CheckIsPrimeFalse()
        {
            PrimeSeeker seeker = new PrimeSeeker();
            bool actual = seeker.IsPrime(20);

            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void CheckIsPrimeNegative()
        {
            PrimeSeeker seeker = new PrimeSeeker();
            bool actual = seeker.IsPrime(-13);

            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void CheckSpeedOfIsPrime()
        {
            Stopwatch stopWatch = new Stopwatch();

            PrimeSeeker seeker = new PrimeSeeker();

            stopWatch.Start();
            seeker.IsPrime(int.MaxValue / 100);
            stopWatch.Stop();

            Assert.IsTrue(10000L >= stopWatch.ElapsedMilliseconds);
        }

        [TestMethod]
        public void CheckPrimesTill()
        {
            PrimeSeeker seeker = new PrimeSeeker();

            int[] expected = new int[] { 2, 3, 5, 7, 11, 13, 17, 19 };
            int[] actual = seeker.PrimesTill(20);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckPrimesTillNegative()
        {
            PrimeSeeker seeker = new PrimeSeeker();

            int[] expected = new int[0];
            int[] actual = seeker.PrimesTill(-20);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckPrimesTillOne()
        {
            PrimeSeeker seeker = new PrimeSeeker();

            int[] expected = new int[0];
            int[] actual = seeker.PrimesTill(1);

            CollectionAssert.AreEqual(expected, actual);
        }



    }
}
