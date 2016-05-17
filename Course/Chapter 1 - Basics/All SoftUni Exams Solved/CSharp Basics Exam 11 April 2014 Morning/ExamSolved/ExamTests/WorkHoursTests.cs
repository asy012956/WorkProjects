using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExamSolved
{
    [TestClass]
    public class WorkHoursTests
    {
        [TestMethod]
        public void Tests()
        {
            WorkHours tester = new WorkHours();
            WorkHoursAddOn result = tester.WorkHoursSolved(1543, 168, 92);
            Assert.AreEqual("Yes", result.CanFinishProject);
            Assert.AreEqual("126", result.Difference);

            result = tester.WorkHoursSolved(500, 20, 87);
            Assert.AreEqual("No", result.CanFinishProject);
            Assert.AreEqual("-313", result.Difference);

            result = tester.WorkHoursSolved(10000, 2000, 75);
            Assert.AreEqual("Yes", result.CanFinishProject);
            Assert.AreEqual("6200", result.Difference);

            result = tester.WorkHoursSolved(100000, 40000, 37);
            Assert.AreEqual("Yes", result.CanFinishProject);
            Assert.AreEqual("59840", result.Difference);

            result = tester.WorkHoursSolved(2147483647, 89478485, 100);
            Assert.AreEqual("No", result.CanFinishProject);
            Assert.AreEqual("-1181116009", result.Difference);

            result = tester.WorkHoursSolved(10000000, 1000000, 0);
            Assert.AreEqual("No", result.CanFinishProject);
            Assert.AreEqual("-10000000", result.Difference);

            result = tester.WorkHoursSolved(1000000000, 58965478, 58);
            Assert.AreEqual("No", result.CanFinishProject);
            Assert.AreEqual("-630640246", result.Difference);
        }
    }
}
