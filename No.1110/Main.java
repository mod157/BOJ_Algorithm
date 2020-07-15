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
            int cnt = 0;
            int a = 0;
            int b = 0;
            int val = n;
            do{
                a = (int)(val * 0.1f);
                b = val % 10;
                val = b * 10 + (a+b)%10;
                cnt++;
            }while(n != val);
            System.out.print(cnt);
            
        }catch(IOException e){
            System.out.println(e);
        }
    }
}