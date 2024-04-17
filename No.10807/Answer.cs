using System;
using System.Text;

class AnswerClass{
    static void Main(string[] args)
    {
        new AnswerClass().Answer();
    }

    public void Answer(){
        int N = int.Parse(Console.ReadLine());
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int v = int.Parse(Console.ReadLine());
        int count = 0;
        for (int i = 0; i < N; i++)
        {
            if (arr[i] == v)
                count++;
        }
        
        Console.Write(count.ToString());
}