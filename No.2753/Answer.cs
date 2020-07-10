using System;
class Answer{
    static void Main(string[] args)
    {
        int value = int.Parse(Console.ReadLine());
        if(value%4 == 0 && value%100 != 0){
            Console.Write(1);
        }else if(value%400 == 0){
            Console.Write(1);
        }else {
            Console.Write(0);
        }
    }
}
