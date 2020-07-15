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
        int[] val = new int[2];
        for(int i = 0; i < n; i++){
            val = Array.ConvertAll(Console.ReadLine().Split(" "), s => int.Parse(s));
            sb.Append(String.Format("Case #{0}: {1}\n",i+1,val[0]+val[1]));
        }
        Console.Write(sb.ToString());
    }
}
