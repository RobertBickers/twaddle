using Codetreehouse.Twaddle.Generators;
using FluentAssertions;
using NUnit.Framework;

namespace Tests.UnitTesting.Name
{
	[TestFixture]
	public class NameTests
	{
		private readonly INameGenerator _systemUnderTest;

		public NameTests()
		{
			_systemUnderTest = new NameGenerator();
		}

		[Test()]
		public void GenerateFirstName_NoArgs_StringReturned()
		{
			string firstName = _systemUnderTest.FirstName();

			firstName.Should().NotBeNullOrEmpty();
		}

		[Test()]
		public void GenerateSecondName_NoArgs_StringReturned()
		{
			string secondName = _systemUnderTest.SecondName();

			secondName.Should().NotBeNullOrEmpty();
		}

		[Test()]
		public void GenerateFullName_NoArgs_StringReturned()
		{
			string fullName = _systemUnderTest.FullName();

			fullName.Should().NotBeNullOrEmpty();
		}

		[Test()]
		public void GenerateFullName_NoArgs_TwoWordsSeperatedBySpaceAreProvided()
		{
			string fullName = _systemUnderTest.FullName();

			string[] seperateWords = fullName.Split(' ');

			seperateWords.Should().HaveCount(2);
		}
	}
}