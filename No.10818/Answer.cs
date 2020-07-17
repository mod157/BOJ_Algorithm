using System;
using System.Text;
class AnswerClass{
    static void Main(string[] args)
    {
       new AnswerClass().Answer();
    }

    public void Answer(){
        int n = int.Parse(Console.ReadLine());
        int[] val = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
        int min = val[0], max = val[0];
        for(int i = 0 ; i < n; i++){
            if(val[i] > max){
                max = val[i];
            }
            if(val[i] < min){
                min = val[i];
            }
        }
        Console.Write(min + " " + max);
    }
}
