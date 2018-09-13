using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestCalculations
{
    [TestClass]
    public class UnitTest1
    {
        private Calculator.CalculatorSoapClient calcRef;

        [TestMethod]
        public void TestAdd()
        {
            calcRef = new Calculator.CalculatorSoapClient();
            double d = calcRef.Add(2.0, 2.0);
            Assert.AreEqual(d, 4.0);
        }

        [TestMethod]
        public void TestSubtract()
        {
            calcRef = new Calculator.CalculatorSoapClient();
            double d = calcRef.Subtract(5.0, 2.0);
            Assert.AreEqual(d, 3.0);
        }

        [TestMethod]
        public void TestMultiply()
        {
            calcRef = new Calculator.CalculatorSoapClient();
            double d = calcRef.Multiply(2.0, 3.0);
            Assert.AreEqual(d, 6.0);
        }

        [TestMethod]
        public void TestDivide()
        {
            calcRef = new Calculator.CalculatorSoapClient();
            double d = calcRef.Divide(10.0, 2.0);
            Assert.AreEqual(d, 5.0);
        }

        [TestMethod]
        public void TestSquareRoot()
        {
            calcRef = new Calculator.CalculatorSoapClient();
            double d = calcRef.SquareRoot(64.0);
            Assert.AreEqual(d, 8.0);
        }

        [TestMethod]
        public void TestHalve()
        {
            calcRef = new Calculator.CalculatorSoapClient();
            double d = calcRef.Halve(64.0);
            Assert.AreEqual(d, 32.0);
        }

        [TestMethod]
        public void TestQuarter()
        {
            calcRef = new Calculator.CalculatorSoapClient();
            double d = calcRef.Quarter(100.0);
            Assert.AreEqual(d, 25.0);
        }
    }
}
