using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NKC.ProjectEuler.Tests.Level1
{
    [TestClass]
    public class Problem6 : ProjectEulerTestBase
    {
        [TestMethod]
        public void Solve()
        {
            int sum = SumOFSquaresOfFirstN(100);
            int square = SquareOfSumsOfFirstN(100);
            int difference = sum - square;
            Console.Write(difference);
        }

        private int SumOFSquaresOfFirstN(int N)
        {
            int sum = 0;
            for (int i = 1; i <= N; i++)
                sum += i * i;
            return sum;
        }

        private int SquareOfSumsOfFirstN(int N)
        {
            int sum = 0;
            for (int i = 1; i <= N; i++)
                sum += i;
            return sum * sum;
        }
    }
}
