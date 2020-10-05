using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MortgageCalculator;

namespace MortgageCalculatorTests
{
    [TestClass]
    public class InputTests
    {
        [TestMethod]
        public void Calculate_RateIsZero_DivideByZeroException()
        {
            MortgageModel TestModel = new MortgageModel();
            Assert.ThrowsException<DivideByZeroException>(() => TestModel.Calculate(0, 30, 0));
        }

        [TestMethod]
        public void Calculate_ValuesAreLarge_OverflowException()
        {
            MortgageModel TestModel = new MortgageModel();
            Assert.ThrowsException<OverflowException>(() => TestModel.Calculate(9999999999, 99999, 40));
        }
    }
}
