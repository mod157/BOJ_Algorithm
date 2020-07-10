using System;
class Answer{
    static void Main(string[] args)
    {
        int[] value = Array.ConvertAll(Console.ReadLine().Split(" "),s => int.Parse(s));
        Console.WriteLine(value[0]+value[1]);
        Console.WriteLine(value[0]-value[1]);
        Console.WriteLine(value[0]*value[1]);
        Console.WriteLine(value[0]/value[1]);
        Console.Write(value[0]%value[1]);
    }
}
