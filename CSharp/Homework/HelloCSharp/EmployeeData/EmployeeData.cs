using System;

//A marketing company wants to keep record of its employees. Each record would have the following characteristics:
//•	First name
//•	Last name
//•	Age (0...100)
//•	Gender (m or f)
//•	Personal ID number (e.g. 8306112507)
//•	Unique employee number (27560000…27569999)
//Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names. Prdouble the data at the console.

    class EmployeeData
    {
        static void Main()
        {
            string firstName = "Ani";
            string lastName = "Yoncheva";
            byte age = 37;
            char gender = 'f';
            string personalID = "8306112507";
            long employeeNumber = 27569999;

            Console.WriteLine("First Name: " + firstName);
            Console.WriteLine("Last Name: " + lastName);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Gender: " + gender);
            Console.WriteLine("Personal ID: " + personalID);
            Console.WriteLine("Employee Number: " + employeeNumber);



        }
    }

