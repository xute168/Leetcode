using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leecode;

namespace LeecodeTest
{
    [TestClass]
    public class TwoSumTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrage
            Solution a = new Solution();
            int[] nums = new int[] { 3, 3 };
            int target = 6;
            int[] expected = new int[] { 0, 1 };

            //Act
            var actual = a.TwoSum(nums, target);
            //Assert
            //Assert.AreEqual(expected.Length, actual.Length);
            CollectionAssert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrage
            Solution a = new Solution();
            int[] nums = new int[] { 2, 7, 11, 19 };
            int target = 9;
            int[] expected = new int[] { 0, 1 };

            //Act
            var actual = a.TwoSum(nums, target);
            //Assert
            //Assert.AreEqual(expected.Length, actual.Length);
            CollectionAssert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethod3()
        {
            //Arrage
            Solution a = new Solution();
            int[] nums = new int[] { 2,  11, 7, 19 };
            int target = 9;
            int[] expected = new int[] { 0, 2 };

            //Act
            var actual = a.TwoSum(nums, target);
            //Assert
            //Assert.AreEqual(expected.Length, actual.Length);
            CollectionAssert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethod4()
        {
            //Arrage
            Solution a = new Solution();
            int[] nums = new int[] { 2, 11, 19, 7 };
            int target = 9;
            int[] expected = new int[] { 0, 3 };

            //Act
            var actual = a.TwoSum(nums, target);
            //Assert
            //Assert.AreEqual(expected.Length, actual.Length);
            CollectionAssert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethod5()
        {
            //Arrage
            Solution a = new Solution();
            int[] nums = new int[] { 11, 7, 19, 2 };
            int target = 9;
            int[] expected = new int[] { 1, 3 };

            //Act
            var actual = a.TwoSum(nums, target);
            //Assert
            //Assert.AreEqual(expected.Length, actual.Length);
            CollectionAssert.AreEqual(expected, actual);

        }

        //[TestMethod]
        //public void TestMethod6()
        //{
        //    //Arrage
        //    Solution a = new Solution();
        //    int[] nums = new int[] { 3, 3, 7, 3, 3 };
        //    int target = 12;
        //    int[] expected = new int[] { 0, 1, 3, 4 };

        //    //Act
        //    var actual = a.TwoSum(nums, target);
        //    //Assert
        //    //Assert.AreEqual(expected.Length, actual.Length);
        //    CollectionAssert.AreEqual(expected, actual);

        //}

        [TestMethod]
        public void TestMethod7()
        {
            //Arrage
            Solution a = new Solution();
            int[] nums = new int[] { 2, 5, 5, 11 };
            int target = 10;
            int[] expected = new int[] { 1, 2 };

            //Act
            var actual = a.TwoSum(nums, target);
            //Assert
            //Assert.AreEqual(expected.Length, actual.Length);
            CollectionAssert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethod8()
        {
            //Arrage
            Solution a = new Solution();
            int[] nums = new int[] { 0, 4, 3, 0 };
            int target = 0;
            int[] expected = new int[] { 0, 3 };

            //Act
            var actual = a.TwoSum(nums, target);
            //Assert
            //Assert.AreEqual(expected.Length, actual.Length);
            CollectionAssert.AreEqual(expected, actual);

        }

        //[TestMethod]
        //public void TestMethod9()
        //{
        //    //Arrage
        //    Solution a = new Solution();
        //    int[] nums = new int[] { 0, 4, 3, 0 };
        //    int target = 3;
        //    int[] expected = new int[] { 0, 2, 3 };

        //    //Act
        //    var actual = a.TwoSum(nums, target);
        //    //Assert
        //    //Assert.AreEqual(expected.Length, actual.Length);
        //    CollectionAssert.AreEqual(expected, actual);

        //}

        [TestMethod]
        public void TestMethod10()
        {
            //Arrage
            Solution a = new Solution();
            int[] nums = new int[] { 3, 2, 4 };
            int target = 6;
            int[] expected = new int[] { 1, 2 };

            //Act
            var actual = a.TwoSum(nums, target);
            //Assert
            //Assert.AreEqual(expected.Length, actual.Length);
            CollectionAssert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethod11()
        {
            //Arrage
            Solution a = new Solution();
            int[] nums = new int[] { -3, 4, 3, 90 };
            int target = 0;
            int[] expected = new int[] { 0, 2 };

            //Act
            var actual = a.TwoSum(nums, target);
            //Assert
            //Assert.AreEqual(expected.Length, actual.Length);
            CollectionAssert.AreEqual(expected, actual);

        }
    }
}
