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
        int n = 9;
        string[] strArr = new string[n];
        int maxValue = -1;
        string maxij = string.Empty;
        int temp;

        for (int i = 0; i < n; i++)
        {
            strArr = Console.ReadLine().Split();
            for (int j = 0; j < n; j++)
            {
                temp = int.Parse(strArr[j]);
                if (temp > maxValue)
                {
                    maxValue = temp;
                    maxij = $"{i + 1} {j + 1}";
                }
            }
        }

        sb.AppendLine(maxValue.ToString());
        sb.Append(maxij);
        Console.Write(sb.ToString());
    }
}