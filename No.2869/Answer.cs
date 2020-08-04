using System;
using System.Text;
using System.Collections.Concurrent;
class AnswerClass{
    static void Main(string[] args)
    {
       new AnswerClass().Answer();
    }

    public void Answer(){
        int[] n = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
        Console.Write((n[2] - n[1] - 1) / (n[0] - n[1]) + 1);
    }
}
