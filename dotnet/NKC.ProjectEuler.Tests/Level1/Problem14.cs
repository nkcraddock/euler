using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NKC.ProjectEuler.Tests.Level1
{
    [TestClass]
    public class LongestCollatzSequence
    {
        [TestMethod]
        public void DoIt()
        {
            int max = 0;
            int recordHolder = 0;

            Parallel.For(1, 999999, i =>
            {
                int count = CountCollatzSequenceLength(i);
                if (count > max)
                {
                    max = count;
                    recordHolder = i;
                }
            });

            Console.WriteLine("{0}:{1}", recordHolder, max);
        }

        private int CountCollatzSequenceLength(int num)
        {
            int count = 1;
            ulong longnum = (ulong)num;

            while (longnum > 1)
            {
                count++;
                if (longnum % 2 == 0) longnum /= 2;
                else longnum = (longnum * 3) + 1;
            }

            return count;
        }
    }
}
