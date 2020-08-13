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
        
       for(int i = 0; i < n; i++){
            long[] st = Array.ConvertAll(Console.ReadLine().Split(" "), long.Parse);
            /*long point = st[0];
            long ep = st[1] - 1;
            long k = 1;
            while(point < ep){
                point += k;
                k++;
            }*/
            
            sb.AppendLine((Math.Sqrt(st[1] - (st[0] - 1)) * 2).ToString());
        }
        Console.Write(sb.ToString());
    }

    public long approx_sqrt(long a)
    {
        long x = 2;
        long x_new;
        for(int i = 0; i < 20; i++) {
            x_new = ( x + ( a / x ) ) / 2;
            if (x_new == x) break;
            x = x_new;
        }

        return x;
    }
}
