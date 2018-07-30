using System;
using System.Collections.Generic;
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
        /// Generates a random colour string
        /// </summary>
        /// <returns></returns>
        public string GenerateColourString()
        {
            var colour = String.Format("#{0:X6}", random.Next(0x1000000));
            return colour;
        }
    }

}
