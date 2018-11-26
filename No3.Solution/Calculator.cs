using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No3.Solution
{
    public class Calculator
    {
        public double CalculateAverage(List<double> values, ICalculator calculator)
        {
            if (values == null)
            {
                throw new ArgumentNullException($"{nameof(values)} can't be null");
            }
            if (calculator == null)
            {
                throw new ArgumentNullException($"{nameof(calculator)} can't be null");
            }
            return calculator.Calculate(values);
        }

        public double CalculateAverageWithEnum(List<double> values , AveragingMethod method)
        {
            CalculatorCreator calculatorCreator = new CalculatorCreator();
            if (values == null)
            {
                throw new ArgumentNullException($"{nameof(values)} can't be null");
            }
            ICalculator calculator = calculatorCreator.CalculatorCreate(method);
            return calculator.Calculate(values);
        }
    }
}
