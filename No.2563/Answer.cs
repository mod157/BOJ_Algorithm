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
        int size = 100;
        int x, y, blockSize = 0;
        bool[,] boolArr = new bool[size + 1, size + 1];
        string[] xy = new string[2];
        
        for (int i = 0; i < count; i++)
        {
            xy = Console.ReadLine().Split();
            x = int.Parse(xy[1]);
            y = int.Parse(xy[0]);
            
            for (int j = x; j < x + 10; j++)
            {
                if (j > 100)
                    break;
                for (int k = y; k < y + 10; k++)
                {
                    if (k > 100)
                        break;
                    if (!boolArr[j, k])
                    {
                        boolArr[j, k] = true;
                        blockSize++;
                    }
                }
            }
        }
        
        Console.WriteLine(blockSize);
    }

    public void Answer()
    {
        int count = int.Parse(Console.ReadLine());
        int size = 100;
        int[] maxXY = new int[2]{0, 0};
        int[] minXY = new int[2]{101, 101};
        int x, y, blockSize = 0;
        bool[,] boolArr = new bool[size + 1, size + 1];
        string[] xy = new string[2];
        
        for (int i = 0; i < count; i++)
        {
            xy = Console.ReadLine().Split();
            x = int.Parse(xy[1]);
            y = int.Parse(xy[0]);
            
            if (x + 10 > 100)
                maxXY[0] = 100;
            else if((x + 10) > maxXY[0])
                maxXY[0] = x + 10;
            
            if (minXY[0] > x)
                minXY[0] = x;

            if (y + 10 > 100)
                maxXY[1] = 100;
            else if((y + 10) > maxXY[1])
                maxXY[1] = y + 10;
            
            if (minXY[1] > y)
                minXY[1] = y;
            
            for (int j = x; j < x + 10; j++)
            {
                if (j > 100)
                    break;
                
                for (int k = y; k < y + 10; k++)
                {
                    if (k > 100)
                        break;
                    
                    boolArr[j, k] = true;
                }
            }
        }
        
        for (int i = maxXY[1] - 1; i >= minXY[1]; i--)
        {
            for (int j = minXY[0]; j <= maxXY[0]; j++)
            {
                if (boolArr[j, i])
                    blockSize++;
            }
        }
        
        Console.WriteLine(blockSize);
    }
}