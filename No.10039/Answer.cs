using System;
using System.Text;
class AnswerClass{
    public static StringBuilder sb = new StringBuilder();
    static void Main(string[] args)
    {
       new AnswerClass().Answer();
    }

    public void Answer(){
        int n = 0;
        int sum = 0;
        for(int i = 0; i < 5; i++){
            n = int.Parse(Console.ReadLine());
            sum += (n < 40) ? 40 : n;
        }
        Console.Write((int)(sum * 0.2));
    }
}
