using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leecode;

namespace LeecodeTest
{
    [TestClass]
    public class GetNoZeroIntegers
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrage
            Solution a = new Solution();
            int n = 11;
            int[] expected = new int[] { 2, 9 };

            //Act
            var actual = a.GetNoZeroIntegers(n);
            //Assert            
            CollectionAssert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrage
            Solution a = new Solution();
            int n = 4102;
            int[] expected = new int[] { 111, 3991 };

            //Act
            var actual = a.GetNoZeroIntegers(n);
            //Assert            
            CollectionAssert.AreEqual(expected, actual);


        }

    }
}
