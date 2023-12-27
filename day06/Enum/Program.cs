using System;

public class Program
{
    // Declare an enum named Workday
    public enum Workday
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday
    }

    public static void Main(string[] args)
    {
        // Initialize an enum variable named today
        Workday today = Workday.Monday;

        // Call a method that accepts an enum as a parameter
        Console.WriteLine(GetDayInfo(today));

        // Use enum members to determine the output
        switch (today)
        {
            case Workday.Monday:
                Console.WriteLine("Today is the first day of the work week.");
                break;
            case Workday.Friday:
                Console.WriteLine("Today is the last day of the work week.");
                break;
            default:
                Console.WriteLine("Today is a middle day of the work week.");
                break;
        }
    }

    // A method that accepts an enum as a parameter
    public static string GetDayInfo(Workday day)
    {
        return $"{day} is the {(int)day + 1}th day of the work week.";
    }
}