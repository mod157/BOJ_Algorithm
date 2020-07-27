using System;
using System.Collections.Generic;
using System.Text;
class AnswerClass{
    public static StringBuilder sb = new StringBuilder();
    static void Main(string[] args)
    {
       new AnswerClass().Answer();
    }

    public void Answer(){
        SelfNumber(10000);
        Console.Write(sb.ToString());
    }

    public void SelfNumber(int n){
        HashSet<int> hs = new HashSet<int>();
        String temp;
        int let = 0;
        for(int i = 0 ; i < n; i++){
            let = 0;
            temp = i.ToString();
            
            switch(temp.Length){
                case 1:
                    let = temp[0] - '0';
                break;
                case 2:
                    let = temp[0] - '0' + temp[1] - '0';
                break;
                case 3:
                    let = temp[0] - '0' + temp[1] - '0' + temp[2] - '0';
                break;
                case 4:
                    let = temp[0] - '0' + temp[1] - '0' + temp[2] - '0' + temp[3] - '0';
                break;
            }
            hs.Add(i + let);
        }

        for(int i = 1 ; i <= n; i++){
            if(!hs.Contains(i)){
                sb.AppendLine(i.ToString());
            }
        }
    }
}
