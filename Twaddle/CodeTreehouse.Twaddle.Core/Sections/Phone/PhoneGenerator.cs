using System;

namespace CodeTreehouse.Twaddle.Core.Phone;

internal class PhoneGenerator : IPhoneGenerator
{
	private static Random randomSeed = new Random();

	public string GeneratePhoneNumber(string prefix = "")
	{
		string phoneNumber = prefix;

		while (phoneNumber.Length < 11)
			phoneNumber += randomSeed.Next(0, 10);

		return phoneNumber.ToString();
	}
}