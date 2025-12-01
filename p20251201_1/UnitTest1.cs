using System.ComponentModel.DataAnnotations;

namespace p20251201_1
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
            StringAssert.Contains("1","Pelda@valami.hu");
        }
        [Test]
        public void Test2()
        {
            StringAssert.Contains("+36","+36307145632");
        }
        [Test]
        public void Test3()
        {
            Assert.IsTrue("Password".Length > 6);
        }
        [Test]
        public void Test4()
        {
            Assert.AreEqual(5, "Hello".Length);
        }
        [Test]
        public void Test5()
        {
            Assert.IsTrue("Test@domain.com".Contains("@"));
        }
    }
}