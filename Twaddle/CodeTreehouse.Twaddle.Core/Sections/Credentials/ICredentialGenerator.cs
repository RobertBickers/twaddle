namespace CodeTreehouse.Twaddle.Core.Credentials;

public interface ICredentialGenerator
{
	/// <summary>
	/// Generates a password string
	/// </summary>
	/// <param name="allowSpecialCharacters">Whether or not special characters will be used in the password</param>
	/// <param name="maxLength">The maximum length of the password</param>
	/// <param name="minLength">The minumum length of the password</param>
	/// <returns></returns>
	string GeneratePassword(bool allowSpecialCharacters, int maxLength, int minLength = 6);

	/// <summary>
	/// Generates a random email address using the domain provided
	/// </summary>
	/// <param name="domain">The text that will appear after the '@' symbol within the string</param>
	/// <param name="enforceUnique">The name section of the email address will be forced unique by using a GUID</param>
	/// <returns>Returns something</returns>
	string GenerateEmail(string domain, bool enforceUnique = false);
}