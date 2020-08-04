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
        if(n != 1){
            int answer = n / 6;
            int div = 0;
            int cnt = 1;
            while(true){
                div += cnt++;
                if(div >= answer){
                    if(n > div * 6 + 1 ){
                        cnt++;
                        break;
                    }else{
                        break;
                    }
                }
            }

            Console.Write(cnt);
        }else{
            Console.Write(n);
        }
    }
}
