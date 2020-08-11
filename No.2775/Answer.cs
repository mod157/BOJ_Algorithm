using System;
using System.Text;
using System.Collections.Concurrent;
class AnswerClass{
    public static StringBuilder sb = new StringBuilder();
    static void Main(string[] args)
    {
       new AnswerClass().Answer();
    }

    public void Answer(){
        int[,] hw = new int[15,15];
        for(int i = 0; i <= 14; i++){
            hw[0, i] = i + 1;
        }

        for(int i = 1; i <= 14; i++){
            for(int j = 0;  j <= 14; j++){
                if(j == 0){
                    hw[i, j] = 1;
                    continue;
                }
                if(j == 1){
                    hw[i, j] = i + 2;
                    continue;
                }
                hw[i, j] = hw[i, j - 1] + hw[i - 1, j]; 
            }
        }

        int n = int.Parse(Console.ReadLine());
        int a = 0;
        int b = 0;
        for(int i = 0; i < n; i++){
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            sb.AppendLine(hw[a,b - 1].ToString());
        }
        
        
        Console.Write(sb.ToString());
    }
}
