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
            if(n != 1){
                int answer = n / 6;
                int div = 0;
                int cnt = 1;
                while(true){
                    div += cnt++;
                    if(div >= answer){
                        if(n > div * 6 + 1 ){
                            cnt++;
                            break;
                        }else{
                            break;
                        }
                    }
                }
    
                System.out.print(cnt);
            }else{
                System.out.print(n);
            }
            
        }catch(IOException e){
            System.out.println(e);
        }
    }
}