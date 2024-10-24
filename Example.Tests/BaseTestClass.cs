using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Example.Tests
{
    [TestClass]
    [Ignore]
    public class BaseTestClass
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.Fail();
        }

        [TestClass]
        public class DerivedTestClass : BaseTestClass
        {
            [TestMethod]
            public void TestMethod2()
            {
                Assert.Fail();
            }
        }
    }
}
