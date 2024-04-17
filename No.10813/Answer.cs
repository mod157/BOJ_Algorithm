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
        int[] optionarr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        List<int> basketList = new List<int>(optionarr[0] + 1); 
        int valueCount = optionarr[0] + 1;
        int count = optionarr[1];
        int temp;
        
        for (int i = 0; i < valueCount; i++)
        {
            basketList.Add(i);
        }

        basketList.Capacity = valueCount;
        
        for (int i = 1; i <= count; i++)
        {
            int[] ijarr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            if (basketList[ijarr[0]] == 0)
                basketList[ijarr[0]] = ijarr[0];
            if (basketList[ijarr[1]] == 0)
                basketList[ijarr[1]] = ijarr[1];

            if (ijarr[0] == ijarr[1])
                continue;

            temp = basketList[ijarr[0]];
            basketList[ijarr[0]] = basketList[ijarr[1]];
            basketList[ijarr[1]] = temp;
        }

        for (int i = 1; i < basketList.Count; i++)
        {
            if (basketList[i] == 0)
                basketList[i] = i;
            sb.Append(basketList[i] + " ");
        }
        
        Console.Write(sb.ToString().Trim());
    }
}