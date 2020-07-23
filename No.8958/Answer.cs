using System;
using System.Text;
class AnswerClass{
    public static StringBuilder sb = new StringBuilder();
    static void Main(string[] args)
    {
       new AnswerClass().Answer();
    }

    public void Answer(){
        int n = int.Parse(Console.ReadLine());
        String[] strs = new String[n];
        int value = 0;

        for(int i = 0; i < n; i++){
            strs[i] = Console.ReadLine();
            int answer = 0;
            value = 0;
            for(int j = 0; j < strs[i].Length; j++){
                if(strs[i][j].Equals('O')){
                    value += 1;
                    answer += value;
                    continue;
                }else{                
                    value = 0;
                    continue;
                }
            }
            sb.AppendLine(answer.ToString());
        }
        Console.Write(sb.ToString());
    }
}
