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
        for (int i = -count + 1; i < count; i++)
        {
            sb.Append(' ', Math.Abs(i));
            sb.Append('*', 2 * count - 1 - 2 * Math.Abs(i)); 
            sb.AppendLine();
        }
        
        Console.WriteLine(sb.ToString());
    }
    
    public void Answer()
    {
        int count = int.Parse(Console.ReadLine());
        
        for (int i = 0; i <= count; i++)
        {
            for (int k = count - i; k > 0; k--)
            {
                sb.Append(" ");
            }

            for (int j = 1; j < i * 2; j++)
            {
                sb.Append("*");
            }

            sb.AppendLine();
        }
        
        for (int i = count - 1; i > 0; i--)
        {
            for (int k = i; k < count; k++)
            {
                sb.Append(" ");
            }

            for (int j = 1; j < i * 2; j++)
            {
                sb.Append("*");
            }

            sb.AppendLine();
        }

        Console.Write(sb.ToString());
    }

}