using Bickers.Twaddle.Containers;
using Bickers.Twaddle.Containers.Lorem;
using Bickers.Twaddle.Contracts;
using System;

namespace Bickers.Twaddle.Names
{
    public class NameGenerator : INameGenerator
    {

        private static Random _wmRandomSeed = new Random();


        WordListContainer _firstNameWordListContainer = null;
        WordListContainer _lastNameContainer = null;

        public NameGenerator() : this(null, null)
        {

        }
        public NameGenerator(WordListContainer firstNameWordListContainer, WordListContainer lastNameWordContainer)
        {
            _firstNameWordListContainer = firstNameWordListContainer != null ? firstNameWordListContainer : new FirstNameWordContainer();
            _lastNameContainer = lastNameWordContainer != null ? lastNameWordContainer : new LastNameWordContainer();
        }


        public virtual string GenerateFirstName()
        {
            return _firstNameWordListContainer.WordList[_wmRandomSeed.Next(_firstNameWordListContainer.Words.Value)];
        }

        public virtual string GenerateFullName()
        {
            return GenerateFirstName() + " " + GenerateSecondName();
        }

        public virtual string GenerateSecondName()
        {
            return _lastNameContainer.WordList[_wmRandomSeed.Next(_lastNameContainer.Words.Value)];
        }

        public void Setup(WordListContainer firstNameWordListContainer, WordListContainer lastNameWordContainer)
        {
            if (firstNameWordListContainer == null)
            {
                throw new ArgumentNullException(nameof(firstNameWordListContainer));
            }

            if (lastNameWordContainer == null)
            {
                throw new ArgumentNullException(nameof(lastNameWordContainer));
            }

            _firstNameWordListContainer = firstNameWordListContainer != null ? firstNameWordListContainer : new FirstNameWordContainer();
            _lastNameContainer = lastNameWordContainer != null ? lastNameWordContainer : new LastNameWordContainer();
        }

    }
}