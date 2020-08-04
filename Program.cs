using System;

namespace Dotnet_1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime start, end;
            DateTime[] holidays = {new DateTime(2020, 8, 24), new DateTime(2020, 8, 5)};

            start = new DateTime(2020, 6, 1);
            end = new DateTime(2020, 8, 30);

            CountWorkingDays(start, end, holidays);
        }
        public static void CountWorkingDays(DateTime start, DateTime end, DateTime[] holidays)
        {
            TimeSpan dif = end.Subtract(start);
            double count  = dif.TotalDays;

            for(int i = 0; i < holidays.Length; i++){
                if (holidays[i].CompareTo(start) >= 0 && holidays[i].CompareTo(end) <= 0){
                    count--;
                }
            }
            Console.Write(count);
        }
    }
}
