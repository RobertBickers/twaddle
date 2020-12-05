namespace Bickers.Twaddle.Generators
{
    public interface IPhoneGenerator
    {
        /// <summary>
        /// Generates a random phone number.
        /// </summary>
        /// <param name="prefix"></param>
        /// <returns></returns>
        string GeneratePhoneNumber(string prefix = "");
    }
}