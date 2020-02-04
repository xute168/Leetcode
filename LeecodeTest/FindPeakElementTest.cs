using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leecode;


namespace LeecodeTest
{
    [TestClass]
    public class FindPeakElementTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrage
            BinarySearch a = new BinarySearch();
            int[] nums = new int[] { 1, 2, 3, 1 };
            int expected = 2;

            //Act
            var actual = a.FindPeakElement(nums);
            //Assert
            //Assert.AreEqual(expected.Length, actual.Length);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrage
            BinarySearch a = new BinarySearch();
            int[] nums = new int[] { 1, 2, 1, 3, 5, 6, 4 };
            int expected = 5;

            //Act
            var actual = a.FindPeakElement(nums);
            //Assert
            //Assert.AreEqual(expected.Length, actual.Length);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethod3()
        {
            //Arrage
            BinarySearch a = new BinarySearch();
            int[] nums = new int[] { 1, 2 };
            int expected = 1;

            //Act
            var actual = a.FindPeakElement(nums);
            //Assert
            //Assert.AreEqual(expected.Length, actual.Length);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethod4()
        {
            //Arrage
            BinarySearch a = new BinarySearch();
            int[] nums = new int[] { 3, 2, 1 };
            int expected = 0;

            //Act
            var actual = a.FindPeakElement(nums);
            //Assert
            //Assert.AreEqual(expected.Length, actual.Length);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethod5()
        {
            //Arrage
            BinarySearch a = new BinarySearch();
            int[] nums = new int[] { 1, 2, 3 };
            int expected = 2;

            //Act
            var actual = a.FindPeakElement(nums);
            //Assert
            //Assert.AreEqual(expected.Length, actual.Length);
            Assert.AreEqual(expected, actual);

        }

    }
}
