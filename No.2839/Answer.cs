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
        int k5 = n / 5;
        int k3 = 0;
        int a = n % 5;
        if(a == 0){
            Console.Write(k5);
            return;
        }else{
            while(k5 >= 0){
                if(a % 3 == 0){
                    k3 = a / 3;
                    a %= 3;
                    break;
                }
                k5--;
                a += 5;
            }
        }
		if(a == 0){
		    Console.Write(k5 + k3);
		}else{
			Console.Write(-1);
		}
    }
}
