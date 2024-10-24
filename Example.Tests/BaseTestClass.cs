using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Example.Tests
{
    [TestClass]
    [Ignore]
    public class SourceClassTests
    {
        [TestMethod]
        public void Constructor_Tests()
        {
            Assert.Fail(); // Skipped in all versions
        }

        [TestClass]
        public class DerivedTestClass : SourceClassTests
        {
            [TestMethod]
            public void Method_Within_SourceClassTests()
            {
                Assert.Fail(); // Fails from TestFramework 3.5.0
            }
        }
    }
}
