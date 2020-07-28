using System;
using System.Text;
class AnswerClass{
    static void Main(string[] args)
    {
       new AnswerClass().Answer();
    }

    public void Answer(){
        int n = int.Parse(Console.ReadLine());
        String s = Console.ReadLine();
        int sum = 0;
        for(int i = 0 ; i < n; i++){
            sum += s[i] - '0';
        }
        Console.Write(sum);
    }
}
