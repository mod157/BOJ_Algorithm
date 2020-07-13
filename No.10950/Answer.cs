using System;
class Answer{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] values = new int[2];
        for(int i = 0; i < n; i++){
            values = Array.ConvertAll(Console.ReadLine().Split(" "), s => int.Parse(s));
            Console.WriteLine(values[0] + values[1]);
        }
    }
}
