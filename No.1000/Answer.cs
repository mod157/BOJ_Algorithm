using System;
class Answer{
    static void Main(string[] args)
    {
        string value = Console.ReadLine();
        string[] result = value.Split(' ');
        int a = 0, b = 0;
        a = int.Parse(result[0]);
        b = int.Parse(result[1]);
        Console.Write(a+b);
    }
}
