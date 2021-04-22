using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AzureTestAppTests
{
    [TestClass]
    public class UnitTest1
    {
        private const string Expected = "Hello World!";
        [TestMethod]
        public void TestMethod1()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                AzureTestApp.Program.Main();

                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }
    }
}
