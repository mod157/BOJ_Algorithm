using System;
using System.Text;

class AnswerClass{
    static void Main(string[] args)
    {
        new AnswerClass().Answer();
    }

    public void Answer(){
        string [] str = Console.ReadLine().Split();
        int playTime = int.Parse(Console.ReadLine());
        int mm = int.Parse(str[1]) + playTime;
        int hour = (int.Parse(str[0]) + mm / 60) % 24;
        Console.Write($"{hour} {mm % 60}");
    }
}