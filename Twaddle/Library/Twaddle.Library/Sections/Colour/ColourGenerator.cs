using Bickers.Twaddle.Sections.Colour;
using System;
using System.Drawing;

namespace Bickers.Twaddle.Generators
{
	/// <summary>
	/// Handles the generation of colour strings
	/// </summary>
	public class ColourGenerator : IColourGenerator
	{
		private static Random random = new Random();

		/// <summary>
		/// Generates a random colour string in hex format
		/// </summary>
		/// <returns></returns>
		public string GenerateColourString()
		{
			var colour = string.Format("#{0:X6}", random.Next(0x1000000));
			return colour;
		}

		/// <summary>
		/// Generates a random colour
		/// </summary>
		/// <returns></returns>
		public Color GenerateColour()
		{
			string colourString = GenerateColourString();

			return colourString.FromHex();
		}
	}
}