using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leecode;

namespace LeecodeTest
{
    [TestClass]
    public class FindMinTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrage
            Solution a = new Solution();
            int[] nums = new int[] { 4, 5, 6, 7, 0, 1, 2 };
            int expected = 0;
            //Act
            var actual = a.FindMin(nums);
            //Assert
            //Assert.AreEqual(expected.Length, actual.Length);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrage
            Solution a = new Solution();
            int[] nums = new int[] { 3, 4, 5, 1, 2 };
            int expected = 1;
            //Act
            var actual = a.FindMin(nums);
            //Assert
            //Assert.AreEqual(expected.Length, actual.Length);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethod3()
        {
            //Arrage
            Solution a = new Solution();
            int[] nums = new int[] { 1, 2 };
            int expected = 1;
            //Act
            var actual = a.FindMin(nums);
            //Assert
            //Assert.AreEqual(expected.Length, actual.Length);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethod4()
        {
            //Arrage
            Solution a = new Solution();
            int[] nums = new int[] { 2, 1 };
            int expected = 1;
            //Act
            var actual = a.FindMin(nums);
            //Assert
            //Assert.AreEqual(expected.Length, actual.Length);
            Assert.AreEqual(expected, actual);

        }


    }
}
