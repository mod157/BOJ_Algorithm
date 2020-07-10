using System;
class Answer{
    static void Main(string[] args)
    {
        int value = int.Parse(Console.ReadLine());
        switch(value*0.1){
            case 10:
            case 9:
                Console.Write("A");
                break;
            case 8:
                Console.Write("B");
                break;
            case 7:
                Console.Write("C");
                break;
            case 6:
                Console.Write("D");
                break;
            default:
                Console.Write("F");
                break;
        }
    }
}
