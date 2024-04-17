using System;
using System.Text;

class AnswerClass{
    public static StringBuilder sb = new StringBuilder();
    static void Main(string[] args)
    {
        new AnswerClass().Answer();
    }

    public void Answer(){
        string s = Console.ReadLine();
        sb.Append(s);
        sb.Append("??!");
        Console.Write(sb.ToString());
    }
}