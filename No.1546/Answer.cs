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
        int[] val = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
        double value = 0f;
        int max = val[0];
        for(int i = 0; i < n; i++){
            value += val[i];
            if(val[i] > max){
                max = val[i];
            }
        }

        Console.Write(value /(max * n) * 100);
    }
}
