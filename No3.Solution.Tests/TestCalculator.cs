﻿using System.Collections.Generic;
using NUnit.Framework;

namespace No3.Solution.Tests
{
    [TestFixture]
    public class TestCalculator
    {
        private readonly List<double> values = new List<double> { 10, 5, 7, 15, 13, 12, 8, 7, 4, 2, 9 };

        [Test]
        public void Test_AverageByMean_WithInterface()
        {
            Calculator calculator = new Calculator();
            ICalculator meanCalculator = new MeanCalculator();
            double expected = 8.3636363;

            double actual = calculator.CalculateAverage(values, meanCalculator);

            Assert.AreEqual(expected, actual, 0.000001);
        }

        [Test]
        public void Test_AverageByMedian_WithInterface()
        {
            Calculator calculator = new Calculator();
            ICalculator medianCalculator = new MedianCalculator();

            double expected = 8.0;

            double actual = calculator.CalculateAverage(values, medianCalculator);

            Assert.AreEqual(expected, actual, 0.000001);
        }

        [TestCase(No3.AveragingMethod.Mean,8.3636363)]
        [TestCase(No3.AveragingMethod.Median,8.0)]
        public  void AverageCalculatorTests_ValidEnum(AveragingMethod method,double result)
        {
            Calculator calculator = new Calculator();
            Assert.AreEqual(result, calculator.CalculateAverageWithEnum(values, method), 0.000001);
        }
    }
}