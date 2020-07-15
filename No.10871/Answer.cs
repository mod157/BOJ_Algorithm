using System;
using System.Text;
class AnswerClass{
    public static StringBuilder sb = new StringBuilder();
    static void Main(string[] args)
    {
       new AnswerClass().Answer();
    }

    public void Answer(){
        int[] n = Array.ConvertAll(Console.ReadLine().Split(" "), s => int.Parse(s));
        int[] A = Array.ConvertAll(Console.ReadLine().Split(" "), s => int.Parse(s));
        for(int i = 0; i < n[0]; i++){
            if(A[i] < n[1]){
                sb.Append(A[i] + " ");
            }
        }
        Console.Write(sb.ToString().Trim());
    }
}
