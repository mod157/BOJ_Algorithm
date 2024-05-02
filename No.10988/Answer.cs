using System;
using System.Collections.Generic;
using System.Text;

class AnswerClass{
    public static StringBuilder sb = new StringBuilder();
    static void Main(string[] args)
    {
        new AnswerClass().Answer();
    }

    public void Answer()
    {
        string readStr = Console.ReadLine();
        int lastIndex = readStr.Length - 1;
        int count = (int)(readStr.Length / 2f + 0.5f);
        for (int i = 0; i < count; i++)
        {
            if (readStr[i] != readStr[lastIndex - i])
            {
                Console.Write("0");
                return;
            }
        }
        
        Console.Write("1");
    }
}