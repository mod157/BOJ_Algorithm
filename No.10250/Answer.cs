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
        int n = int.Parse(Console.ReadLine());
        for(int i = 0; i < n ; i++){
            int[] hwn = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            int h = hwn[2] % hwn[0];
            int w = hwn[2] / hwn[0];
            if( h == 0){
                h = hwn[0];
            }else{
                w++;
            }
            
            if(w < 10){
                sb.AppendLine(String.Format("{0}0{1}", h, w));
            }else{
                sb.AppendLine(String.Format("{0}{1}", h, w));
            }
        }
        Console.Write(sb.ToString());
    }
}
