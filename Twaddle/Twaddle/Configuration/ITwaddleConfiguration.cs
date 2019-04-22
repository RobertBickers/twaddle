using Bickers.Twaddle.Colour;
using Bickers.Twaddle.Contracts;
using Bickers.Twaddle.Credentials;
using Bickers.Twaddle.Date;
using Bickers.Twaddle.Phone;
using Bickers.Twaddle.Word;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bickers.Twaddle.Configuration
{

    /// <summary>
    /// Configuration contract for the Twaddle generation implementations
    /// </summary>
    public interface ITwaddleConfiguration
    {
        /// <summary>
        /// Handles the generation of credentials
        /// </summary>
        ICredentialGenerator Credential { get; }

        /// <summary>
        /// Handles the generation of dates
        /// </summary>
        IDateGenerator Date { get; }

        /// <summary>
        /// Handles the generation of phone numbers
        /// </summary>
        IPhoneGenerator Phone { get; }

        /// <summary>
        /// Handles the generation of phone numbers
        /// </summary>
        IColourGenerator Colour { get; }

        /// <summary>
        /// Handles the generation of words and sentences
        /// </summary>
        IWordGenerator Word { get; }
    }


    public class DefaultTwaddleConfiguration : ITwaddleConfiguration
    {
        private static readonly Lazy<CredentialGenerator> credentialLazyValue = new Lazy<CredentialGenerator>(() => new CredentialGenerator());
        private static readonly Lazy<DateGenerator> dateLazyValue = new Lazy<DateGenerator>(() => new DateGenerator());
        private static readonly Lazy<PhoneGenerator> phoneLazyValue = new Lazy<PhoneGenerator>(() => new PhoneGenerator());
        private static readonly Lazy<ColourGenerator> colourLazyValue = new Lazy<ColourGenerator>(() => new ColourGenerator());
        private static readonly Lazy<WordGenerator> wordLazyValue = new Lazy<WordGenerator>(() => new WordGenerator());

        ICredentialGenerator ITwaddleConfiguration.Credential => credentialLazyValue.Value;
        IDateGenerator ITwaddleConfiguration.Date => dateLazyValue.Value;
        IPhoneGenerator ITwaddleConfiguration.Phone => phoneLazyValue.Value;
        IColourGenerator ITwaddleConfiguration.Colour => colourLazyValue.Value;
        IWordGenerator ITwaddleConfiguration.Word => wordLazyValue.Value;
    }
}
