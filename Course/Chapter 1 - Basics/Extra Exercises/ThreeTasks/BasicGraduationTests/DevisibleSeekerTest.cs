using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicsGraduation;

namespace BasicGraduationTests
{
    [TestClass]
    public class DevisibleSeekerTest
    {
        [TestMethod]
        public void CheckDevisibleByFalse()
        {
            DevisibleSeeker seeker = new DevisibleSeeker();

            int number = 12;
            int devisor = 5;

            Assert.IsFalse(seeker.IsDevisible(number, devisor));
        }

        [TestMethod]
        public void CheckDevisibleByTrue()
        {
            DevisibleSeeker seeker = new DevisibleSeeker();

            int number = 12;
            int devisor = 4;

            Assert.IsTrue(seeker.IsDevisible(number, devisor));
        }

        [TestMethod]
        public void CheckDevisibleByBiggerNumber()
        {
            DevisibleSeeker seeker = new DevisibleSeeker();

            int number = 4;
            int devisor = 12;

            Assert.IsFalse(seeker.IsDevisible(number, devisor));
        }

        [TestMethod]
        public void CheckDevisibleBySameNumber()
        {
            DevisibleSeeker seeker = new DevisibleSeeker();

            int number = 6;
            int devisor = 6;

            Assert.IsTrue(seeker.IsDevisible(number, devisor));
        }

        [TestMethod]
        public void CheckDevisibleByNegativeNumber()
        {
            DevisibleSeeker seeker = new DevisibleSeeker();

            int number = 6;
            int devisor = -6;

            Assert.IsTrue(seeker.IsDevisible(number, devisor));
        }

        [TestMethod]
        public void CheckDevisibleNegativeNumbers()
        {
            DevisibleSeeker seeker = new DevisibleSeeker();

            int number = -12;
            int devisor = -4;

            Assert.IsTrue(seeker.IsDevisible(number, devisor));
        }

        [TestMethod]
        public void CheckClosestDevisibleByNearDown()
        {
            DevisibleSeeker seeker = new DevisibleSeeker();

            int number = 7;
            int devisor = 5;

            int actual = seeker.ClosestDevisibleBy(number, devisor);

            Assert.AreEqual(5, actual);
        }

        [TestMethod]
        public void CheckClosestDevisibleByNearUp()
        {
            DevisibleSeeker seeker = new DevisibleSeeker();

            int number = 8;
            int devisor = 3;

            int actual = seeker.ClosestDevisibleBy(number, devisor);

            Assert.AreEqual(9, actual);
        }

        [TestMethod]
        public void CheckClosestDevisibleByDevisibleNumber()
        {
            DevisibleSeeker seeker = new DevisibleSeeker();

            int number = 12;
            int devisor = 4;

            int actual = seeker.ClosestDevisibleBy(number, devisor);

            Assert.AreEqual(8, actual);
        }

        [TestMethod]
        public void CheckClosestDevisibleBySameNumber()
        {
            DevisibleSeeker seeker = new DevisibleSeeker();

            int number = 12;
            int devisor = 12;

            int actual = seeker.ClosestDevisibleBy(number, devisor);

            Assert.AreEqual(24, actual);
        }

        [TestMethod]
        public void CheckClosestDevisibleByNegativeNumber()
        {
            DevisibleSeeker seeker = new DevisibleSeeker();

            int number = -20;
            int devisor = 5;

            int actual = seeker.ClosestDevisibleBy(number, devisor);

            Assert.AreEqual(-25, actual);
        }

    }
}
