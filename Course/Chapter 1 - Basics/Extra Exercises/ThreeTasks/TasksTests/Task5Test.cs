using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ThreeTasks;

namespace TasksTests
{
    [TestClass]
    public class Task5Test
    {
        [TestMethod]
        public void FirstReversedWords()
        {
            Task5 runner = new Task5();
            string actual = runner.RearrangeWords("Yoda like sound you");
            string expected = "you sound like Yoda";
            Assert.AreEqual(expected, actual);
        }
    }
}
