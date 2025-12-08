using CodeTreehouse.Twaddle.Core.Colour;
using CodeTreehouse.Twaddle.Core.Credentials;
using CodeTreehouse.Twaddle.Core.Date;
using CodeTreehouse.Twaddle.Core.Name;
using CodeTreehouse.Twaddle.Core.Phone;
using CodeTreehouse.Twaddle.Core.Word;

namespace CodeTreehouse.Twaddle.Core;

public interface ITwaddle
{
	ICredentialGenerator Profile { get; }
	IDateGenerator Date { get; }
	IPhoneGenerator Phone { get; }
	IColourGenerator Colour { get; }
	IWordGenerator Word { get; }
	INameGenerator Name { get; }
}