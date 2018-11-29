using System;

namespace Sundays
{
    class Program
    {
        /// <summary>
        /// The Below code calculates the number of sundays occurred in every january occured in 20th century(between 01/01/1901 and 31/12/2000)
        /// The Code is written in C# language
        /// </summary>
        private static void Main()
        {
            DateTime startDate = Convert.ToDateTime("01/01/1901");
            DateTime endDate = Convert.ToDateTime("31/12/2000");
            Console.WriteLine("The total no. of Sundays in every January in 20th century - {0}", CountSundays(startDate, endDate));
            Console.Read();
        }

        private static int CountSundays(DateTime startDate, DateTime endDate)
        {
            int totalSundays = 0, sundayCount = 0;
            DateTime dt = startDate;

            while (dt <= endDate)
            {
                if (dt.DayOfWeek == DayOfWeek.Sunday && dt.ToString("MMM") == "Jan")
                {
                    sundayCount++;
                    dt = dt.AddDays(7);
                    continue;
                }
                else if (dt.ToString("MMM") != "Jan")
                {
                    totalSundays += sundayCount;
                    Console.WriteLine("Sundays in Jan,{0} - {1}", dt.Year, sundayCount);
                    sundayCount = 0;
                    dt = dt.AddYears(1);
                    dt = new DateTime(dt.Year, 1, 1, 0, 0, 0, dt.Kind);
                    continue;
                }
                dt = dt.AddDays(1);
            }

            return totalSundays;
        }
    }
}
