using System;
using System.Text;
class AnswerClass{
    static void Main(string[] args)
    {
       new AnswerClass().Answer();
    }

    public void Answer(){
        int n = int.Parse(Console.ReadLine());
        StringBuilder sb = new StringBuilder();
        int[] ab = new int[2];
        for(int i = 0; i < n; i++){
            ab = Array.ConvertAll(Console.ReadLine().Split(" "), s => int.Parse(s));
            sb.AppendLine((ab[0]+ab[1]).ToString());
        }
        Console.Write(sb.ToString());
    }
}
