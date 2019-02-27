using Bickers.Twaddle.Colour;
using Bickers.Twaddle.Contracts;

namespace Bickers.Twaddle.Core
{
    public static class Twaddle
    {
        private static ICredentialGenerator _credentialGenerator = null;

        /// <summary>
        /// Handles generation of email addresses and passwords
        /// </summary>
        public static Contracts.ICredentialGenerator Profile
        {
            get
            {
                if (_credentialGenerator == null)
                    _credentialGenerator = new Credentials.CredentialGenerator();

                return _credentialGenerator;
            }
        }

        private static IDateGenerator _dateGenerator = null;

        /// <summary>
        /// Handles generation of dates
        /// </summary>
        public static Contracts.IDateGenerator Date
        {
            get
            {
                if (_dateGenerator == null)
                    _dateGenerator = new Date.DateGenerator();

                return _dateGenerator;
            }
        }

        private static IPhoneGenerator _phoneGenerator = null;

        /// <summary>
        /// Handles generation of phone numbers
        /// </summary>
        public static Contracts.IPhoneGenerator Phone
        {
            get
            {
                if (_phoneGenerator == null)
                    _phoneGenerator = new Phone.PhoneGenerator();

                return _phoneGenerator;
            }
        }

        private static IColourGenerator _colourGenerator = null;

        /// <summary>
        /// Handles generation of colours
        /// </summary>
        public static IColourGenerator Colour
        {
            get
            {
                if (_colourGenerator == null)
                    _colourGenerator = new ColourGenerator();

                return _colourGenerator;
            }
        }

        private static IWordGenerator _wordGenerator = null;

        /// <summary>
        /// Handles generation of words and sentences
        /// </summary>
        public static Contracts.IWordGenerator Word
        {
            get
            {
                if (_wordGenerator == null)
                    _wordGenerator = new Word.WordGenerator();

                _wordGenerator.Setup(new Containers.Lorem.LoremWordContainer());

                return _wordGenerator;
            }
        }
    }
}