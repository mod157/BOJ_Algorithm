using System;
using System.Text;
using System.Collections.Generic;
class AnswerClass{
    public static StringBuilder sb = new StringBuilder();
    static void Main(string[] args)
    {
       new AnswerClass().Answer();
    }

    public void Answer(){
        int[] n = new int[10];
        int cnt = 10;
        for(int i = 0; i < 10; i++){
           n[i] = int.Parse(Console.ReadLine()) % 42;
        }

        for(int i = 0; i < 9; i++){
            for(int j = i+1 ; j < 10; j++){
                if(n[i] == n[j]){
                    cnt--;
                    break;
                }
            }
        }
        Console.Write(cnt);
    }
}
