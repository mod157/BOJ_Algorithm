using System;
using System.Text;
using System.Collections.Concurrent;
class AnswerClass{
    static void Main(string[] args)
    {
       new AnswerClass().Answer();
    }

    public void Answer(){
        char[] n = Console.ReadLine().ToCharArray();
        int answer = 0;
        int size = n.Length;
        for(int i = 0; i < size; i++){
            if(i + 1 < size){
                if(n[i].Equals('c')){
                    if(n[i + 1].Equals('=') || n[i + 1].Equals('-')){
                        answer++;
                        i++;
                        continue;
                    }
                }

                if(n[i].Equals('d')){
                    if(n[i + 1].Equals('z') && i + 2 < size){
                        if(n[i + 2].Equals('=')){
                            answer++;
                            i += 2;
                            continue;
                        }
                    }else if(n[i + 1].Equals('-')){
                        answer++;
                        i++;
                        continue;
                    }
                }

                if(n[i].Equals('l') || n[i].Equals('n')){
                    if(n[i + 1].Equals('j')){
                        answer++;
                        i++;
                        continue;
                    }
                }
                if(n[i].Equals('s') || n[i].Equals('z')){
                    if(n[i + 1].Equals('=')){
                        answer++;
                        i++;
                        continue;
                    }
                }
                answer++;
            }else{
                answer++;
            }
        }
        Console.Write(answer);
    }
}
