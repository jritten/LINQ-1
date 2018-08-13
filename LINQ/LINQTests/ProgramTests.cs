using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LINQTests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void TestIncrementAll()
        {
            // arrange
            var numList = new List<int> { 1, 2, 3 };
            var expectedResult = new List<int> { 2, 3, 4 };
            // act
            var TestResult = LINQ.Program.IncrementAll(numList);
            // assert
            CollectionAssert.AreEqual(expectedResult, TestResult);
        }
        [TestMethod]
        public void TestGetWhereDivisableBy()
        {
            // arrange
            var numList = new List<int> { 1, 2, 3, 4, 5 };
            int dividerNumber = 2;
            var expectedOutput = new int[2] { 2, 4 };
            // act
            var TestResult = LINQ.Program.GetWhereDivisableBy(numList, dividerNumber);
            // assert
            CollectionAssert.AreEqual(expectedOutput, TestResult);
        }
    }
}
