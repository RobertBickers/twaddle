
using CodeTreehouse.Twaddle.Contracts;

namespace CodeTreehouse.Twaddle.Core

{
    public static class Twaddle
    {
        private static ICredentialGenerator _credentialGenerator = null;
        /// <summary>
        /// Returns the credential generator
        /// </summary>
        public static Contracts.ICredentialGenerator Credentials
        {
            get
            {
                if (_credentialGenerator == null) _credentialGenerator = new Credentials.CredentialGenerator();
                return _credentialGenerator;
            }
        }

        private static IDateGenerator _dateGenerator = null;
        /// <summary>
        /// Returns the date generator
        /// </summary>
        public static Contracts.IDateGenerator Date
        {
            get
            {
                if (_dateGenerator == null) _dateGenerator = new Date.DateGenerator();
                return _dateGenerator;
            }
        }

        private static IPhoneGenerator _phoneGenerator = null;
        /// <summary>
        /// Returns the phone generator
        /// </summary>
        public static Contracts.IPhoneGenerator Phone
        {
            get
            {
                if (_phoneGenerator == null) _phoneGenerator = new Phone.PhoneGenerator();
                return _phoneGenerator;
            }
        }

        private static IWordGenerator _wordGenerator = null;
        /// <summary>
        /// Returns the word generator
        /// </summary>
        public static Contracts.IWordGenerator Word
        {
            get
            {
                if (_wordGenerator == null) _wordGenerator = new Word.WordGenerator();
                _wordGenerator.Setup(new Containers.Lorem.LoremWordContainer());

                return _wordGenerator;
            }
        }
    }
}