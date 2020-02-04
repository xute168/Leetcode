using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leecode;

namespace LeecodeTest
{
    [TestClass]
    public class SubtractProductAndSum
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrage
            Solution a = new Solution();
            int n = 234;
            int expected = 15;

            //Act
            var actual = a.SubtractProductAndSum(n);
            //Assert            
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrage
            Solution a = new Solution();
            int n = 4421;
            int expected = 21;

            //Act
            var actual = a.SubtractProductAndSum(n);
            //Assert            
            Assert.AreEqual(expected, actual);

        }

    }
}
