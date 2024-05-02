using System;
using System.Text;

class AnswerClass{
    public static StringBuilder sb = new StringBuilder();
    static void Main(string[] args)
    {
        new AnswerClass().Answer();
    }

    public void Answer()
    {
        int count = int.Parse(Console.ReadLine());
        long pointCount = 4;
        
        for (int i = 0; i < count; i++)
        {
            long addCount = 0;
            int squareCount = (int)Math.Pow(2, i);
            for (int j = 0; j < squareCount; j++)
            {
                if (j == 0)
                    addCount += squareCount * 4 + 1;
                else
                    addCount += squareCount * 3 + 1;
            }
            pointCount += addCount;
        }
        
        Console.Write(pointCount);
    }
}