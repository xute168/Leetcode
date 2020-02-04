using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leecode;

namespace LeecodeTest
{
    [TestClass]
    public class KWeakestRowsTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrage
            Solution a = new Solution();
            int[][] nums = new int[][] { new int[] { 1, 1, 0, 0, 0 }, new int[] { 1, 1, 1, 1, 0 }, new int[] { 1, 0, 0, 0, 0 }, new int[] { 1, 1, 0, 0, 0 }, new int[] { 1, 1, 1, 1, 1 } };
            int target = 3;
            int[] expected = new int[] { 2, 0, 3 };

            //Act
            var actual = a.KWeakestRows(nums, target);
            //Assert
            //Assert.AreEqual(expected.Length, actual.Length);
            CollectionAssert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrage
            Solution a = new Solution();
            int[][] nums = new int[][] { new int[] { 1, 0, 0, 0 }, new int[] { 1, 1, 1, 1 }, new int[] { 1, 0, 0, 0 }, new int[] { 1, 0, 0, 0 } };
            int target = 2;
            int[] expected = new int[] { 0, 2 };

            //Act
            var actual = a.KWeakestRows(nums, target);
            //Assert
            //Assert.AreEqual(expected.Length, actual.Length);
            CollectionAssert.AreEqual(expected, actual);

        }

       
    }
}
