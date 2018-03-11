using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace _006TestingDelegates
{
    [TestClass]
    public class TestDelegates
    {
        private void DoWork()
        {
            Debug.WriteLine("Hello Test Case");
        }

        [TestMethod]
        public void TestMethod1()
        {
            DoWork();
        }
    }
}
