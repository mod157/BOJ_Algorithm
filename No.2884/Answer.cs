using System;
class Answer{
    static void Main(string[] args)
    {
        int[] value = Array.ConvertAll(Console.ReadLine().Split(" "),s => int.Parse(s));
        if(value[1] < 45){
            if(value[0] == 0){
                value[0] = 23;
            }else{
                value[0]--;
            }
            value[1] += 15;
        }else{
            value[1] -= 45;
        }
        Console.Write(value[0] + " " + value[1]);
    }
}
