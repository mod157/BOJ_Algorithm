using System;
using System.Text;

class AnswerClass{
    static void Main(string[] args)
    {
        new AnswerClass().Answer();
    }

    public void Answer(){
        int n = int.Parse(Console.ReadLine());
        Console.Write(n - 543);
    }
}