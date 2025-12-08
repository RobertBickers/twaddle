using System.Drawing;

namespace CodeTreehouse.Twaddle.Core.Colour;

/// <summary>
/// Handles the generation of colours
/// </summary>
public interface IColourGenerator
{
	/// <summary>
	/// Generates a random colour
	/// </summary>
	/// <returns></returns>
	Color GenerateColour();

	/// <summary>
	/// Generates a string colour type
	/// </summary>
	/// <returns></returns>
	string GenerateColourString();
}