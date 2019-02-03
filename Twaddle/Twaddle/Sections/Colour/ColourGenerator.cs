using Bickers.Twaddle.Sections.Colour;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Bickers.Twaddle.Colour
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
            var colour = String.Format("#{0:X6}", random.Next(0x1000000));
            return colour;
        }

        /// <summary>
        /// Generates a random colour
        /// </summary>
        /// <returns></returns>
        public Color GenerateColour()
        {
            string colourString = this.GenerateColourString();
            Color colour = ColourHandler.FromHex(colourString);

            return colour;
        }


    }

}

