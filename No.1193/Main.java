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
            int cnt = 1;
            int div = 0;
            while(true){
                div += cnt;
                if(div >= n){
                    break;
                }
                cnt++;
            }
            
            int value = n - (div - cnt + 1);
            int a = 1 + value, b = cnt - value;
            if(cnt % 2 == 0){
                System.out.print(a + "/" + b);
            }else{
                System.out.print(b + "/" + a);
            }
            
        }catch(IOException e){
            System.out.println(e);
        }
    }
}