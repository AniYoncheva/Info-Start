using System;
using System.Text;


public class WordReverser
{
    public static void Main()
    {
        string text = "Ehoo ela tuk";
        string reverse = ReverseText(text);
        Console.WriteLine(reverse);
    }

    public static string ReverseText (string text)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = text.Length - 1; i >= 0; i--)
        {
            sb.Append(text[i]);
        }
            return sb.ToString();
    }
}

