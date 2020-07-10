using System;
using System.Collections.Generic;

class Answer{
    public static List<List<int>> employeeBosslist = new List<List<int>>();
    public static int[] employeeValues;
    public static ulong[] answerValues;
    public static int[] par;
    static void Main(string[] args)
    {
        if(int.TryParse(Console.ReadLine(), out int n)){
            employeeValues = new int[n + 1];
            answerValues = new ulong[n + 1];
            par = new int[n + 1];
            employeeBosslist.Add(new List<int>());
            employeeBosslist.Add(new List<int>());

            int[] inData = Array.ConvertAll(("0 0 " + Console.ReadLine()).Split(" "), s => int.Parse(s));

            for (int i = 2; i <= n; i+=2) {
                employeeBosslist.Add(new List<int>());
                employeeBosslist[i].Add(inData[i]);
                employeeBosslist[inData[i]].Add(i);
                par[i] = inData[i];
                if(i != n){
                    employeeBosslist.Add(new List<int>());
                    employeeBosslist[i+1].Add(inData[i+1]);
                    employeeBosslist[inData[i+1]].Add(i+1);
                    par[i+1] = inData[i+1];
                }
            }
    
            ChildValue(1);
            AnswerValue(1);

            for(int i = 1; i < answerValues.Length; i++){
                Console.Write( answerValues[i] + " ");
            }
        }
    }

    static int ChildValue(int n){
        int val = 0;
        int next = 0;
        for(int i = 0; i < employeeBosslist[n].Count; i++){
            next = employeeBosslist[n][i];
            if(next != par[n]){
                val += ChildValue(next);
            }
        }
        employeeValues[n] = val;
        return val + 1;
    }
    
    static void AnswerValue(int n){
        answerValues[n] = 1;
        int next = 0;
        for(int i = 0; i< employeeBosslist[n].Count; i++){
            next = employeeBosslist[n][i];
            if(next != par[n]){
                AnswerValue(next);
                answerValues[n] += answerValues[next];
            }
        }
        answerValues[n] += (ulong)employeeValues[n];
    }
}