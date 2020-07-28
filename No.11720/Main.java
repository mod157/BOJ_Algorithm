import java.io.*;
import java.util.StringTokenizer;
public class Main{
    public static BufferedReader bf = new BufferedReader(new InputStreamReader(System.in));
    public static void main(String[] args){
        new Main().Answer();
    }
    public void Answer(){
        try{
            int n = Integer.parseInt(bf.readLine());
            String s = bf.readLine();
            int sum = 0;
            for(int i = 0 ; i < n; i++){
                sum += s.charAt(i) - '0';
            }
            System.out.print(sum);
            
        }catch(IOException e){
            System.out.println(e);
        }
    }
}