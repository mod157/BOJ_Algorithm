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
        String n = Console.ReadLine();
        int answer = 0;
        for(int i = 0; i < n.Length; i++){
            answer += (int)(n[i] - 'A') / 3 + 3;
            if(n[i].Equals('S') || n[i].Equals('V') || n[i].Equals('Y') || n[i].Equals('Z')){
                answer--;
            }
        }
        Console.Write(answer);
    }
}
