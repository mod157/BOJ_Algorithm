import java.io.*;
import java.util.*;
import java.util.StringTokenizer;
public class Main{
    public static BufferedReader bf = new BufferedReader(new InputStreamReader(System.in));
    public static StringBuilder sb = new StringBuilder();
    public static void main(String[] args){
        new Main().Answer();
    }
    public void Answer(){
        try{
            int n1 = Integer.parseInt(bf.readLine());
            for(int i = 0; i < n1 ; i++){
                StringTokenizer st = new StringTokenizer(bf.readLine());
                int h = Integer.parseInt(st.nextToken());
                int w = Integer.parseInt(st.nextToken());
                int n = Integer.parseInt(st.nextToken());
                int f = n % h;
                int num = n / h;
                if(f == 0){
                    f = h;
                 }else{
                    num++;
                 }
                 if(num >= 10){
                    sb.append(f+""+num+"\n");
                 }else{
                    sb.append(f+"0"+num+"\n");
                 }
            }
            System.out.print(sb.toString());
            
        }catch(IOException e){
            System.out.println(e);
        }
    }
}