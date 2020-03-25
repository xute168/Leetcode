using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leecode;

namespace LeecodeTest
{
    [TestClass]
    public class FindKthLargestTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrage
            Sorting a = new Sorting();
            int[] nums = new int[] { 3, 2, 1, 5, 6, 4 };
            int target = 2;
            int expected = 5;

            //Act
            var actual = a.FindKthLargest(nums, target);
            //Assert
            //Assert.AreEqual(expected.Length, actual.Length);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrage
            Sorting a = new Sorting();
            int[] nums = new int[] { 3, 2, 3, 1, 2, 4, 5, 5, 6 };
            int target = 4;
            int expected = 4;

            //Act
            var actual = a.FindKthLargest(nums, target);
            //Assert
            //Assert.AreEqual(expected.Length, actual.Length);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethod3()
        {
            //Arrage
            Sorting a = new Sorting();
            int[] nums = new int[] {};
            int target = 0;
            int expected = 0;

            //Act
            var actual = a.FindKthLargest(nums, target);
            //Assert
            //Assert.AreEqual(expected.Length, actual.Length);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethod4()
        {
            //Arrage
            Sorting a = new Sorting();
            int[] nums = new int[] {1};
            int target = 1;
            int expected = 1;

            //Act
            var actual = a.FindKthLargest(nums, target);
            //Assert
            //Assert.AreEqual(expected.Length, actual.Length);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethod5()
        {
            //Arrage
            Sorting a = new Sorting();
            int[] nums = new int[] { 1,2 };
            int target = 1;
            int expected = 2;

            //Act
            var actual = a.FindKthLargest(nums, target);
            //Assert
            //Assert.AreEqual(expected.Length, actual.Length);
            Assert.AreEqual(expected, actual);

        }


    }
}
