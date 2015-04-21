using System;

class FullNameProj
{
    static void Main()
    {
        Console.Title = "Az sam Ani";

        string firstName = "Ани";
        string lastName = "Йончева";
        Console.WriteLine("Здравей, аз се казвам {0}.", firstName);
        Console.WriteLine("А ти как се казваш?");

        string firstName1 = "Деси";
        string lastName1 = "Симеонова";
        Console.WriteLine("Здравей, аз се казвам {0}.", firstName1);
        Console.WriteLine("А как е цялото ти име?");

        string fullName = firstName + " " + lastName;
        Console.WriteLine("Моето име е {0}, а твоето как е?", fullName);

        string fullName1 = firstName1 + " " + lastName1;
        Console.WriteLine("Моето име е {0}.", fullName1);

        Console.WriteLine("На колко години си?");

        int age = 37;
        int age1 = 36;

        Console.WriteLine("Аз съм на {0}. А ти?", age);
        Console.WriteLine("Аз съм на {0}.", age1);

    }
}