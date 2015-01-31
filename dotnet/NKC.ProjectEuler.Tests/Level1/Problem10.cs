using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NKC.ProjectEuler.Tests.Level1
{
    [TestClass]
    public class Problem10
    {
        [TestMethod]
        public void DoSummationOfPrimes()
        {
            long count = 0;

            for (var i = 0; i < 2000000; i++)
            {
                if (IsPrime(i))
                {
                    count += i;
                    Console.WriteLine(i.ToString());
                }

            }

            Console.WriteLine("\n\nSum: {0}", count);
        }

        private bool IsPrime(int n)
        {
            if (n <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }
    }
}
