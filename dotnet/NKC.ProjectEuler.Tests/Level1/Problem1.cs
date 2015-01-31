using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NKC.ProjectEuler.Tests.Problem1
{
    [TestClass]
    public class Problem1Test : ProjectEulerTestBase
    {
        [TestMethod]
        public void SumOfAllMultiplesOf3Or5Below1000()
        {
            var solution = new Problem1Solver();
            double total = solution.SumOfMultiples(1000, 3, 5);
            Console.WriteLine("The total is " + total.ToString());
        }
    }

    public class Problem1Solver
    {
        public double SumOfMultiples(double limit, params double[] factors)
        {
            double total = 0;
            for (double i = 0; i < limit; i++)
                if (IsMultipleOf(i, factors))
                    total += i;

            return total;
        }

        private bool IsMultipleOf(double value, double[] factors)
        {
            foreach (double factor in factors)
                if (value % factor == 0) return true;

            return false;
        }
    }
}
