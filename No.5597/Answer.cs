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
        List<int> snList = new List<int>(); 
        
        for (int i = 0; i < 31; i++)
            snList.Add(i);

        snList.Capacity = 31;
        
        for (int i = 0; i < 28; i++)
        {
            int number = int.Parse(Console.ReadLine());
            snList.Remove(number);
        }

        for (int i = 1; i < snList.Count; i++)
        {
            sb.Append(snList[i] + "\n");
        }
        
        Console.Write(sb.ToString().Trim());
    }
}