using System;

namespace Bickers.Twaddle.Generators
{
    public interface IDateGenerator
    {
        /// <summary>
        /// Generates a random date between the start and end date
        /// </summary>
        /// <param name="startDate">The earliest possible date available in return. If null, DateTime.Min will be used </param>
        /// <param name="endDate">The lastest possible date available in return. If null, DateTime.Max will be used </param>
        /// <returns></returns>
        DateTime GenerateDate(DateTime? startDate = null, DateTime? endDate = null);
    }
}