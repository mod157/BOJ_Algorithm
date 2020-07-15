import java.io.*;
import java.util.StringTokenizer;
public class Main{
    public static BufferedReader bf = new BufferedReader(new InputStreamReader(System.in));
    public static void main(String[] args){
        new Main().Answer();
    }
    public void Answer(){
        try{
            int avg = 0;
            for(int i = 0; i < 5; i++){
                int num = Integer.parseInt(bf.readLine());
                avg += (num < 40) ? 40 : num;
            }
            System.out.println((int)(avg*0.2));
            bf.close();
            
        }catch(IOException e){
            System.out.println(e);
        }
    }
}