using System;
using System.Text;
class AnswerClass{
    public static StringBuilder sb = new StringBuilder();
    static void Main(string[] args)
    {
       new AnswerClass().Answer();
    }

    public void Answer(){
        int[] n = new int[2];
        while(true){
            n = Array.ConvertAll(Console.ReadLine().Split(" "), s => int.Parse(s));
            if(n[0] == 0 && n[1] == 0){
                break;
            }
            sb.Append(String.Format("{0}\n",n[0]+n[1]));
        } 
        Console.Write(sb.ToString());
    }
}
