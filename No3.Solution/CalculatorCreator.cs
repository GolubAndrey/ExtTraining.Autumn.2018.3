using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No3.Solution
{
    public class CalculatorCreator
    {
        public ICalculator CalculatorCreate(AveragingMethod method)
        {
            string fullName = $"{GetType().Namespace}.{method.ToString()}Calculator";
            Type t;
            try
            {
                t = Type.GetType(fullName, true, false);
            }
            catch (TypeLoadException ex)
            {
                throw new InvalidOperationException($"No such method {nameof(method)}");
            }
            ICalculator calculator = (ICalculator)Activator.CreateInstance(t);
            return calculator;
        }
    }
}
