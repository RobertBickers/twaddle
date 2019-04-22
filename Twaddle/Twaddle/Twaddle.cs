using Bickers.Twaddle.Colour;
using Bickers.Twaddle.Configuration;
using Bickers.Twaddle.Contracts;

namespace Bickers.Twaddle.Core
{
    public static class Twaddle
    {

        static Twaddle()
        {
            _twaddleConfiguration = new DefaultTwaddleConfiguration();
        }


        private static ITwaddleConfiguration _twaddleConfiguration = null;
        public static void OverrideConfiguration(ITwaddleConfiguration configuration)
        {
            _twaddleConfiguration = configuration;
        }


        /// <summary>
        /// Handles generation of email addresses and passwords
        /// </summary>
        public static ICredentialGenerator Profile => _twaddleConfiguration.Credential;

        /// <summary>
        /// Handles generation of dates
        /// </summary>
        public static IDateGenerator Date => _twaddleConfiguration.Date;

        /// <summary>
        /// Handles generation of phone numbers
        /// </summary>
        public static IPhoneGenerator Phone => _twaddleConfiguration.Phone;


        /// <summary>
        /// Handles generation of colours
        /// </summary>
        public static IColourGenerator Colour => _twaddleConfiguration.Colour;

        /// <summary>
        /// Handles generation of words and sentences
        /// </summary>
        public static IWordGenerator Word => _twaddleConfiguration.Word;
    }
}