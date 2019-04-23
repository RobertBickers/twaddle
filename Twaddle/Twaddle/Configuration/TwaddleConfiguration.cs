using Bickers.Twaddle.Colour;
using Bickers.Twaddle.Contracts;
using Bickers.Twaddle.Credentials;
using Bickers.Twaddle.Date;
using Bickers.Twaddle.Phone;
using Bickers.Twaddle.Word;
using System;

namespace Bickers.Twaddle.Configuration
{
    /// <summary>
    /// Default Twaddle Configuration
    /// </summary>
    public class TwaddleConfiguration : ITwaddleConfiguration
    {
        private static readonly Lazy<CredentialGenerator> credentialLazyValue = new Lazy<CredentialGenerator>(() => new CredentialGenerator());
        private static readonly Lazy<DateGenerator> dateLazyValue = new Lazy<DateGenerator>(() => new DateGenerator());
        private static readonly Lazy<PhoneGenerator> phoneLazyValue = new Lazy<PhoneGenerator>(() => new PhoneGenerator());
        private static readonly Lazy<ColourGenerator> colourLazyValue = new Lazy<ColourGenerator>(() => new ColourGenerator());
        private static readonly Lazy<WordGenerator> wordLazyValue = new Lazy<WordGenerator>(() => new WordGenerator());

        public virtual ICredentialGenerator Credential => credentialLazyValue.Value;
        public virtual IDateGenerator Date => dateLazyValue.Value;
        public virtual IPhoneGenerator Phone => phoneLazyValue.Value;
        public virtual IColourGenerator Colour => colourLazyValue.Value;
        public virtual IWordGenerator Word => wordLazyValue.Value;
    }
}
