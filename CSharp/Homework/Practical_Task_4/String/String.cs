using System;
using System.Text;


    class String
    {
        static void Main()
        {
            Console.WriteLine(DateTime.Now);
            StringBuilder colection = new StringBuilder();

            colection.Append("Nimbers: ");
            for (int i = 0; i < 200000; i++)
            {
                colection.Append(i);
            }
            Console.WriteLine(colection.ToString().Substring(0, 1024));
            Console.WriteLine(DateTime.Now);


            //string mail = "Kdkgjfkhdsjf somemail@gmail.com, kdfskjhsdfjkhd somemail@gmail.com";
            //string modifMail = mail.Replace("somemail@gmail.com", "animail@gmail.com");
            //Console.WriteLine(modifMail);



            //string listOfBeers = "Amstel, Zagorka, Tuborg, Becks";
            //char[] separators = new char[] { ' ', ',', '.' };
            //string[] beersArr = listOfBeers.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            //for (int i = 0; i < beersArr.Length; i++)
            //{
            //    Console.Write(beersArr[i]);
            //    Console.WriteLine();
            //}
            //Console.WriteLine(listOfBeers);

            //foreach (var beer in beersArr)
            //{
            //    Console.Write(beer + " "); 
            //}
            //Console.WriteLine();
            
            //string path = "C:\\Pics\\Rila2010.jpg";
            //int index = path.LastIndexOf("\\");
            //string fullName = path.Substring(index + 1);
            //Console.WriteLine();
            //Console.WriteLine(fullName);
            
            //string score = "SCore";
            //string scary = "scary";
            //Console.WriteLine(scary.ToUpper());
            //Console.WriteLine(score.ToLower());
            //Console.WriteLine(score.CompareTo(score));
            //Console.WriteLine(scary.CompareTo(score));
            //Console.WriteLine(score.CompareTo(scary));
            //string concat = string.Concat(score, scary);
            //Console.WriteLine(concat);

            //string mesages = "Zdarvei az sam Ani :)";
            //Console.WriteLine(mesages);
            //Console.WriteLine("Mesages length = {0}", mesages.Length);

            //for (int i = 0; i < mesages.Length; i++)
            //{
            //    Console.WriteLine("mesages[{0}] = {1}", i, mesages[i]);
            //}
            //Console.WriteLine();
        }
    }

