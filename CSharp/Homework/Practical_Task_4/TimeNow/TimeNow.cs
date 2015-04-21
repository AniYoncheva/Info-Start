using System;

    class TimeNow
    {
        static void Main()
        {
            Console.WriteLine("What time is it?");
            Console.Write("Enter yhe hours:");
            int hours = int.Parse(Console.ReadLine());
            Console.Write("Enter the minutes:");
            int minutes = int.Parse(Console.ReadLine());
            bool isValidTime = ValidateHours(hours) && ValidateMinutes(minutes);

            if (isValidTime)
            {
                Console.WriteLine("The time is {0}:{1}", hours,minutes);
            }
            else
            {
                Console.WriteLine("Time is not correct!");
            }

        }
        static bool ValidateHours(int hour)
        {
            bool result = (hour > 0) && (hour < 24);
            return result;
        }
        static bool ValidateMinutes(int minute)
        {
            bool result = (minute > 0) && (minute < 60);
            return result;
        }
    }

