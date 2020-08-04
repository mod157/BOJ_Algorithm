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
        int cnt = 1;
        int div = 0;
        while(true){
            div += cnt;
            if(div >= n){
                break;
            }
            cnt++;
        }
        
        int value = n - (div - cnt + 1);
        int a = 1 + value, b = cnt - value;
        if(cnt % 2 == 0){
            Console.Write(a + "/" + b);
        }else{
            Console.Write(b + "/" + a);
        }
    }
}
