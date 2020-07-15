using System;
using System.Text;
class AnswerClass{
    static void Main(string[] args)
    {
       new AnswerClass().Answer();
    }

    public void Answer(){
        int min = 2001;
        int minsetValue = 0;
        int n = 0;
        for(int i = 0; i < 5; i++){
            n = int.Parse(Console.ReadLine());
            if(n < min){
                min = n;
            }
            if(i == 2){
                minsetValue = min - 50;
                min = 2001;
            }
        }
        minsetValue += min;
        Console.Write(minsetValue);
    }
}
