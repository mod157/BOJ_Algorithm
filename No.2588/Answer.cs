using System;

class Answer{
    static void Main(string[] args)
    {
        if(int.TryParse(Console.ReadLine(), out int a)){
            int.TryParse(Console.ReadLine(), out int b);
            Console.WriteLine(a*(b%10)+ "\n" + a*(b%100/10) + "\n" + a*(b/100) + "\n" + a*b);
        }
    }
}