using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ExamSolved
{
    [TestClass]
    public class ExamTestLetters3
    {
        [TestMethod]
        public void Letters3()
        {
            Letters3 tester = new Letters3();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void LettersSymbolsNumbersFailed()
        {
            
        }
    }
}
