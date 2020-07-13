using System;
class AnswerClass{
    static void Main(string[] args)
    {
       new AnswerClass().Answer();
    }

    public void Answer(){
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        for(int i = 1; i <= n; i++){
            sum += i;
        }
        Console.Write(sum);
    }
}
