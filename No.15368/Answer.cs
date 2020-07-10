using System;

class Answer{
    static void Main(string[] args)
    {
        if(int.TryParse(Console.ReadLine(), out int n)){
            int[] employeeBosslist = Array.ConvertAll(("0 "+Console.ReadLine()).Split(" "), s => int.Parse(s));
            int[] employeeValue = new int[n];
            int val = 2;
            int idx = 1;

            for(int i = 0; i < employeeBosslist.Length; i++){
                employeeValue[i]++;
                idx = i;
                while(idx != 0){
                    idx = employeeBosslist[idx] - 1;
                    employeeValue[idx] += val++;
                    if(idx != 0){
                        idx = employeeBosslist[idx] - 1;
                        employeeValue[idx] += val++;
                    }
                }
                val = 2;
            }

            for(int i = 0; i < employeeValue.Length; i++){
                Console.Write(employeeValue[i] + " ");
            }
        }
    }
}