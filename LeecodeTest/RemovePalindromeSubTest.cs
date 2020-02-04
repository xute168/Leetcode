using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leecode;

namespace LeecodeTest
{
    [TestClass]
    public class RemovePalindromeSubTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrage
            Solution a = new Solution();
            string nums = "ababa";
            int expected = 1;

            //Act
            var actual = a.RemovePalindromeSub(nums);
            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrage
            Solution a = new Solution();
            string nums = "abb";
            int expected = 2;

            //Act
            var actual = a.RemovePalindromeSub(nums);
            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethod3()
        {
            //Arrage
            Solution a = new Solution();
            string nums = "baabb";
            int expected = 2;

            //Act
            var actual = a.RemovePalindromeSub(nums);
            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethod4()
        {
            //Arrage
            Solution a = new Solution();
            string nums = "";
            int expected = 0;

            //Act
            var actual = a.RemovePalindromeSub(nums);
            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethod5()
        {
            //Arrage
            Solution a = new Solution();
            string nums = "bbaabaaa";
            int expected = 2;

            //Act
            var actual = a.RemovePalindromeSub(nums);
            //Assert
            Assert.AreEqual(expected, actual);

        }

        
    }
}
