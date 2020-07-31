import java.io.*;
import java.util.*;
import java.util.StringTokenizer;
public class Main{
    public static BufferedReader bf = new BufferedReader(new InputStreamReader(System.in));
    public static void main(String[] args){
        new Main().Answer();
    }
    public void Answer(){
        try{
            int n = Integer.parseInt(bf.readLine());
            int answer = n;
            int lastAlpha = 0;
            char[] s;
            int ascii = 0;
    
            for(int i = 0; i < n; i++){
                s = bf.readLine().toCharArray();
                boolean[] isAlpha = new boolean[26];
                for(int j = 0; j < s.length; j++){
                    ascii = s[j] - 'a';
                    if(!isAlpha[ascii]){
                        isAlpha[ascii] = true;    
                    }else if(lastAlpha != ascii){
                        answer--;
                        break;
                    }
    
                    lastAlpha = ascii;
                }
            }
            System.out.print(answer);
            
        }catch(IOException e){
            System.out.println(e);
        }
    }
}