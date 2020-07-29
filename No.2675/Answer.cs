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
        String[] data;
        String answer = "";
        for(int i = 0; i < n; i++){
            data = Console.ReadLine().Split(" ");
            for(int j = 0; j < data[1].Length; j++){
                for(int k = 0 ; k < int.Parse(data[0]); k++){
                    answer += data[1][j];
                }
            }
            sb.AppendLine(answer);
            answer = "";
        }
        Console.Write(sb.ToString());
    }
}
