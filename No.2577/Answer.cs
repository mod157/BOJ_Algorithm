using System;
using System.Text;
class AnswerClass{
    public static StringBuilder sb = new StringBuilder();
    static void Main(string[] args)
    {
       new AnswerClass().Answer();
    }

    public void Answer(){
        int[] answer = new int[10];
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());
        int n3 = int.Parse(Console.ReadLine());
        String num = (n1 * n2 * n3).ToString();
        for(int i = 0; i < num.Length; i++){
            answer[num[i] - '0']++;
        }    
        for(int i = 0; i < answer.Length; i++){
            Console.WriteLine(answer[i]);
        }
    }
}
