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
            String n = bf.readLine();
            int answer = 0;
            for(int i = 0; i < n.length(); i++){
                answer += (int)(n.charAt(i) - 'A') / 3 + 3;
                if(n.charAt(i) ==  'S' || n.charAt(i) == 'V' || n.charAt(i) == 'Y' || n.charAt(i) == 'Z'){
                    answer--;
                }
            }
            System.out.print(answer);
            
        }catch(IOException e){
            System.out.println(e);
        }
    }
}