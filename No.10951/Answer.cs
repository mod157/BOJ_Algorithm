using System;
using System.Text;
class AnswerClass{
    static void Main(string[] args)
    {
       new AnswerClass().Answer();
    }

    public void Answer(){
        int[] n = new int[2];
        String str = "";
         while((str = Console.ReadLine())!= null){
            n = Array.ConvertAll(str.Split(" "), s => int.Parse(s));
            Console.WriteLine(n[0]+n[1]);
        } 
    }
}
