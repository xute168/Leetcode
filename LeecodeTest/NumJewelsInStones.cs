using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leecode;

namespace LeecodeTest
{
    [TestClass]
    public class NumJewelsInStones
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrage
            Solution a = new Solution();
            string J = "aA";
            string S = "aAABB";
            int expected = 3;

            //Act
            var actual = a.NumJewelsInStones(J, S);
            //Assert
            //Assert.AreEqual(expected.Length, actual.Length);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrage
            Solution a = new Solution();
            string J = "bce";
            string S = "eea";
            int expected = 2;

            //Act
            var actual = a.NumJewelsInStones(J, S);
            //Assert
            //Assert.AreEqual(expected.Length, actual.Length);
            Assert.AreEqual(expected, actual);

        }

        
    }
}
