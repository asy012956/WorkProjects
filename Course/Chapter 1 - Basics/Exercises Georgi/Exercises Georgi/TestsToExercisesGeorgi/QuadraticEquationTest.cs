using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercises_Georgi;

namespace TestsToExercisesGeorgi
{
    [TestClass]
    public class QuadraticEquationTest
    {
        [TestMethod]
        public void TestQuadraticEquationDiscriminantPositive()
        {
            double a = 3;
            double b = 4;
            double c = 1;
            double x1 = 0;
            double x2 = 0;
            QuadraticEquation runner = new QuadraticEquation();
            runner.SolveQuadraticEquation(a, b, c, out x1, out x2);

            Assert.AreEqual(-1, x2);
            Assert.AreEqual(-0.333, x1, 3);
        }

        [TestMethod]
        public void TestQuadraticEquationDiscriminantZero()
        {
            double a = 1;
            double b = 2;
            double c = 1;
            double x1 = 0;
            double x2 = 0;
            QuadraticEquation runner = new QuadraticEquation();
            runner.SolveQuadraticEquation(a, b, c, out x1, out x2);

            Assert.AreEqual(-1, x1);
            Assert.AreEqual(-1, x2);
        }

        [TestMethod]
        public void TestQuadraticEquationDiscriminantNegative()
        {
            double a = 3;
            double b = 2;
            double c = 1;
            double x1 = 0;
            double x2 = 0;
            QuadraticEquation runner = new QuadraticEquation();
            bool result = runner.SolveQuadraticEquation(a, b, c, out x1, out x2);
            
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestQuadraticEquationAllZero()
        {
            double a = 0;
            double b = 0;
            double c = 0;
            double x1 = 0;
            double x2 = 0;
            QuadraticEquation runner = new QuadraticEquation();
            runner.SolveQuadraticEquation(a, b, c, out x1, out x2);

            Assert.AreEqual(0, x1);
            Assert.AreEqual(0, x2);
        }

        [TestMethod]
        public void TestQuadraticEquationAllNegative()
        {
            double a = -3;
            double b = -4;
            double c = -1;
            double x1 = 0;
            double x2 = 0;
            QuadraticEquation runner = new QuadraticEquation();
            runner.SolveQuadraticEquation(a, b, c, out x1, out x2);

            Assert.AreEqual(-1, x1);
            Assert.AreEqual(-0.333, x2, 3);
        }

        [TestMethod]
        public void TestQuadraticEquationIsNotQuadratic()
        {
            double a = 0;
            double b = 5;
            double c = 3;
            double x1 = 0;
            double x2 = 0;
            QuadraticEquation runner = new QuadraticEquation();
            bool result = runner.SolveQuadraticEquation(a, b, c, out x1, out x2);

            Assert.IsFalse(result);
        }
    }
}
