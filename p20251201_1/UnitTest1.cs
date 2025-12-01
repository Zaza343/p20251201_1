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
            StringAssert.Contains("@", "Pelda@valami.hu");
            StringAssert.Contains(".hu", "Pelda@valami.hu");
        }
    }
}