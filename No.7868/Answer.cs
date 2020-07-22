using System;
using System.Text;
using System.Collections.Generic;
class AnswerClass{
    public static StringBuilder sb = new StringBuilder();
    static void Main(string[] args)
    {
       new AnswerClass().Answer();
    }

    public void Answer(){
        int[] n = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
        List<long> values = new List<long>();
        int p1 = 0, p2 = 0, p3 = 0;
        values.Add(1);
        for(int i = 1; i <= n[3]; i++){
            while(values[i-1] >= values[p1]*n[0]) p1++;
            while(values[i-1] >= values[p2]*n[1]) p2++;
            while(values[i-1] >= values[p3]*n[2]) p3++;
            values.Add(Min(values[p1]*n[0],values[p2]*n[1]));
            values[i] = Min(values[i], values[p3]*n[2]);
            
        }
        Console.Write(values[n[3]]);
    }

    public long Min(long value1, long value2){
        return value1 > value2 ? value2 : value1;
    }
}
