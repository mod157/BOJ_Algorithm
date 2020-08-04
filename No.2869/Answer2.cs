using System;
using System.Text;
using System.Collections.Concurrent;
class AnswerClass{
    public static StringBuilder sb = new StringBuilder();
    static void Main(string[] args)
    {
       new AnswerClass().Answer();
    }

    public void Answer(){
        int[] n = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
        int answer = (n[2] - n[1]) / (n[0] - n[1]);
        if (((n[2] - n[1]) % (n[0] - n[1])) == 0)
	    {
		    Console.Write(answer);
	    }
        else
        {
            Console.Write(answer + 1);
        }
    }
}
