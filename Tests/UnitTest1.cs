using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(123, int.Parse("123"));
            Assert.AreEqual("01234567-89ab-cdef-0123-456789abcdef", new Guid("01234567-89ab-cdef-0123-456789abcdef").ToString("D"));
        }
    }
}
