using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private static Class1 c = null;

        [ClassInitialize]
        public static void Init(TestContext context)
        {
            c = new Class1();
        }

        [TestMethod]
        public void TestMethod1()
        {
            c.SayHello();
        }

        [TestMethod]
        public void TestSayHello()
        {
            c.SayHello();
        }

        [TestMethod]
        public void TestSayHelloAgain()
        {
            c.SayHelloAgain();
        }
    }
}
