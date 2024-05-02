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
        int n = 5;
        string[] strArr = new string[n];
        int maxLength = 0;
        for (int i = 0; i < n; i++)
        {
            strArr[i] = Console.ReadLine();
            if (strArr[i].Length > maxLength)
                maxLength = strArr[i].Length;
        }

        for (int i = 0; i < maxLength; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if(i >= strArr[j].Length)
                    continue;
                sb.Append(strArr[j][i]);
            }
        }
        Console.Write(sb.ToString());
    }
}