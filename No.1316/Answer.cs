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
        int n = int.Parse(Console.ReadLine());
        int answer = n;
        int lastAlpha = 0;
        char[] s;
        int ascii = 0;

        for(int i = 0; i < n; i++){
            s = Console.ReadLine().ToCharArray();
            Boolean[] isAlpha = new Boolean[26];
            foreach(char c in s){
                ascii = c - 'a';
                if(!isAlpha[ascii]){
                    isAlpha[ascii] = true;    
                }else if(lastAlpha != ascii){
                    answer--;
                    break;
                }

                lastAlpha = ascii;
            }
        }
        Console.Write(answer);
    }
}
