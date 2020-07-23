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
        float avg = 0;
        float answer = 0;
        int[] values;
        for(int i = 0; i < n; i++){
            values = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            avg = 0;
            answer = 0;
            for(int j = 1; j <= values[0]; j++){
                avg += values[j];
            }
            avg = avg / values[0];
            for(int j = 1; j <= values[0]; j++){
                if(values[j] > avg){
                    answer += 100;
                }
            }
            sb.AppendLine(String.Format("{0:0.000}%", answer / values[0]));
        }
        Console.Write(sb.ToString());
    }
}
