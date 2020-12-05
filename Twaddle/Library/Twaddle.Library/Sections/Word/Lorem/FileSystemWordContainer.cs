using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Bickers.Twaddle.Containers.Lorem
{
    /// <summary>
    /// Gets the list of words by reading each line of a text file
    /// </summary>
    public class FileSystemWordContainer : WordListContainer
    {

        string _targetFileLocation = null;

        /// <summary>
        /// The location of the text file that will be read. Each word must start on its own line for the word to show up seperately 
        /// </summary>
        /// <param name="targetFileLocation"></param>
        public FileSystemWordContainer(string targetFileLocation)
        {
            if (string.IsNullOrWhiteSpace(targetFileLocation))
            {
                throw new System.ArgumentException("The provided target file location is null or empty. Target file location must be provided", nameof(targetFileLocation));
            }

            _targetFileLocation = targetFileLocation;
        }


        /// <summary>
        /// Gets the word list that has been found from the target file location
        /// </summary>
        /// <returns></returns>
        /// <exception cref="FileNotFoundException"></exception>
        public override List<string> GetWordList()
        {

            if (!File.Exists(_targetFileLocation))
            {
                throw new FileNotFoundException();
            }

            var actualPath = Path.Combine(_targetFileLocation);
            var lines = File.ReadAllLines(actualPath);

            return lines.ToList();
        }
    }



}