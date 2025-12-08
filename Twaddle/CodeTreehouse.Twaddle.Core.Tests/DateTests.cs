using CodeTreehouse.Twaddle.Core.Date;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CodeTreehouse.Twaddle.Core.Tests
{
	[TestClass]
	public class DateTests
	{
		private readonly IDateGenerator _dateGenerator;

		public DateTests()
		{
			_dateGenerator = new DateGenerator();
		}

		[TestMethod]
		public void MakeDate_WthNullArgs_DateGeneratedBetweenCSharpMinAndMax()
		{
			DateTime generatedDate = _dateGenerator.GenerateDate((DateTime?)null, (DateTime?)null);

			Assert.IsTrue(generatedDate > DateTime.MinValue);
			Assert.IsTrue(generatedDate < DateTime.MaxValue);
		}

		[TestMethod]
		public void MakeDate_WithMinStartDate_DateCreatedGreaterThanProvidedMinValue()
		{
			DateTime startDate = DateTime.Now;

			DateTime generatedDate = _dateGenerator.GenerateDate(startDate, (DateTime?)null);

			Assert.IsTrue(generatedDate > startDate);
			Assert.IsTrue(generatedDate < DateTime.MaxValue);
		}

		[TestMethod]
		public void MakeDate_WithMinStartDateAndMaxEndDate_DateCreatedBetweenTwoArguments()
		{
			DateTime startDate = DateTime.Now;
			DateTime endDate = DateTime.Now.AddDays(10);

			DateTime generatedDate = _dateGenerator.GenerateDate(startDate, endDate);

			Assert.IsTrue(generatedDate > startDate);
			Assert.IsTrue(generatedDate < endDate);
		}
	}
}