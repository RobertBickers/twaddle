using Bickers.Twaddle.Contracts;

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


        /// <summary>
        /// Handles the generation of names
        /// </summary>
        INameGenerator Name { get; }
    }
}
