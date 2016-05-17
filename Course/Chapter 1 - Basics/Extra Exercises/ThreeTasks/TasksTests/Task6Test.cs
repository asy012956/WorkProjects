using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ThreeTasks;

namespace TasksTests
{
    [TestClass]
    public class Task6Test
    {
        [TestMethod]
        public void IsPalindromSimplePalindrom()
        {
            Task6 runner = new Task6();
            bool actual = runner.IsItPalindrome("asa");
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void IsPalindromLongPalindrome()
        {
            Task6 runner = new Task6();
            bool actual = runner.IsItPalindrome("wasitacaroracatisaw");
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void IsPalindromeSameWord()
        {
            Task6 runner = new Task6();
            bool actual = runner.IsItPalindrome("aaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            Assert.IsTrue(actual);
        }

        //lo6
        [TestMethod]
        public void IsPalindromeMediumPalindrome()
        {
            Task6 runner = new Task6();
            bool actual = runner.IsItPalindrome("racecar");
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void IsPalindromeFalse()
        {
            Task6 runner = new Task6();
            bool actual = runner.IsItPalindrome("slkdfkshdgskldgf");
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void IsPalindromeEmptyString()
        {
            Task6 runner = new Task6();
            bool actual = runner.IsItPalindrome("");
            Assert.IsFalse(actual);
        }

        //lo6
        [TestMethod]
        public void IsPalindromeFalse3()
        {
            Task6 runner = new Task6();
            bool actual = runner.IsItPalindrome("racebcar");
            Assert.IsFalse(actual);
        }

        [TestMethod]
        [ExpectedException(typeof (NullReferenceException))]
        public void IsPalindromeNULLAgrument()
        {
            Task6 runner = new Task6();
            bool actual = runner.IsItPalindrome(null);
        }

        [TestMethod]
        public void IsPalindromeOddSymbols()
        {

        }
    }
}
