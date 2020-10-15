using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestingDemo;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        private readonly TestingDemo.Program program;
        public UnitTest1()
        {
            program = new TestingDemo.Program();
        }
        [TestMethod]       
        public void TestMethod1()
        {
            int a = 5;
            int b = 30;
            var result = program.Add(a, b);
            Assert.AreEqual(35, result);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int a = 5;
            int b = 67;
            var result = program.Add(a, b);
            Assert.AreNotEqual(35, result);
        }
        [TestMethod]
        [DataRow(2,3)]
        [DataRow(7,8)]
        public void TestMethod3(int a, int b)
        {
            int exp = a * b;
            var result = program.Mul(a, b);
            Assert.AreEqual(exp, result);
        }
    }
}
