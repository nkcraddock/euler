using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NKC.ProjectEuler.Tests.Problem4
{
    [TestClass]
    public class Problem4Test : ProjectEulerTestBase
    {
        [TestMethod]
        public void Solve()
        {
            var solver = new Problem4Solver();

            int maxPalindrome = solver.FindMaxPalindrome();

            Console.WriteLine("The answer is " + maxPalindrome);
        }

        [TestMethod]
        public void FindsPalindromes()
        {
            var solver = new Problem4Solver();
            Assert.IsTrue(solver.IsPalindrome(1234321));
        }
    }

    public class Problem4Solver
    {
        public bool IsPalindrome(int x)
        {
            string text = x.ToString();
            return text == Reverse(text);
        }
        
        private string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }


        public int FindMaxPalindrome()
        {
            int biggestPalindrome = 0;
            int product = 0;
            for (int x = 999; x > 99; x--)
            {
                for (int y = 999; y > 99; y--)
                {
                    product = x * y;
                    if (product > biggestPalindrome && IsPalindrome(product))
                        biggestPalindrome = product;

                }
            }
            return  biggestPalindrome;
        }
    }
}
