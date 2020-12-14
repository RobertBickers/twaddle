using Codetreehouse.Twaddle.Configuration;
using Codetreehouse.Twaddle.Generators;
using System;

namespace Codetreehouse.Twaddle.Core
{
    public class Twaddle : ITwaddle
    {
        public virtual ITwaddleConfiguration Configuration { get; }

        internal Twaddle(ITwaddleConfiguration configuration)
            => (Configuration) = (configuration);

        public static ITwaddle WithDefaults
             => new Twaddle(new TwaddleConfiguration(null, null, null, null, null, null));

        public static ITwaddle WithConfiguration(
            ICredentialGenerator? credentialGenerator,
            IDateGenerator? dateGenerator,
            IPhoneGenerator? phoneGenerator,
            IColourGenerator? colourGenerator,
            IWordGenerator? wordGenerator,
            INameGenerator? nameGenerator)
            => new Twaddle(
                new TwaddleConfiguration(
                    credentialGenerator,
                    dateGenerator,
                    phoneGenerator,
                    colourGenerator,
                    wordGenerator,
                    nameGenerator
                    )
                );

        public static ITwaddle WithConfiguration(
            ITwaddleConfiguration configuration)
            => new Twaddle(configuration);

        public ICredentialGenerator Profile => Configuration.CredentialConfig;

        public IDateGenerator Date => Configuration.DateConfig;

        public IPhoneGenerator Phone => Configuration.PhoneConfig;

        public IColourGenerator Colour => Configuration.ColourConfig;

        public IWordGenerator Word => Configuration.WordConfig;

        public INameGenerator Name => Configuration.NameGenerator;
    }
}