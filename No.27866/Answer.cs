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
        string str = Console.ReadLine();
        int i = int.Parse(Console.ReadLine()) - 1;
        Console.WriteLine(str[i]);
    }
}