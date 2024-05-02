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
        string[] strArr = Console.ReadLine().Split();
        int ndec = int.Parse(strArr[1]);
        int lastIndex = strArr[0].Length - 1;
        long squareValue = 1;
        int number;
        
        long totalValue = 0;
        
        for (int i = 0; i <= lastIndex; i++)
        {
            char c = strArr[0][lastIndex - i];
            if (c >= 'A')
                number = c - '7';
            else
                number = c - '0';
            
            if(i != 0)
                squareValue *= ndec;
            
            totalValue += (number * squareValue);
        }
        
        Console.Write(totalValue);
    }