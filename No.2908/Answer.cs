using System;
using System.Text;
using System.Collections.Concurrent;
class AnswerClass{
    static void Main(string[] args)
    {
       new AnswerClass().Answer();
    }

    public void Answer(){
        String s = Console.ReadLine();
        char[] reverse = s.ToCharArray();
        Array.Reverse(reverse);
        int[] answer = Array.ConvertAll(new String(reverse).Split(" "), int.Parse);
        Console.Write(answer[0] > answer[1] ? answer[0] : answer[1]);
    }
}
