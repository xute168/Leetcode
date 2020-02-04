using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leecode;

namespace LeecodeTest
{
    [TestClass]
    public class SearchRangeTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrage
            Solution a = new Solution();
            int[] nums = new int[] { 5, 7, 7, 8, 8, 10 };
            int target = 5;
            int[] expected = new int[] { 0, 0 };

            //Act
            var actual = a.SearchRange(nums,target);
            //Assert
            //Assert.AreEqual(expected.Length, actual.Length);
            CollectionAssert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrage
            Solution a = new Solution();
            int[] nums = new int[] { 5, 7, 7, 8, 8, 10 };
            int target = 6;
            int[] expected = new int[] { -1, -1 };

            //Act
            var actual = a.SearchRange(nums, target);
            //Assert
            //Assert.AreEqual(expected.Length, actual.Length);
            CollectionAssert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethod3()
        {
            //Arrage
            Solution a = new Solution();
            int[] nums = new int[] { 5, 7, 7, 8, 8, 10 };
            int target = 7;
            int[] expected = new int[] { 1, 2 };

            //Act
            var actual = a.SearchRange(nums, target);
            //Assert
            //Assert.AreEqual(expected.Length, actual.Length);
            CollectionAssert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethod4()
        {
            //Arrage
            Solution a = new Solution();
            int[] nums = new int[] { 5, 7, 7, 8, 8, 10 };
            int target = 8;
            int[] expected = new int[] { 3, 4 };

            //Act
            var actual = a.SearchRange(nums, target);
            //Assert
            //Assert.AreEqual(expected.Length, actual.Length);
            CollectionAssert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethod5()
        {
            //Arrage
            Solution a = new Solution();
            int[] nums = new int[] { 5, 7, 7, 8, 8, 10 };
            int target = 10;
            int[] expected = new int[] { 5, 5 };

            //Act
            var actual = a.SearchRange(nums, target);
            //Assert
            //Assert.AreEqual(expected.Length, actual.Length);
            CollectionAssert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethod6()
        {
            //Arrage
            Solution a = new Solution();
            int[] nums = new int[] { 5, 7, 7, 8,8,8, 8, 10 };
            int target = 8;
            int[] expected = new int[] { 3, 6 };

            //Act
            var actual = a.SearchRange(nums, target);
            //Assert
            //Assert.AreEqual(expected.Length, actual.Length);
            CollectionAssert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethod7()
        {
            //Arrage
            Solution a = new Solution();
            int[] nums = new int[0];
            int target = 0 ;
            int[] expected = new int[] {-1,-1 };

            //Act
            var actual = a.SearchRange(nums, target);
            //Assert
            //Assert.AreEqual(expected.Length, actual.Length);
            CollectionAssert.AreEqual(expected, actual);

        }
    }
}
