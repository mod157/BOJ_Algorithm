using System;
using System.Text;
class AnswerClass{
    public static StringBuilder sb = new StringBuilder();
    static void Main(string[] args)
    {
       new AnswerClass().Answer();
    }

    public void Answer(){
        int max = 0;
        int n = 0;
        int idx = 0;
        for(int i = 1 ; i <= 9; i++){
            n = int.Parse(Console.ReadLine());
            if(n > max){
                max = n;
                idx = i;
            } 
        }

        Console.Write(max + "\n" + i);
    }
}
