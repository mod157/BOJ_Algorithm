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
        SortedSet<long> setList = new SortedSet<long>();

        long[] values = new long[3];
        for(int i = 0; i < values.Length; i++){
           values[i] = n[i];
        }

        long value = 0;
        int min = 0;
        
        for(int i = 0; i < n[3]; i++){
            for(int j = 1; j < values.Length; j++){
                if(values[min] == values[j]){
                    if(values[min] + n[min] > values[j] + n[j]){
                        min = j;
                        values[min] = values[min] + n[min];
                        continue;
                    }
                }
                if(values[min] > values[j]){
                    min = j;
                }
            }
            value = values[min];
            values[min] += n[min];
            min = 0;
        }

    }
}
