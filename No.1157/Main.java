import java.io.*;
import java.util.*;
import java.util.StringTokenizer;
public class Main{
    public static BufferedReader bf = new BufferedReader(new InputStreamReader(System.in));
    public static StringBuilder sb = new StringBuilder();
    public static void main(String[] args){
        new Main().Answer();
    }
    public void Answer(){
        try{
            String s = bf.readLine().toUpperCase();
            int[] alpha = new int[26];
            Boolean isSame = false;
    
            for(int i = 0; i < s.length(); i++){
                alpha[s.charAt(i) - 'A']++; 
            }
    
            int max = 0;
            for(int i = 1; i < alpha.length; i++){
                if(alpha[i] == 0){
                    continue;
                }
    
                if(alpha[i] > alpha[max]){
                    max = i;
                    isSame = false;
                    continue;
                }
    
                if(alpha[max] == alpha[i]){
                    isSame = true;
                }
            }
            System.out.print(String.format("%c", isSame ? '?' : ('A' + max)));
            
        }catch(IOException e){
            System.out.println(e);
        }
    }
}