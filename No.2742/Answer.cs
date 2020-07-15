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
        for(int i = n; i > 0; i--){
            sb.AppendLine(i.ToString());
        }
        Console.Write(sb.ToString());
    }
}
