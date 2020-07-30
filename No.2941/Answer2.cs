using System;
using System.Text;
using System.Collections.Concurrent;
using System.Text.RegularExpressions;
class AnswerClass{
    static void Main(string[] args)
    {
       new AnswerClass().Answer();
    }

    public void Answer(){
        String n = Console.ReadLine();
        Regex rx = new Regex("((c|s|z|dz)=)|((c|d)-)|((l|n)j)");
        Console.Write(rx.Replace(n, " ").Length);
    }
}
