using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace NKC.ProjectEuler.Tests
{
    [TestClass]
    public class ProjectEulerTestBase
    {
        private const long MAXIMUM_MILLISECONDS = 60000;
        private const string TOO_LONG_MESSAGE = "Test took more than 1 minute. That counts as losing";
        private Stopwatch _stopwatch;

        [TestInitialize]
        public void Setup()
        {
            _stopwatch = new Stopwatch();
            _stopwatch.Start();
        }

        [TestCleanup]
        public void Teardown()
        {
            _stopwatch.Stop();
            Assert.IsTrue(_stopwatch.ElapsedMilliseconds < MAXIMUM_MILLISECONDS, TOO_LONG_MESSAGE);
        }
    }    
}
