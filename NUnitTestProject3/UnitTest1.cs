using NUnit.Framework;
using MyProject;


namespace NUnitTestProject3
{
    [TestFixture]
   class MyTestCase
    {
       [TestCase]
       public void FirstTest()
        {
            int[] test = new int [] { 13, 53, 2, 53, 20, 49, 24, 77, 63 };
            Assert.AreEqual(63, ArraySort.FoundMax2n(test));
        }
        [TestCase]
        public void SecondTest()
        {
            int[] test = new int[] { 4, 34, 434, 234, 24, 92, 124, 438, 32, 34};
            Assert.AreEqual(434, ArraySort.FoundMax2n(test));
        }


    }
}