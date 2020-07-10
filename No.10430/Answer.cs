using System;
class Answer{
    static void Main(string[] args)
    {
        int[] val = Array.ConvertAll(Console.ReadLine().Split(" "),s => int.Parse(s));
        Console.WriteLine((val[0]+val[1])%val[2]);
        Console.WriteLine(((val[0]%val[2])+(val[1])%val[2])%val[2]);
        Console.WriteLine((val[0]*val[1])%val[2]);
        Console.Write(((val[0]%val[2])*(val[1])%val[2])%val[2]);

    }
}
