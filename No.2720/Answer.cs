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
        int count = int.Parse(Console.ReadLine());
        int sent;
        
        for (int i = 0; i < count; i++)
        {
            sent = int.Parse(Console.ReadLine());
            int quarter = sent / 25;
            sent %= 25;

            int dime = sent / 10;
            sent %= 10;

            int nickel = sent / 5;
            sent %= 5;

            int penny = sent;

            sb.AppendLine($"{quarter} {dime} {nickel} {penny}");
        }
        
        Console.Write(sb.ToString());
    }
}