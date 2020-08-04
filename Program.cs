using System;

namespace Dotnet_1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime start = new DateTime(2020, 8, 3), end = new DateTime(2020, 8, 15);
            DateTime[] holidays = {new DateTime(2020, 8, 24), new DateTime(2020, 8, 5)};

            CountWorkingDays(start, end, holidays);
        }
        public static void CountWorkingDays(DateTime start, DateTime end, DateTime[] holidays)
        {
            DateTime currentDay = start;
            uint count = 0;

            while(currentDay.CompareTo(end) <= 0){
                if (currentDay.DayOfWeek != DayOfWeek.Saturday && currentDay.DayOfWeek != DayOfWeek.Sunday){
                    count++;
                    for(int i = 0; i < holidays.Length; i++){
                        if (holidays[i].CompareTo(currentDay) == 0){
                            count--;
                        }
                    }
                }
                currentDay = currentDay.AddDays(1);
            }
            
            Console.Write(count);
        }
    }
}
