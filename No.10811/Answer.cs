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
        int[] nm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        // index 0을 제외하고 성능을 챙긴다.
        int n = nm[0] + 1;
        int m = nm[1];
        
        List<int> snList = new List<int>(); 
        
        for (int i = 0; i < n; i++)
            snList.Add(i);

        //insert가 발생하기 때문에 1공간 더 준다.
        snList.Capacity = n + 1;
        
        for (int k = 0; k < m; k++)
        {
            int[] ij = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            for (int i = ij[0]; i < ij[1]; i++)
            {
                snList.Insert(i, snList[ij[1]]);
                snList.RemoveAt(ij[1]+1);
            }
        }

        for (int i = 1; i < snList.Count; i++)
        {
            sb.Append(snList[i] + " ");
        }
        
        Console.Write(sb.ToString().Trim());
    }

    public void Answer()
    {
        int[] nm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int n = nm[0] + 1;
        int m = nm[1];
        int[] snarr = new int[n];
        int j, temp;

        for (int i = 1; i < n; i++)
        {
            snarr[i] = i;
        }
        
        for (int k = 0; k < m; k++)
        {
            int[] ij = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            j = ij[1];
            for (int i = ij[0]; i < j; i++, j--)
            {
                temp = snarr[i];
                snarr[i] = snarr[j];
                snarr[j] = temp;
            }
        }

        for (int i = 1; i < snarr.Length; i++)
        {
            sb.Append(snarr[i] + " ");
        }
        
        Console.Write(sb.ToString().Trim());
    }
}