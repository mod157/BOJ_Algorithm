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
            int[] answer = new int[10];
            int n = 1;
            for(int i = 0 ; i < 3; i++){
                n *= Integer.parseInt(bf.readLine().trim());
            }

            char[] num = (n + "").toCharArray();
            for(int i = 0; i < num.length; i++){
                answer[num[i] - '0']++;
            }    

            for(int i = 0; i < answer.length; i++){
               sb.append(answer[i]+ "\n");
            }
            System.out.print(sb.toString());
            
        }catch(IOException e){
            System.out.println(e);
        }
    }
}