using System;
using System.Text;

class AnswerClass{
    static void Main(string[] args)
    {
        new AnswerClass().Answer();
    }

    public void Answer(){
        string s = Console.ReadLine();
        ulong totalValue = 0;
        string[] splitstr = s.Split(' ');
        foreach (var str in splitstr)
        {
            ulong value = ulong.Parse(str);
            totalValue += value;
        }
        Console.Write(totalValue.ToString());
    }
}