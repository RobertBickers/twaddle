namespace CodeTreehouse.Twaddle.Contracts
{
    public interface IPhoneGenerator
    {
        /// <summary>
        /// Generates a random phone number.
        /// </summary>
        /// <param name="prepend"></param>
        /// <returns></returns>
        string GeneratePhoneNumber(string prefix = "");
    }
}