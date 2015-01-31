using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NKC.ProjectEuler.Tests.Level1
{
    [TestClass]
    public class Problem7 : ProjectEulerTestBase
    {
        [TestMethod]
        public void Solve()
        {
            long answer = FindNthPrime(10001);
            Console.WriteLine(answer);
        }

        private long FindNthPrime(int N)
        {
            const long UPPER_LIMIT = 150000;
            var nonPrimes = new List<long>();
            int primes = 0;
            for (long i = 3; i < UPPER_LIMIT; i += 2)
            {
                if (!nonPrimes.Contains(i))
                {
                    if (++primes == N - 1)
                        return i;
                    AddAllMultiplesUpToN(nonPrimes, i, UPPER_LIMIT);
                }
            }

            return 0;
        }

        private void AddAllMultiplesUpToN(List<long> nonPrimes, long prime, long UPPER_LIMIT)
        {
            for (long i = prime * 2; i <= UPPER_LIMIT; i += prime)
                nonPrimes.Add(i);
        }
    }
}
