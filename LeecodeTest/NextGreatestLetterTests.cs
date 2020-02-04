using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leecode;

namespace LeecodeTest
{
    [TestClass]
    public class NextGreatestLetterTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrage
            Solution a = new Solution();
            char[] nums = new char[] { 'c', 'f', 'j' };
            char target = 'a';
            char expected = 'c';

            //Act
            var actual = a.NextGreatestLetter(nums, target);
            //Assert
            //Assert.AreEqual(expected.Length, actual.Length);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrage
            Solution a = new Solution();
            char[] nums = new char[] { 'c', 'f', 'j' };
            char target = 'c';
            char expected = 'f';

            //Act
            var actual = a.NextGreatestLetter(nums, target);
            //Assert
            //Assert.AreEqual(expected.Length, actual.Length);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethod3()
        {
            //Arrage
            Solution a = new Solution();
            char[] nums = new char[] { 'c', 'f', 'j' };
            char target = 'd';
            char expected = 'f';

            //Act
            var actual = a.NextGreatestLetter(nums, target);
            //Assert
            //Assert.AreEqual(expected.Length, actual.Length);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethod4()
        {
            //Arrage
            Solution a = new Solution();
            char[] nums = new char[] { 'c', 'f', 'j' };
            char target = 'g';
            char expected = 'j';

            //Act
            var actual = a.NextGreatestLetter(nums, target);
            //Assert
            //Assert.AreEqual(expected.Length, actual.Length);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethod5()
        {
            //Arrage
            Solution a = new Solution();
            char[] nums = new char[] { 'c', 'f', 'j' };
            char target = 'j';
            char expected = 'c';

            //Act
            var actual = a.NextGreatestLetter(nums, target);
            //Assert
            //Assert.AreEqual(expected.Length, actual.Length);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethod6()
        {
            //Arrage
            Solution a = new Solution();
            char[] nums = new char[] { 'a', 'b' };
            char target = 'z';
            char expected = 'a';
            
            //Act
            var actual = a.NextGreatestLetter(nums, target);
            //Assert
            //Assert.AreEqual(expected.Length, actual.Length);
            Assert.AreEqual(expected, actual);

        }


    }
}
