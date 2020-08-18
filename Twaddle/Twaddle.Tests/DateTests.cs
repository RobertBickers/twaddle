using Bickers.Twaddle.Core;
using NUnit.Framework;
using System;

namespace Tests.UnitTesting.DateMaker
{
    [TestFixture]
    public class DateTests
    {
        [Test()]
        public void MakeDate_WthNullArgs_DateGeneratedBetweenCSharpMinAndMax()
        {
            //Act
            DateTime generatedDate = Twaddle.Date.GenerateDate(null, null);

            //Assert
            Assert.IsTrue(generatedDate != null);
            Assert.IsTrue(generatedDate > DateTime.MinValue);
            Assert.IsTrue(generatedDate < DateTime.MaxValue);
        }

        [Test()]
        public void MakeDate_WithMinStartDate_DateCreatedGreaterThanProvidedMinValue()
        {
            //Arrange
            DateTime startDate = DateTime.Now;

            //Act
            DateTime generatedDate = Twaddle.Date.GenerateDate(startDate, null);

            //Assert
            Assert.IsTrue(generatedDate > startDate);
            Assert.IsTrue(generatedDate < DateTime.MaxValue);
        }

        [Test()]
        public void MakeDate_WithMinStartDateAndMaxEndDate_DateCreatedBetweenTwoArguments()
        {
            //Arrange
            DateTime startDate = DateTime.Now;
            DateTime endDate = DateTime.Now.AddDays(10);

            //Act
            DateTime generatedDate = Twaddle.Date.GenerateDate(startDate, endDate);

            //Assert
            Assert.IsTrue(generatedDate > startDate);
            Assert.IsTrue(generatedDate < endDate);
        }
    }
}