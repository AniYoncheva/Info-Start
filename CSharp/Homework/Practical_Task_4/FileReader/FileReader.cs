using System;
using System.IO;
using System.Text;


class FileReader
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\..\Sample.txt", Encoding.GetEncoding("Windows-1251"));
        using (reader)
        {
            int lineNumber = 0;
            string line = reader.ReadLine();

            while (line != null)
            {
                lineNumber++;
                Console.WriteLine("Line {0}: {1}", lineNumber, line);
                line = reader.ReadLine();
            }
        }
    }
}

