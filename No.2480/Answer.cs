using System;
using System.Text;

class AnswerClass{
    static void Main(string[] args)
    {
        new AnswerClass().Answer();
    }

    public void Answer(){
        int[] value = Array.ConvertAll(Console.ReadLine().Split(),s => int.Parse(s));
        int v1 = value[0] * 100;
        int v2 = value[1] * 100;
        int v3 = value[2] * 100;
        
        if (v1 == v2 && v2 == v3)
        {
            Console.Write($"{10000 + v1 * 10}");
            return;
        }
        
        if (v1 == v2 || v1 == v3)
        {
            Console.Write($"{1000 + v1}");
            return;
        }
        
        if (v2 == v3)
        {
            Console.Write($"{1000 + v2}");
            return;
        }

        if (v1 > v2 && v1 > v3)
            Console.Write(v1);
        else if (v2 > v3)
            Console.Write(v2);
        else
            Console.Write(v3);
    }
}