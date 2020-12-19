using Codetreehouse.Twaddle.Generators;
using NUnit.Framework;
using System;

namespace Tests.UnitTesting.Date
{
    [TestFixture]
    public class DateTests
    {
        private readonly IDateGenerator _systemUnderTest;

        public DateTests()
        {
            _systemUnderTest = new DateGenerator();
        }

        [Test()]
        public void MakeDate_WthNullArgs_DateGeneratedBetweenCSharpMinAndMax()
        {
            DateTime generatedDate = _systemUnderTest.GenerateDate(null, null);

            Assert.IsTrue(generatedDate > DateTime.MinValue);
            Assert.IsTrue(generatedDate < DateTime.MaxValue);
        }

        [Test()]
        public void MakeDate_WithMinStartDate_DateCreatedGreaterThanProvidedMinValue()
        {
            DateTime startDate = DateTime.Now;

            DateTime generatedDate = _systemUnderTest.GenerateDate(startDate, null);

            Assert.IsTrue(generatedDate > startDate);
            Assert.IsTrue(generatedDate < DateTime.MaxValue);
        }

        [Test()]
        public void MakeDate_WithMinStartDateAndMaxEndDate_DateCreatedBetweenTwoArguments()
        {
            DateTime startDate = DateTime.Now;
            DateTime endDate = DateTime.Now.AddDays(10);

            DateTime generatedDate = _systemUnderTest.GenerateDate(startDate, endDate);

            Assert.IsTrue(generatedDate > startDate);
            Assert.IsTrue(generatedDate < endDate);
        }
    }
}