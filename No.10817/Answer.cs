using System;
using System.Text;
class AnswerClass{
    public static StringBuilder sb = new StringBuilder();
    static void Main(string[] args)
    {
       new AnswerClass().Answer();
    }

    public void Answer(){
        int[] n = Array.ConvertAll(Console.ReadLine().Split(" "), s => int.Parse(s));
        Console.Write(n[0] >= n[1] ? n[1] >= n[2] ? n[1] : n[0] >=n[2] ? n[2] : n[0] : n[2] >= n[1] ? n[1] : n[0] >= n[2]? n[0] : n[2]);
    }
}
