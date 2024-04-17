using System;
using System.Text;

class AnswerClass{
    public static StringBuilder sb = new StringBuilder();
    static void Main(string[] args)
    {
        new AnswerClass().Answer();
    }

    public void Answer()
    {
        int N = int.Parse(Console.ReadLine()) / 4;
        for (int i = 0; i < N; i++)
        {
            sb.Append("long ");
        }
        Console.Write(sb.Append("int").ToString());
    }
}