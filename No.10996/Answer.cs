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
        for(int i = 1; i <= n*2; i++){
            if(i % 2 != 0){
                for(int j = 0; j < n; j++){
                    sb.Append(j % 2 != 0 ? " " : "*");
                }
                sb.Append("\n");
            }else{
                for(int j = 0; j < n; j++){
                    sb.Append(j % 2 == 0 ? " " : "*");
                }
                sb.Append("\n");
            }
        }
        Console.Write(sb.ToString());
    }
}
