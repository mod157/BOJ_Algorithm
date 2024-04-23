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
        int[] inputarr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int[] varr = { 1, 1, 2, 2, 2, 8 };
        for (int i = 0; i < varr.Length; i++)
        {
            sb.Append($"{varr[i] - inputarr[i]} ");
        }
        
        Console.Write(sb.ToString().TrimEnd());
    }
    
    public void Answer()
    {
        int[] inputarr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int[] varr = { 1, 1, 2, 2, 2, 8 };
        
        Console.Write($"{varr[0] - inputarr[0]} {varr[1] - inputarr[1]} {varr[2] - inputarr[2]} {varr[3] - inputarr[3]} {varr[4] - inputarr[4]} {varr[5] - inputarr[5]}");
    }

}