using System;
using System.Text;
using System.Collections.Concurrent;
class AnswerClass{
    static void Main(string[] args)
    {
       new AnswerClass().Answer();
    }

    public void Answer(){
        int[] n = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
        int value = n[2] - n[1];
        if(value > 0){
            int answer = n[0] / value;
            Console.Write(answer + 1);
        }else{
            Console.Write(-1);
        }
    }
}
