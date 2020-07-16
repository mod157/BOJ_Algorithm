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
        for(int i = 1; i <= n * 2 - 1; i++){
            
            if(i <= n){
                for(int k = 1; k < i; k++){
                    sb.Append(" ");
                }
                for(int j = n * 2; j >= (i * 2); j--){
                    sb.Append("*");
                }
            }else{
                for(int k = n * 2 - 1; k > i; k--){
                    sb.Append(" ");
                }
                for(int j = n * 2; j <= i * 2; j++){
                    sb.Append("*");
                }
            }
            
            sb.Append("\n");
        }
        Console.Write(sb.ToString());
    }
}
