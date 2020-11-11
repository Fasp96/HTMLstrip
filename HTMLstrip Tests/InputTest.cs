using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HTMLstrip_Tests
{
    [TestClass]
    public class UnitTest1
    {
        private const bool Expected = true;
        [TestMethod]
        public void TestMethod1()
        {
            bool result = HTMLstrip.InputHandler.ValidateInput();
            
            Assert.AreEqual(Expected, result);
        }
    }
}
