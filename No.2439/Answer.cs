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
        for(int i = 1 ; i <= n; i++){
            for(int j = n; j > i; j--){
                sb.Append(" ");
            }

            for(int j = 1; j <= i; j++){
                sb.Append("*");
            }
            sb.Append("\n");
        }
        Console.Write(sb.ToString());
    }
}
