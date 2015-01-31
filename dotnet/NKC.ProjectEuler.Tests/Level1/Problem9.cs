using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NKC.ProjectEuler.Tests.Level1
{
    [TestClass]
    public class Problem9 : ProjectEulerTestBase
    {
        [TestMethod]
        public void Solve()
        {
            int answer = FindTheProductOfThePythagoreanTripletOf1000();
            Console.WriteLine(answer);
        }

        private int FindTheProductOfThePythagoreanTripletOf1000()
        {
            for (int a = 0; a < 500; a++)
            {
                for (int b = 0; b < 500; b++)
                {
                    int c = (int)Math.Sqrt(a * a + b * b);
                    if (a + b + c == 1000 && IsPythagoreanTriplet(a, b, c))
                        return a * b * c;
                }
            }
            return 0;
        }
        
        private bool IsPythagoreanTriplet(int a, int b, int c)
        {
            return (a < b && b < c && a * a + b * b == c * c);
        }
    }

    
}
