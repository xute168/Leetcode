using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leecode;
using System.Collections.Generic;

namespace LeecodeTest
{
    [TestClass]
    public class PrintVerticallyTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrage
            Solution a = new Solution();
            string nums = "HOW ARE YOU";
            List<string> expected = new List<string> { "HAY", "ORO", "WEU" };

            //Act
            List<string> actual = new List<string>(a.PrintVertically(nums));
            //Assert
            //Assert.AreEqual(expected.Length, actual.Length);
            CollectionAssert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrage
            Solution a = new Solution();
            string nums = "TO BE OR NOT TO BE";
            List<string> expected = new List<string> { "TBONTB", "OEROOE", "   T" };

            //Act
            List<string> actual = new List<string>(a.PrintVertically(nums));
            //Assert
            //Assert.AreEqual(expected.Length, actual.Length);
            CollectionAssert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethod3()
        {
            //Arrage
            Solution a = new Solution();
            string nums = "CONTEST IS COMING";
            List<string> expected = new List<string> { "CIC", "OSO", "N M", "T I", "E N", "S G", "T" };

            //Act
            List<string> actual = new List<string>(a.PrintVertically(nums));
            //Assert
            //Assert.AreEqual(expected.Length, actual.Length);
            CollectionAssert.AreEqual(expected, actual);

        }

      
    }
}
