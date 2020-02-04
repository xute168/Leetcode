using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leecode;

namespace LeecodeTest
{
    [TestClass]
    public class MinTimeToVisitAllPointsTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrage
            Solution a = new Solution();
            int[][] nums = new int[][] { new int[] { 1, 1 }, new int[] { 3, 4 }, new int[] { -1, 0 } }; ;
            
            int expected = 7;

            //Act
            var actual = a.MinTimeToVisitAllPoints(nums);
            //Assert
            //Assert.AreEqual(expected.Length, actual.Length);
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrage
            Solution a = new Solution();
            int[][] nums = new int[][] { new int[] { 3, 2 }, new int[] { -2, 2 } }; 

            int expected = 5;

            //Act
            var actual = a.MinTimeToVisitAllPoints(nums);
            //Assert
            //Assert.AreEqual(expected.Length, actual.Length);
            Assert.AreEqual(expected, actual);

        }
    }
}
