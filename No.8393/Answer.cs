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
        int a = 0, b = 0;
        for(int i = 1; i <= n; i++){
            a = Console.Read();
            b = Console.Read();
            sb.AppendLine((a+b).ToString());
        }
        Console.Write(sb.ToString());
    }
}
