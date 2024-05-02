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
        int number = int.Parse(strArr[0]);
        int ndec = int.Parse(strArr[1]);
        int remain;
        string returnValue = string.Empty;
        while (number > 0)
        {
            remain = number % ndec;
            if (remain > 9)
                sb.Append((char)(remain + '7'));
            else
                sb.Append((char)(remain + '0'));
           
            number /= ndec;
        }

        returnValue = sb.ToString();
        for (int i = returnValue.Length - 1; i >= 0; i--)
        {
            Console.Write(returnValue[i]);
        }
    }
}