using System;

class BooleanVariable
{
    static void Main()
    {
        bool isFemale = true;
        Console.WriteLine("Are you Female? (Yes/No): ");
        String answer = Console.ReadLine();

        if (answer == "Yes")
        {
            isFemale = true;
            Console.WriteLine(isFemale);
        }
        else if (answer == "No")
        {
            isFemale = false;
            Console.WriteLine(isFemale);
        }
        else
        {
            Console.WriteLine("Invalid answer");
        }
    }
}
