using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NKC.ProjectEuler.Tests.Problem3
{
    [TestClass]
    public class Problem3Test : ProjectEulerTestBase
    {
        [TestMethod]
        public void Solve()
        {
            const long NUMBER_TO_CHECK = 600851475143;
            long answer = FindLargestPrimeFactorOf(NUMBER_TO_CHECK);
        }

        private long FindLargestPrimeFactorOf(long value)
        {
            for (long i = 3; i < Math.Sqrt(value); i += 2)
            {
                if (value % i == 0)
                {
                    value /= i;
                    i = 3;
                }
            }

            return value;
        }
    }
}
