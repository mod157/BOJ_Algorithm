using System;
using System.Collections.Generic;
using System.Text;

class AnswerClass{
    public static StringBuilder sb = new StringBuilder();
    static void Main(string[] args)
    {
        new AnswerClass().Answer();
    }

    public void Answer()
    {
        int count = int.Parse(Console.ReadLine());
        string str = string.Empty;
        for (int i = 0; i < count; i++)
        {
            str = Console.ReadLine();
            sb.Append($"{str[0]}{str[str.Length - 1]}\n");
        }
        
        Console.WriteLine(sb.ToString());
    }