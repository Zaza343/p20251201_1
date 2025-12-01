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
        public void Test2()
        {
            StringAssert.Contains("@", "Pelda@valami.hu");
        }
        public void Test3()
        {
            StringAssert.Contains("P", "Pelda@valami.hu");
        }
    }
}