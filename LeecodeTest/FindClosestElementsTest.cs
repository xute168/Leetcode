using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leecode;
using System.Collections.Generic;

namespace LeecodeTest
{
    [TestClass]
    public class FindClosestElementsTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrage
            BinarySearch a = new BinarySearch();
            int[] nums = new int[] { 1, 2, 3, 4, 5 };
            int k = 4;
            int x = 3;
            //int[] expected = new int[] { 1, 2, 3, 4 };
            List<int> expected =new List<int>(){ 1, 2, 3, 4 };

            //Act
            List<int> actual = new List<int>(a.FindClosestElements(nums, k, x));
            //Assert
            //Assert.AreEqual(expected.Length, actual.Length);
            CollectionAssert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrage
            BinarySearch a = new BinarySearch();
            int[] nums = new int[] { 1, 2, 3, 4, 5 };
            int k = 4;
            int x = -1;
            //int[] expected = new int[] { 1, 2, 3, 4 };
            List<int> expected = new List<int>() { 1, 2, 3, 4 };

            //Act
            List<int> actual = new List<int>(a.FindClosestElements(nums, k, x));
            //Assert
            //Assert.AreEqual(expected.Length, actual.Length);
            CollectionAssert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethod3()
        {
            //Arrage
            BinarySearch a = new BinarySearch();
            int[] nums = new int[] { 1 };
            int k = 1;
            int x = 1;
            //int[] expected = new int[] { 1, 2, 3, 4 };
            List<int> expected = new List<int>() { 1 };

            //Act
            List<int> actual = new List<int>(a.FindClosestElements(nums, k, x));
            //Assert
            //Assert.AreEqual(expected.Length, actual.Length);
            CollectionAssert.AreEqual(expected, actual);


        }

        [TestMethod]
        public void TestMethod4()
        {
            //Arrage
            BinarySearch a = new BinarySearch();
            int[] nums = new int[] {1, 1, 1, 10, 10, 10};
            int k = 1;
            int x = 9;
            //int[] expected = new int[] { 1, 2, 3, 4 };
            List<int> expected = new List<int>() { 10 };

            //Act
            List<int> actual = new List<int>(a.FindClosestElements(nums, k, x));
            //Assert
            //Assert.AreEqual(expected.Length, actual.Length);
            CollectionAssert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethod5()
        {
            //Arrage
            BinarySearch a = new BinarySearch();
            int[] nums = new int[] { 1, 1, 1, 10, 10, 10 };
            int k = 1;
            int x = 2;
            //int[] expected = new int[] { 1, 2, 3, 4 };
            List<int> expected = new List<int>() { 1 };

            //Act
            List<int> actual = new List<int>(a.FindClosestElements(nums, k, x));
            //Assert
            //Assert.AreEqual(expected.Length, actual.Length);
            CollectionAssert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethod6()
        {
            //Arrage
            BinarySearch a = new BinarySearch();
            int[] nums = new int[] { 1, 3, 3, 4, 5, 7, 7, 8, 8, 8};
            int k = 6;
            int x = 6;
            //int[] expected = new int[] { 1, 2, 3, 4 };
            List<int> expected = new List<int>() { 4, 5, 7, 7, 8, 8 };

            //Act
            List<int> actual = new List<int>(a.FindClosestElements(nums, k, x));
            //Assert
            //Assert.AreEqual(expected.Length, actual.Length);
            CollectionAssert.AreEqual(expected, actual);

        }

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
