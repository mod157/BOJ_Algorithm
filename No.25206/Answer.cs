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
        int count = 20;
        int pCount = 0;
        float value = 0;
        float score = 0f;
        string[] readStrArr = new string[3];
        for (int i = 0; i < count; i++)
        {
            readStrArr = Console.ReadLine().Split();
            if (readStrArr[2] == "P")
                continue;
            
            float credit = float.Parse(readStrArr[1]);

            switch (readStrArr[2])
            {
                case "A+":
                    score = 4.5f;
                    break;
                case "A0":
                    score = 4.0f;
                    break;
                case "B+":
                    score = 3.5f;
                    break;
                case "B0":
                    score = 3.0f;
                    break;
                case "C+":
                    score = 2.5f;
                    break;
                case "C0":
                    score = 2.0f;
                    break;
                case "D+":
                    score = 1.5f;
                    break;
                case "D0":
                    score = 1.0f;
                    break;
                case "F":
                    score = 0.0f;
                    break;
            }

            pCount += (int)credit;
            value += score * credit;
        }
        Console.Write(value / pCount);
    }
}