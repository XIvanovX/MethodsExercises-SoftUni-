﻿namespace _07.Repeat_String;
class Program
{
    static void Main(string[] args)
    {
        string text= Console.ReadLine();
        int n = int.Parse(Console.ReadLine());

        string result = RepeatString(text, n);
        Console.WriteLine(result);
        
    }

    private static string RepeatString(string text, int n)
    {
        string result = string.Empty;

        for(int i=0;i<n;i++)
        {
            result += text;
        }

        return result;
    }
}

