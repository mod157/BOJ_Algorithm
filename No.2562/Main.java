import java.io.*;
import java.util.StringTokenizer;
public class Main{
    public static BufferedReader bf = new BufferedReader(new InputStreamReader(System.in));
    public static void main(String[] args){
        new Main().Answer();
    }
    public void Answer(){
        try{
            int max = 0;
            int n = 0;
            int idx = 0;
            for(int i = 1 ; i <= 9; i++){
                n = Integer.parseInt(bf.readLine());
                if(n > max){
                    max = n;
                    idx = i;
                } 
            }
            System.out.print(max + "\n" + idx);
            
        }catch(IOException e){
            System.out.println(e);
        }
    }
}