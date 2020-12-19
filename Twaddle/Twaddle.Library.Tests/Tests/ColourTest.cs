using Codetreehouse.Generation;
using FluentAssertions;
using NUnit.Framework;

namespace Tests.UnitTesting.Color
{
	[TestFixture]
	public class ColourTest
	{
		private readonly IColourGenerator _systemUnderTest;

		public ColourTest()
		{
			_systemUnderTest = new ColourGenerator();
		}

		[Test()]
		public void GenerateColour_WithoutArgs_7CharacterStringReturned()
		{
			int expectedNumberOfCharacters = 7;
			string colourString = _systemUnderTest.GenerateColourString();

			int actualNumberOfCharacters = colourString.Length;

			actualNumberOfCharacters.Should().Be(expectedNumberOfCharacters);
		}

		[Test()]
		public void GenerateColour_WithoutArgs_StringStartsWithHash()
		{
			string colourString = _systemUnderTest.GenerateColourString();

			colourString.Should().StartWith("#");
		}

		[Test()]
		public void Generatecolour_WithoutArgs_ColourCanBeParsedBySystemDrawingColour()
		{
			string colourString = _systemUnderTest.GenerateColourString();

			System.Drawing.Color convertedColour = System.Drawing.ColorTranslator.FromHtml(colourString);

			convertedColour.IsEmpty.Should().BeFalse();
			convertedColour.R.Should().NotBe(0);
			convertedColour.G.Should().NotBe(0);
			convertedColour.B.Should().NotBe(0);
		}

		[Test()]
		public void GenerateColour_WithoutArgs_ColorReturned()
		{
			System.Drawing.Color color = _systemUnderTest.GenerateColour();

			color.IsEmpty.Should().BeFalse();
		}
	}
}