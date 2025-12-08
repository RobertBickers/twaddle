using CodeTreehouse.Twaddle.Core.Colour;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeTreehouse.Twaddle.Core.Tests
{
	[TestClass]
	public class ColourTest
	{
		private readonly IColourGenerator _systemUnderTest;

		public ColourTest()
		{
			_systemUnderTest = new ColourGenerator();
		}

		[TestMethod]
		public void GenerateColour_WithoutArgs_7CharacterStringReturned()
		{
			int expectedNumberOfCharacters = 7;
			string colourString = _systemUnderTest.GenerateColourString();

			int actualNumberOfCharacters = colourString.Length;

			Assert.AreEqual(expectedNumberOfCharacters, actualNumberOfCharacters);
		}

		[TestMethod]
		public void GenerateColour_WithoutArgs_StringStartsWithHash()
		{
			string colourString = _systemUnderTest.GenerateColourString();

            Assert.StartsWith("#", colourString);
		}

		[TestMethod]
		public void Generatecolour_WithoutArgs_ColourCanBeParsedBySystemDrawingColour()
		{
			string colourString = _systemUnderTest.GenerateColourString();

			System.Drawing.Color convertedColour = System.Drawing.ColorTranslator.FromHtml(colourString);

			Assert.IsFalse(convertedColour.IsEmpty);
			Assert.AreNotEqual(0, convertedColour.R);
			Assert.AreNotEqual(0, convertedColour.G);
			Assert.AreNotEqual(0, convertedColour.B);
		}

		[TestMethod]
		public void GenerateColour_WithoutArgs_ColorReturned()
		{
			System.Drawing.Color color = _systemUnderTest.GenerateColour();

			Assert.IsFalse(color.IsEmpty);
		}
	}
}