using System;
class Answer{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        Console.Write(a > 0 && b > 0? 1 : a < 0? b < 0? 3: 2: 4);
    }
}
