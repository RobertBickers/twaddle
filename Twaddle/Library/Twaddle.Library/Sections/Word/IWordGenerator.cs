using Codetreehouse.Twaddle.Containers;

namespace Codetreehouse.Twaddle.Generators
{
	public interface IWordGenerator
	{
		void Setup(WordListContainer container);

		/// <summary>
		/// Generates a single word
		/// </summary>
		/// <returns></returns>
		string GenerateWord();

		/// <summary>
		/// Generates a random sentence with the provided number of words
		/// </summary>
		/// <param name="numberOfWords">The number of words that will be included in the sentence</param>
		/// <param name="append">(Optional) The word that the sentencee will begin with</param>
		/// <param name="prepend">(Optional) The word that the sentence will end with</param>
		/// <returns></returns>
		string GenerateSentence(int numberOfWords, string append = "", string prepend = "");
	}
}