using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No6
{
    public class SequenceGenerator
    {
        public IEnumerable<T> Generate<T>(Func<T,T,T> counter,int n,T firstElement,T secondElement)
        {
            T result;
            for (int i=0;i<n;i++)
            {
                if (i == 0)
                {
                    yield return firstElement;
                    continue;
                }
                if (i==1)
                {
                    yield return secondElement;
                    continue;
                }
                result = counter(firstElement, secondElement);
                firstElement = secondElement;
                secondElement = result;
                yield return secondElement;
            }
        }
    }
}
