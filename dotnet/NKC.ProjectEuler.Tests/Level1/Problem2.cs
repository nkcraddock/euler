using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NKC.ProjectEuler.Tests.Problem2
{
    [TestClass]
    public class Problem2Test : ProjectEulerTestBase
    {
        [TestMethod]
        public void SumOfEvenValuedFibonacciTermsUnder4Million()
        {
            uint sum = SumOfFibonacci(4000000, x => x % 2 == 0);
            Console.WriteLine("Sum is " + sum);
        }

        private uint SumOfFibonacci(uint limit, Func<uint, bool> condition)
        {
            uint total = 0;
            uint a = 1;
            uint b = 2;
            uint c;
            if (condition(a)) total += a;
            if (condition(b)) total += b;
            do
            {
                c = a + b;
                a = b;
                b = c;
                if (c < limit && condition(c)) total += c;
            } while (c < limit);
            return total;
        }
    }
}
