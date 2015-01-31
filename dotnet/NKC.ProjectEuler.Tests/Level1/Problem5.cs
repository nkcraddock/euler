using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NKC.ProjectEuler.Tests.Problem5
{
    [TestClass]
    public class Problem5Test : ProjectEulerTestBase
    {
        int[] FactorsToCheck = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

        [TestMethod]
        public void Solve()
        {
            int value = 20;

            while (!IsDivisibleByAllTheThings(value))
                value += 20;

            Console.WriteLine(value);
        }

        private bool IsDivisibleByAllTheThings(int x)
        {
            for (int i = FactorsToCheck.Length - 1; i >= 0; i--)
                if (x % FactorsToCheck[i] != 0) return false;

            return true;
        }
    }
}
