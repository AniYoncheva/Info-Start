using System;

class Months
{
    static void Main()
    {
        Console.Write("Enter fitst month: ");
        int firstMonth = int.Parse(Console.ReadLine());
        Console.Write("Enter second month: ");
        int secondMonth = int.Parse(Console.ReadLine());
        CalcMonth(firstMonth, secondMonth);
    }
    static void CalcMonth(int startMonth, int endMonth)
    {
        int period = endMonth - startMonth;
        if (period < 0)
        {
            period = period + 12;
        }
        Console.WriteLine("There are {0} month period from {1} to {2}", period, GetMonth(startMonth), GetMonth(endMonth));
    }
    static string GetMonth(int month)
    {
        string monthName;
        switch (month)
        {
            case 1: monthName = "January"; break;
            case 2: monthName = "February"; break;
            case 3: monthName = "March"; break;
            case 4: monthName = "April"; break;
            case 5: monthName = "May"; break;
            case 6: monthName = "June"; break;
            case 7: monthName = "July"; break;
            case 8: monthName = "August"; break;
            case 9: monthName = "September"; break;
            case 10: monthName = "Octomber"; break;
            case 11: monthName = "November"; break;
            case 12: monthName = "December"; break;
            default:
                Console.WriteLine("Invalid month!");
                return null;;
        }
        return monthName;
    }


}