using System;
using System.IO;
using System.Text;

class FileWriter
    {
        static void Main()
        {
            StreamWriter writer = new StreamWriter("Simple.txt");
            using (writer)
            {
                for (int i = 0; i <= 20; i++)
                {
                    writer.WriteLine(i);
                }
            }

        }
    }

