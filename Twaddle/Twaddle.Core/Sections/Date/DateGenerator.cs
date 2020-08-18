using Bickers.Twaddle.Contracts;
using System;

namespace Bickers.Twaddle.Date
{
    internal class DateGenerator : IDateGenerator
    {
        private static Random _wmRandomSeed = new Random();

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

                return ((DateTime)startDate).AddDays(_wmRandomSeed.Next((int)maximumNumberOfDays - 1)).AddHours(_wmRandomSeed.Next(23)).AddMinutes(_wmRandomSeed.Next(59));
            }
            else if (startDate != null)
            {
                return ((DateTime)startDate).AddDays(_wmRandomSeed.Next(100)).AddHours(_wmRandomSeed.Next(23)).AddMinutes(_wmRandomSeed.Next(59));
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