using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leecode;

namespace LeecodeTest
{
    [TestClass]
    public class BalancedStringSplit
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrage
            Solution a = new Solution();
            string nums = "RLRRLLRLRL";
            int expected =4;

            //Act
            var actual = a.BalancedStringSplit(nums);
            //Assert
            //Assert.AreEqual(expected.Length, actual.Length);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrage
            Solution a = new Solution();
            string nums = "RLLLLRRRLR";
            int expected = 3;

            //Act
            var actual = a.BalancedStringSplit(nums);
            //Assert
            //Assert.AreEqual(expected.Length, actual.Length);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethod3()
        {
            //Arrage
            Solution a = new Solution();
            string nums = "LLLLRRRR";
            int expected = 1;

            //Act
            var actual = a.BalancedStringSplit(nums);
            //Assert
            //Assert.AreEqual(expected.Length, actual.Length);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethod4()
        {
            //Arrage
            Solution a = new Solution();
            string nums = "RLRRRLLRLL";
            int expected = 2;

            //Act
            var actual = a.BalancedStringSplit(nums);
            //Assert
            //Assert.AreEqual(expected.Length, actual.Length);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethod5()
        {
            //Arrage
            Solution a = new Solution();
            string nums = "RRLRRLRLLLRL";
            int expected = 2;

            //Act
            var actual = a.BalancedStringSplit(nums);
            //Assert
            //Assert.AreEqual(expected.Length, actual.Length);
            Assert.AreEqual(expected, actual);

        }

    }
}
