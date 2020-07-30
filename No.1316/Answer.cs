using System;
using System.Text;
using System.Collections.Concurrent;
class AnswerClass{
    public static StringBuilder sb = new StringBuilder();
    static void Main(string[] args)
    {
       new AnswerClass().Answer();
    }

    public void Answer(){
        int n = int.Parse(Console.ReadLine());
        String s;
        for(int i = 0; i < n; i++){
            s = Console.ReadLine();
            for(int j = 0; j < s.Length; j++){
                
            }
        }
        Console.Write(sb.ToString());
    }
}
