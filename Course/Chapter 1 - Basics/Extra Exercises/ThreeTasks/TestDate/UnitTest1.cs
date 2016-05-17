using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ThreeTasks;

namespace TestDate
{
    [TestClass]
    public class TestDates
    {
        [TestMethod]
        public void TestCorrectDates()
        {
            Task8 runner = new Task8();

            for (int i = 0; i <= 360 - DateTime.Today.DayOfYear; i++)
            {
                int expected = runner.CalculateWorkDaysTillChristmas(i);
                int actual = runner.CalculateWorkDays(i) + 1;

                Assert.AreEqual(expected, actual);
            }
        }
    }
}
