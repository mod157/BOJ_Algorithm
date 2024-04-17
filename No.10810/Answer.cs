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
        int[] optionarr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int[] basketarr = new int[optionarr[0] + 1];
        int count = optionarr[1];
        
        for (int i = 1; i <= count; i++)
        {
            int[] ijkarr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            for (int j = ijkarr[0]; j <= ijkarr[1]; j++)
            {
                basketarr[j] = ijkarr[2];
            }
        }

        for (int i = 1; i < basketarr.Length; i++)
        {
            sb.Append(basketarr[i] + " ");
        }
        
        Console.Write(sb.ToString().Trim());
    }
}