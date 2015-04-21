using System;

//Rewrite “Hello World” example in such way that to print your first and last name. 

class HelloWorld
{
    static void Main()
    {
        Console.Title = ("Здравей!");
        Console.WriteLine("Hello! My full name is Anna Yoncheva");

        string firstName = "Анна";
        string lastName = "Йончева";
        string fullName = firstName + " " + lastName;
        Console.WriteLine("Hello! My first name is {0}.", firstName);
        Console.WriteLine("My last name is {0}.", lastName);
        Console.WriteLine("My full name is {0}.", fullName);

    }
}

