using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AbsolutePermutationTest
{
    [TestClass]
    public class AbsolutePermutationTest
    {
        [TestMethod]
        public void checkDivisionPositinforElementTrueTest()
        {
            int n = 2;
            int k = 1;

            Boolean result = AbsolutePermutation.checkDivisionPositinAndElement(n, k);

            Assert.AreEqual(true, result);

        }

        [TestMethod]
        public void checkDivisionPositinAndElementFalseTest()
        {
            int n = 7;
            int k = 3;

            Boolean result = AbsolutePermutation.checkDivisionPositinAndElement(n, k);

            Assert.AreEqual(false, result);

        }

        [TestMethod]
        public void checkInputValuesTrueTest()
        {
            int n = 2;
            int k = 1;

            Boolean result = AbsolutePermutation.checkInputValues(n, k);

            Assert.AreEqual(true, result);

        }
        [TestMethod]
        public void checkInputValuesTrueFor0Test()
        {
            int n = 1;
            int k = 0;

            Boolean result = AbsolutePermutation.checkInputValues(n, k);

            Assert.AreEqual(true, result);

        }

        [TestMethod]
        public void checkInputValuesFalseTest()
        {
            int n = 5;
            int k = 2;

            Boolean result = AbsolutePermutation.checkInputValues(n, k);

            Assert.AreEqual(false, result);

        }

        [TestMethod]
        public void absolutePermutationTestCase1Step1()
        {
            int n = 2;
            int k = 1;
            int[] result = AbsolutePermutation.absolutePermutation(n, k);

            Assert.AreEqual(2, result[0]);
            Assert.AreEqual(1, result[1]);


        }
        [TestMethod]
        public void absolutePermutationTestCase1Step2()
        {
            int n = 3;
            int k = 0;
            int[] result = AbsolutePermutation.absolutePermutation(n, k);

            Assert.AreEqual(1, result[0]);
            Assert.AreEqual(2, result[1]);
            Assert.AreEqual(3, result[2]);



        }
        [TestMethod]
        public void absolutePermutationTestCase1Step3()
        {
            int n = 3;
            int k = 2;
            int[] result = AbsolutePermutation.absolutePermutation(n, k);

            Assert.AreEqual(-1, result[0]);
        }

        [TestMethod]
        public void divisonValueForPositionTest()
        {
            int n = 1;
            int k = 2;
            int result = AbsolutePermutation.divisonValueForPosition(n, k);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void calculateValuePermutationTest()
        {
            int n = 3;
            int k = 0;
            int result = AbsolutePermutation.calculateValuePermutation(n, k);

            Assert.AreEqual(4, result);
        }
    }
}
