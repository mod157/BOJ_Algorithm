using System;
class AnswerClass{
    static void Main(string[] args)
    {
       new AnswerClass().Answer();
    }

    public void Answer(){
        int n = int.Parse(Console.ReadLine());
        int cnt = 0;
        int a = 0;
        int b = 0;
        int val = n;
        do{
            a = (int)(val * 0.1f);
            b = val % 10;
            val = b * 10 + (a+b)%10;
            cnt++;
        }while(n != val);
        Console.Write(cnt);
    }
}
