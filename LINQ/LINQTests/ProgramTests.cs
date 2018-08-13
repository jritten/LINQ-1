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
        [TestMethod]
        public void TestAnyCapitals()
        {
            // arrange
            var stringWithCaps = "Testing";
            var stringWithoutCaps = "testing";
            // act
            var TestResultTrue = LINQ.Program.AnyCapitals(stringWithCaps);
            var TestResultFalse = LINQ.Program.AnyCapitals(stringWithoutCaps);
            // assert
            Assert.IsTrue(TestResultTrue);
            Assert.IsFalse(TestResultFalse);
        }
        [TestMethod]
        public void TestAllCapitals()
        {
            // arrange
            var stringAllCaps = "TESTING";
            var stringNotAllCaps = "TesTiNG";
            // act
            var TestResultTrue = LINQ.Program.AllCapitals(stringAllCaps);
            var TestResultsFalse = LINQ.Program.AllCapitals(stringNotAllCaps);
            // assert
            Assert.IsTrue(TestResultTrue);
            Assert.IsFalse(TestResultsFalse);
        }
        [TestMethod]
        public void TestNumPairs()
        {
            // arrange
            var inputDictionary = new Dictionary<int, string>();
            inputDictionary.Add(0, "hello");
            inputDictionary.Add(1, "there");
            var expectedCount = 2;
            // act
            var TestResult = LINQ.Program.NumPairs(inputDictionary);
            // assert
            Assert.AreEqual(TestResult, expectedCount);
        }
        [TestMethod]
        public void TestNumPairsWithKeyValue()
        {
            // arrange
            var inputDictionary = new Dictionary<int, string>();
            inputDictionary.Add(0, "hello");
            inputDictionary.Add(1, "there");
            inputDictionary.Add(2, "yo");
            var minKeyValue = 0;
            var valueLength = 10;
            var expectedCount = 2;
            // act
            var TestResult = LINQ.Program.NumPairsWithKeyValue(inputDictionary, minKeyValue, valueLength);
            // assert
            Assert.AreEqual(expectedCount, TestResult);
        }
        [TestMethod]
        public void TestGetDistinctWithValue()
        {
            // arrange
            var inputList = new List<double> { 1, 2, 3 };
            var minNum = 1;
            var expectedOutput = new List<double> { 2, 3 };
            // act
            var TestResult = LINQ.Program.GetDistinctWithValue(inputList, minNum);
            // assert
            CollectionAssert.AreEqual(expectedOutput, TestResult);
        }
    }
}
