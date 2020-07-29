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
        String n = Console.ReadLine().Trim();
        if(n.Equals("")){
            Console.Write(0);
        }else{
            Console.Write(n.Split(" ").Length);
        }
    }
}
