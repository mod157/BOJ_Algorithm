using System;
using System.Text;
using System.Collections.Generic;
using System.Collections.Concurrent;
class AnswerClass{
    public static StringBuilder sb = new StringBuilder();
    static void Main(string[] args)
    {
       new AnswerClass().Answer();
    }

    public void Answer(){
        int n = int.Parse(Console.ReadLine());
        int[] number = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
        int count = 0;
        
        List<int> list = Eratos(1000);
        
        for(int i = 0; i < n; i++){
            if(list.IndexOf(number[i]) != -1){
                count++;
            } 
        }
        Console.Write(count);
    }

    public List<int> Eratos(int max){
        Boolean[] c = new Boolean[max + 1];
        List<int> list = new List<int>();
        for(int i=2; i<=max; i++){
            if(c[i] == false){
                // 추가
                list.Add(i);
                // i의 배수 지우기
                for(int j=i+i; j<=max; j+=i){
                    c[j]=true;
                }
            }
        }

        return list;
    }
}
