using System;
using System.Text;

class AnswerClass{
    static void Main(string[] args)
    {
        new AnswerClass().Answer();
    }

    public void Answer(){
        int total = int.Parse(Console.ReadLine());
        int itemCount = int.Parse(Console.ReadLine());
        int itemtotalValue = 0;
        for (int i = 0; i < itemCount; i++)
        {
            int[] value = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            itemtotalValue += value[0] * value[1];
        }

        Console.Write(total == itemtotalValue ? "Yes" : "No");
    }
}