using System;

namespace Bickers.Twaddle.Generators
{
    internal class DateGenerator : IDateGenerator
    {
        private static Random randomSeed = new Random();

        /// <summary>
        /// Generates a random date, optionally, between the start and end date provided
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        public DateTime GenerateDate(DateTime? startDate, DateTime? endDate)
        {
            if (startDate != null && endDate != null)
            {
                TimeSpan timeSpan = (TimeSpan)(endDate - startDate);
                double maximumNumberOfDays = timeSpan.TotalDays;

                return ((DateTime)startDate).AddDays(randomSeed.Next((int)maximumNumberOfDays - 1)).AddHours(randomSeed.Next(23)).AddMinutes(randomSeed.Next(59));
            }
            else if (startDate != null)
            {
                return ((DateTime)startDate).AddDays(randomSeed.Next(100)).AddHours(randomSeed.Next(23)).AddMinutes(randomSeed.Next(59));
            }
            else if (endDate != null)
            {
                return ((DateTime)endDate).AddDays(-100);
            }
            else
            {
                return GenerateDate(DateTime.MinValue, DateTime.MaxValue);
            }
        }
    }
}