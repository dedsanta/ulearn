using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
       
         void TestMethod1(int [] a,int [] b)
        {
           Program.ZipSum(a, b);
        }

        [TestMethod]
        public void Test1()
        {
            TestMethod1(new[] { 1 }, new[] { 0 });
        }
    }
}
