using System;
using System.Collections.Generic;
class Answer{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<int[]> values = new List<int[]>();
        for(int i = 0 ; i < n; i++){
            values.Add(Array.ConvertAll(("1 " + Console.ReadLine() + " 0").Split(" "), s => int.Parse(s)));
            values[i][values[i].Length - 1] = functionF(values[i]);
        }
        for(int i = 0; i < values.Count; i++){
            for(int j = 0; j < values[i].Length; j++)
                Console.Write(values[i][j]);
            Console.WriteLine();
        }
        int q = int.Parse(Console.ReadLine());
        int[] times = new int[q];
        for(int i = 0; i < q; i++){
            times[i] = int.Parse(Console.ReadLine());
        }

    }

    static int functionF(int[] val){
        if(val[2] == 0 || val[0] == 1){
            return val[1];
        }else{
            return val[1]-((val[0]-1)*2)*val[2];
        }
    }
}