using System;

namespace Alr
{
    class Program
    {
       static void Main(string[] args)
        {
            int i, j, k = 0;
            bool isAnswer = false;
            int[] TNum = new int[26];
            int[] TNum_checking = new int[26];
            string str = string.Empty;

            int.TryParse(Console.ReadLine(),out int cntT);
            
            for(k = 0; k < cntT; k++){
                Array.Clear(TNum,0,TNum.Length);
                str = Console.ReadLine();
                
                for(i = 0; i < str.Length; i++){
                    TNum[(int)str[i] - 'A']++;
                }
            

                if(int.TryParse(Console.ReadLine(),out int cntW)){
                    string[] spells = new string[cntW];

                    for(i = 0; i < cntW; i++){
                        spells[i] = Console.ReadLine();
                    }

                    for(i = 0; i < spells.Length; i++){
                        Array.Copy(TNum, TNum_checking, TNum.Length);
                        for(j = 0 ; j < spells[i].Length; j++){
                            if(--TNum_checking[(int)spells[i][j]-'A'] < 0){
                                Console.WriteLine("NO");
                                isAnswer = true;
                                break;
                            }
                        }

                        if(!isAnswer){
                            Console.WriteLine("YES"); 
                        }

                        isAnswer = false;
                    }
                }
            }
        }
    }
}