using System;
using System.Text;
class AnswerClass{
    public static StringBuilder sb = new StringBuilder();
    static void Main(string[] args)
    {
       new AnswerClass().Answer();
    }

    public void Answer(){
        int n = int.Parse(Console.ReadLine());
        for(int i = 1; i <= n; i++){
            sb.AppendLine(i.ToString());
        }
        Console.Write(sb.ToString());
    }
}
