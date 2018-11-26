using NUnit.Framework;
using No6.Solution;
using System.Collections.Generic;
using System.Linq;

namespace No6.Solution.Tests
{
    [TestFixture]
    public class CustomEnumerableTests
    {
        [Test]
        public void Generator_ForSequence1()
        {
            SequenceGenerator sg = new SequenceGenerator();
            int[] expected = {1, 1, 2, 3, 5, 8, 13, 21, 34, 55};

            int[] actual = sg.Generate<int>((int a, int b) => a + b, 10, 1, 1).ToArray();
            
            CollectionAssert.AreEqual(actual, expected);
        }

        [Test]
        public void Generator_ForSequence2()
        {
            SequenceGenerator sg = new SequenceGenerator();
            int[] expected = { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512 };

            int[] actual = sg.Generate<int>((int a, int b) => 6*b - 8*a, 10, 1, 2).ToArray();

            CollectionAssert.AreEqual(actual, expected);
        }

        [Test]
        public void Generator_ForSequence3()
        {
            SequenceGenerator sg = new SequenceGenerator();

            double[] expected = { 1, 2, 2.5, 3.3, 4.05757575757576, 4.87086926018965, 5.70389834408211, 6.55785277425587, 7.42763417076325, 8.31053343902137 };


            double[] actual = sg.Generate<double>((double a, double b) => (a+b)/b, 10, 1, 2).ToArray();

            CollectionAssert.AreEqual(actual, expected);
        }
    }
}
