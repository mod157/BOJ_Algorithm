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
        long value = 0;

        values.Add(1);
        for(int i = 0; i < n[3]; i++){
            for(int j = 0; j < 3; j++){
                value = values[i] * n[j];
                if(values.IndexOf(value) == -1){
                    values.Add(value);
                }
            }
            values.Sort();
        }
        Console.Write(values[n[3]]);
    }
}
