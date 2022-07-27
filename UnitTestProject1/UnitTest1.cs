using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculator;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidAdd()
        {
            int a = 2;
            int b = 2;
            char ch = '+';
            int expected = 4;
            Assert.AreEqual(expected, Program.getResult(a, b, ch));
        }

        [TestMethod]
        public void ValidSubtract()
        {
            int a = 2;
            int b = 2;
            char ch = '-';
            int expected = 0;
            Assert.AreEqual(expected, Program.getResult(a, b, ch));
        }

        [TestMethod]
        public void ValidMultiply()
        {
            int a = 2;
            int b = 2;
            char ch = '*';
            int expected = 4;
            Assert.AreEqual(expected, Program.getResult(a, b, ch));
        }

        [TestMethod]
        public void ValidDivide()
        {
            int a = 2;
            int b = 2;
            char ch = '/';
            int expected = 1;
            Assert.AreEqual(expected, Program.getResult(a, b, ch));
        }

        [TestMethod]
        public void InvalidDivide()
        {
            int a = 2;
            int b = 0;
            char ch = '/';
            int expected = int.MaxValue;
            try
            {
                Assert.AreEqual(expected, Program.getResult(a, b, ch));
            }
            catch
            {

            }
        }
    }
}
