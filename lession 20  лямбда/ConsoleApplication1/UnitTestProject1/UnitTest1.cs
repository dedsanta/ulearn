using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(0, Program.zero());

            Assert.AreEqual("42", Program.toString(42));
            Assert.AreEqual("123", Program.toString(123));

            Assert.AreEqual(3.14, Program.add(1.1, 2.04));
            Assert.AreEqual(0, Program.add(-1, 1));

            Program.print("passed!");
        }

        [TestMethod]
        public void Test11()
        {
            Assert.AreEqual(0, Program.zero());
        }

        [TestMethod]
        public void Test12()
        {
            Assert.AreEqual("42", Program.toString(42));
        }

        [TestMethod]
        public void Test13()
        {
            Assert.AreEqual("123", Program.toString(123));
        }

        [TestMethod]
        public void Test14()
        {
            Assert.AreEqual(3.14, Program.add(1.1, 2.04));
        }

        [TestMethod]
        public void Test15()
        {
            Assert.AreEqual(0, Program.add(-1, 1));
        }

        [TestMethod]
        public void Test16()
        {
            Program.print("passed!");
        }
    }
}
