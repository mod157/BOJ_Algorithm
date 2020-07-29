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
        String s = Console.ReadLine().ToUpper();
        int[] alpha = new int[26];
        Boolean isSame = false;

        for(int i = 0; i < s.Length; i++){
            alpha[s[i] - 'A']++; 
        }

        int max = 0;
        for(int i = 1; i < alpha.Length; i++){
            if(alpha[i] == 0){
                continue;
            }

            if(alpha[i] > alpha[max]){
                max = i;
                isSame = false;
                continue;
            }

            if(alpha[max] == alpha[i]){
                isSame = true;
            }
        }
        Console.Write(isSame ? "?" : Convert.ToChar('A' + max).ToString());
    }
}
