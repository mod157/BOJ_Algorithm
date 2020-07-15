import java.io.*;
import java.util.StringTokenizer;
public class Main{
    public static BufferedReader bf = new BufferedReader(new InputStreamReader(System.in));
    public static void main(String[] args){
        new Main().Answer();
    }
    public void Answer(){
        try{
            int min = 2001;
            int minsetValue = 0;
            int n = 0;
            for(int i = 0; i < 5; i++){
                n = Integer.parseInt(bf.readLine());
                if(n < min){
                    min = n;
                }
                if(i == 2){
                    minsetValue = min - 50;
                    min = 2001;
                }
            }
            minsetValue += min;
            System.out.print(minsetValue);
            
        }catch(IOException e){
            System.out.println(e);
        }
    }
}