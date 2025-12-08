using CodeTreehouse.Twaddle.Core.Colour;
using CodeTreehouse.Twaddle.Core.Credentials;
using CodeTreehouse.Twaddle.Core.Date;
using CodeTreehouse.Twaddle.Core.Name;
using CodeTreehouse.Twaddle.Core.Phone;
using CodeTreehouse.Twaddle.Core.Word;

namespace CodeTreehouse.Twaddle.Core.Configuration;

public interface ITwaddleConfiguration
{
	ICredentialGenerator CredentialConfig { get; }

	IDateGenerator DateConfig { get; }

	IPhoneGenerator PhoneConfig { get; }

	IColourGenerator ColourConfig { get; }

	IWordGenerator WordConfig { get; }

	INameGenerator NameGenerator { get; }
}