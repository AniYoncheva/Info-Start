using System;
//A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number. Write a program that reads the information about a company and its manager and prints it back on the console.

    class CompanyInfo
    {
        static void Main()
        {
            Console.Title = "Company info";
            Console.Write("Company name: ");
            string companyName = Console.ReadLine();
            Console.Write("Company address: ");
            string address = Console.ReadLine();
            Console.Write("Phone number: ");
            string phone = Console.ReadLine();
            Console.Write("Fax: ");
            string fax = Console.ReadLine();
            if (fax=="")
            {
                fax = "(no fax)";
            }
            Console.Write("Web site: ");
            string web = Console.ReadLine();
            Console.Write("Manager first name: ");
            string firstNameManager = Console.ReadLine();
            Console.Write("Manager last name: ");
            string lastNameManager = Console.ReadLine();
            Console.Write("Manager age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Manager phone: ");
            string phoneManager = Console.ReadLine();

            Console.WriteLine("{0}\nAddress: {1}\nTel. {2}\nFax: {3}\nWeb site {4}\nManger {5} {6} (age: {7}, tel. {8})", companyName, address, phone, fax, web, firstNameManager, lastNameManager, age, phoneManager);
        }
    }

