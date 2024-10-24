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
        public class MethodWithinSourceClass : SourceClassTests
        {
            [TestMethod]
            public void Should_DoSomething()
            {
                Assert.Fail(); // Fails from TestFramework 3.5.0
            }
        }
    }
}
