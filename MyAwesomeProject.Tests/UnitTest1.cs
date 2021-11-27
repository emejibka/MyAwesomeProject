using NUnit.Framework;

namespace MyAwesomeProject.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void SomeFailTest()
        {
            Assert.Equals(1, 2);
        }
    }
}