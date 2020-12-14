using Bickers.Twaddle.Generators;
using System;

namespace Bickers.Twaddle.Configuration
{
    /// <summary>
    /// Default Twaddle Configuration
    /// </summary>
    public class TwaddleConfiguration : ITwaddleConfiguration
    {
        private static readonly Lazy<ICredentialGenerator> credentialLazyValue = new Lazy<ICredentialGenerator>(()
            => new CredentialGenerator());

        private static readonly Lazy<IDateGenerator> dateLazyValue = new Lazy<IDateGenerator>(()
            => new DateGenerator());

        private static readonly Lazy<IPhoneGenerator> phoneLazyValue = new Lazy<IPhoneGenerator>(()
            => new PhoneGenerator());

        private static readonly Lazy<IColourGenerator> colourLazyValue = new Lazy<IColourGenerator>(()
            => new ColourGenerator());

        private static readonly Lazy<IWordGenerator> wordLazyValue = new Lazy<IWordGenerator>(()
            => new WordGenerator());

        private static readonly Lazy<INameGenerator> nameLazyValue = new Lazy<INameGenerator>(()
            => new NameGenerator());

        public virtual ICredentialGenerator CredentialConfig
            => credentialLazyValue.Value;

        public virtual IDateGenerator DateConfig
            => dateLazyValue.Value;

        public virtual IPhoneGenerator PhoneConfig
            => phoneLazyValue.Value;

        public virtual IColourGenerator ColourConfig
            => colourLazyValue.Value;

        public virtual IWordGenerator WordConfig
            => wordLazyValue.Value;

        public virtual INameGenerator NameGenerator
            => nameLazyValue.Value;
    }
}