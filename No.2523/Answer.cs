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
        for(int i = 1; i<= 2*n-1; i++){
            if( i <= n){
                for(int j = 0; j < i; j++){
                    sb.Append("*");
                }
            }else{
               for(int j = n*2 - i; j > 0; j--){
                    sb.Append("*");
                } 
            }
            sb.Append("\n");
        }
        Console.Write(sb.ToString());
    }
}
