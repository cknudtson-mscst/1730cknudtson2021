using Ex2E1___Loops;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace cknudtson2E1UnitTests
{
    [TestClass]
    public class LogicalOperationsUnitTests
    {
        [TestMethod]
        public void TestQ01BelowRange(int subtotal)
        {
            Assert.IsFalse(LogicalOperations.q01(249));
        }
        [TestMethod]
        public void TestQ01AtMin(int subtotal)
        {
            Assert.IsTrue(LogicalOperations.q01(250));
        }
        [TestMethod]
        public void TestQ01AtMax(int subtotal)
        {
            Assert.IsTrue(LogicalOperations.q01(499));
        }
        [TestMethod]
        public void TestQ01AboveRange(int subtotal)
        {
            Assert.IsFalse(LogicalOperations.q01(500));
        }
        [TestMethod]
        public void TestQ02BelowRange(int timeInService)
        {
            Assert.IsTrue(LogicalOperations.q02(4));
        }
        [TestMethod]
        public void TestQ02BottomOfExcludedRange(int timeInService)
        {
            Assert.IsFalse(LogicalOperations.q02(5));
        }
        [TestMethod]
        public void TestQ02TopOfExcludedRange(int timeInService)
        {
            Assert.IsFalse(LogicalOperations.q02(11));
        }
        [TestMethod]
        public void TestQ02AboveRange(int timeInService)
        {
            Assert.IsTrue(LogicalOperations.q02(12));
        }
        [TestMethod]
        public void TestQ03Invalid(bool isValid, int counter, int years)
        {
            Assert.IsFalse(LogicalOperations.q03(false, 0, 0));
        }
        [TestMethod]
        public void TestQ03CounterLessThanYears(bool isValid, int counter, int years)
        {
            Assert.IsTrue(LogicalOperations.q03(true, 1, 0));
        }
        [TestMethod]
        public void TestQ03CounterNotLessThanYears(bool isValid, int counter, int years)
        {
            Assert.IsFalse(LogicalOperations.q03(true, 0, 0));
        }
        [TestMethod]
        public void TestQ04Invalid(bool isValid, int counter, int years)
        {
            Assert.IsFalse(LogicalOperations.q04(false, 1, 0));
        }
        [TestMethod]
        public void TestQ04CounterLessThanYears(bool isValid, int counter, int years)
        {
            Assert.IsTrue(LogicalOperations.q04(true, 1, 0));
        }
        [TestMethod]
        public void TestQ04CounterNotLessThanYears(bool isValid, int counter, int years)
        {
            Assert.IsFalse(LogicalOperations.q04(true, 1, 1));
        }
        [TestMethod]
        public void TestQ05IsValidTrue(bool isValid, int counter, int years)
        {
            Assert.IsTrue(LogicalOperations.q05(true, 0, 0));
        }
        [TestMethod]
        public void TestQ05CounterLessThanYears(bool isValid, int counter, int years)
        {
            Assert.IsTrue(LogicalOperations.q05(false, 1, 0));
        }
        [TestMethod]
        public void TestQ05CounterNotLessThanYears(bool isValid, int counter, int years)
        {
            Assert.IsFalse(LogicalOperations.q05(false, 0, 0));
        }
        [TestMethod]
        public void TestQ06IsValidTrue(bool isValid, int counter, int years)
        {
            Assert.IsTrue(LogicalOperations.q06(true, 0, 0));
        }
        [TestMethod]
        public void TestQ06CounterLessThanYears(bool isValid, int counter, int years)
        {
            Assert.IsTrue(LogicalOperations.q06(false, 1, 0));
        }
        [TestMethod]
        public void TestQ06CounterNotLessThanYears(bool isValid, int counter, int years)
        {
            Assert.IsFalse(LogicalOperations.q06(false, 0, 0));
        }
        [TestMethod]
        public void TestQ07IsValidTrue(DateTime startDate,
        DateTime expirationDate, DateTime date, bool isValid)
        {
            Assert.IsTrue(LogicalOperations.Q07(
                DateTime.Parse("1/1/2019"),
                DateTime.Parse("2/1/2019"),
                DateTime.Parse("2/2/2019"),
                true));
        }
        [TestMethod]
        public void TestQ07DateBelowRange(DateTime startDate,
        DateTime expirationDate, DateTime date, bool isValid)
        {
            Assert.IsFalse(LogicalOperations.Q07(
                DateTime.Parse("1/1/2019"),
                DateTime.Parse("2/1/2019"),
                DateTime.Parse("1/1/2019"),
                false));
        }
        [TestMethod]
        public void TestQ07DateAtMinRange(DateTime startDate,
        DateTime expirationDate, DateTime date, bool isValid)
        {
            Assert.IsTrue(LogicalOperations.Q07(
                DateTime.Parse("1/1/2019"),
                DateTime.Parse("2/1/2019"),
                DateTime.Parse("1/2/2019"),
                false));
        }
        [TestMethod]
        public void TestQ07DateAtMaxRange(DateTime startDate,
        DateTime expirationDate, DateTime date, bool isValid)
        {
            Assert.IsTrue(LogicalOperations.Q07(
                DateTime.Parse("1/1/2019"),
                DateTime.Parse("2/1/2019"),
                DateTime.Parse("1/31/2019"),
                false));
        }
        [TestMethod]
        public void TestQ07DateAboveRange(DateTime startDate,
        DateTime expirationDate, DateTime date, bool isValid)
        {
            Assert.IsFalse(LogicalOperations.Q07(
                DateTime.Parse("1/1/2019"),
                DateTime.Parse("2/1/2019"),
                DateTime.Parse("2/1/2019"),
                false));
        }
        [TestMethod]
        public void TestQ08PartTimeValidYears(int thisYTD, int lastYTD, string empType, int startYear, int currentYear)
        {
            Assert.IsTrue(LogicalOperations.q08(
                0, 0, "Part time", 2018, 2019));
        }
        [TestMethod]
        public void TestQ08ValidYTD_NotPartTime_ValidYears(int thisYTD, int lastYTD, string empType, int startYear, int currentYear)
        {
            Assert.IsTrue(LogicalOperations.q08(
                1, 0, "", 2018, 2019));
        }
        [TestMethod]
        public void TestQ08InvalidYTD_NotPartTime_ValidYears(int thisYTD, int lastYTD, string empType, int startYear, int currentYear)
        {
            Assert.IsFalse(LogicalOperations.q08(
                0, 0, "", 2018, 2019));
        }
        [TestMethod]
        public void TestQ08PartTime_InvalidYears(int thisYTD, int lastYTD, string empType, int startYear, int currentYear)
        {
            Assert.IsFalse(LogicalOperations.q08(
                0, 0, "Part time", 2019, 2019));
        }
        [TestMethod]
        public void TestQ09InvalidCounter()
        {
            Assert.IsFalse(LogicalOperations.q09(0, 0));
        }
        [TestMethod]
        public void TestQ09ValidCounter(int Counter, int Years)
        {
            Assert.IsTrue(LogicalOperations.q09(0, 1));
        }

        // You can add more test methods here....


    }
}
