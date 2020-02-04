using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leecode;

namespace LeecodeTest
{
    [TestClass]
    public class SumZeroTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrage
            Solution a = new Solution();            
            int target = 5;
            int[] expected = new int[] { 1,2,0, -1,-2 };

            //Act
            var actual = a.SumZero(target);
            //Assert
            //Assert.AreEqual(expected.Length, actual.Length);
            CollectionAssert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrage
            Solution a = new Solution();
            int target = 3;
            int[] expected = new int[] { 1, 0, -1 };

            //Act
            var actual = a.SumZero(target);
            //Assert
            //Assert.AreEqual(expected.Length, actual.Length);
            CollectionAssert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethod3()
        {
            //Arrage
            Solution a = new Solution();
            int target = 1;
            int[] expected = new int[] { 0 };

            //Act
            var actual = a.SumZero(target);
            //Assert
            //Assert.AreEqual(expected.Length, actual.Length);
            CollectionAssert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethod4()
        {
            //Arrage
            Solution a = new Solution();
            int target = 8;
            int[] expected = new int[] { 1,2,3,4,-1,-2,-3,-4 };

            //Act
            var actual = a.SumZero(target);
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

        
    }
}
