using System;
using System.Text;
class AnswerClass{
    public static StringBuilder sb = new StringBuilder();
    static void Main(string[] args)
    {
       new AnswerClass().Answer();
    }

    public void Answer(){
        String str = Console.ReadLine();
        int[] n = new int[26];
        int idx = 0;

        for(int i = 0; i < str.Length; i++){
            idx = str[i] - 'a';
            if(n[idx] == 0){
                n[idx] = i + 1;
            }
        }

        for(int i = 0;  i < n.Length; i++){
            sb.Append(--n[i] + " ");
        }
        Console.Write(sb.ToString());
    }
}
