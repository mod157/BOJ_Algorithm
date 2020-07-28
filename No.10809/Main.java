import java.io.*;
import java.util.StringTokenizer;
public class Main{
    public static BufferedReader bf = new BufferedReader(new InputStreamReader(System.in));
    public static StringBuilder sb = new StringBuilder();
    public static void main(String[] args){
        new Main().Answer();
    }
    public void Answer(){
        try{
            String str = bf.readLine();
            int[] n = new int[26];
            int idx = 0;

            for(int i = 0; i < str.length(); i++){
                idx = str.charAt(i) - 'a';
                if(n[idx] == 0){
                    n[idx] = i + 1;
                }
            }

            for(int i = 0;  i < n.length; i++){
                sb.append(--n[i] + " ");
            }
            System.out.print(sb.toString());
            
        }catch(IOException e){
            System.out.println(e);
        }
    }
}