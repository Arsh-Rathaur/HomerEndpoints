using NUnit.Framework;
using System.Threading;

namespace NUnit_Homer
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
            Thread.Sleep(20000);
            Assert.AreEqual(true, true);
        }
    }
}