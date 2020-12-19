using System.Collections.Generic;

namespace Codetreehouse.Twaddle.Containers
{
	public abstract class WordListContainer
	{
		public abstract List<string> GetWordList();

		private List<string> wordList = new List<string>();

		public List<string> WordList {
			get {
				//If the word list is yet to be initalsied, get the word list
				if (wordList == null || wordList.Count == 0)
					wordList = GetWordList();

				return wordList;
			}
			set { wordList = value; }
		}

		/// <summary>
		/// Returns the number of words in the setup word list. Returns null if the word list has not been initialised
		/// </summary>
		public int Words
		   => WordList.Count;
	}
}