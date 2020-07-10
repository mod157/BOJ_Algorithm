using System;

class Answer{
    static void Main(string[] args)
    {
        if(int.TryParse(Console.ReadLine(), out int n)){
            int[] par = Array.ConvertAll(("0 "+Console.ReadLine()).Split(" "), s => int.Parse(s));
            ulong[] answerValues = new ulong[n + 1];
            int[] employeeChildValue = new int[n + 1];

            for(int i = n; i <= 1; i--){
                answerValues[par[i]] += ++answerValues[i] + (ulong)++employeeChildValue[i];
                employeeChildValue[par[i]] += employeeChildValue[i];
            }

            for(int i = 0; i < answerValues.Length; i++){
                Console.Write(answerValues[i] + " ");
            }
        }
    }
}