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
        int[] nm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int[,] processionA = new int[nm[0], nm[1]];
        string[] strArr = new string[nm[1]];

        for (int i = 0; i < nm[0]; i++)
        {
            strArr = Console.ReadLine().Split();
            for (int j = 0; j < nm[1]; j++)
            {
                processionA[i, j] = int.Parse(strArr[j]);
            }
        }
        
        for (int i = 0; i < nm[0]; i++)
        {
            strArr = Console.ReadLine().Split();
            for (int j = 0; j < strArr.Length; j++)
            {
                processionA[i, j] += int.Parse(strArr[j]);
                sb.Append($"{processionA[i, j]} ");
            }

            sb.AppendLine();
        }
        
        Console.Write(sb.ToString());
    }

    public void Answer()
    {
        int[] nm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int[,] processionA = new int[nm[0], nm[1]];
        int[] plusArr = new int[nm[1]];

        for (int i = 0; i < nm[0]; i++)
        {
            plusArr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            for (int j = 0; j < nm[1]; j++)
            {
                processionA[i, j] = plusArr[j];
            }
        }
        
        for (int i = 0; i < nm[0]; i++)
        {
            plusArr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            for (int j = 0; j < plusArr.Length; j++)
            {
                processionA[i, j] += plusArr[j];
                sb.Append($"{processionA[i, j]} ");
            }

            sb.AppendLine();
        }
        
        Console.Write(sb.ToString());
    }
}