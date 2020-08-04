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
            StringTokenizer st = new StringTokenizer(bf.readLine());
            int a = Integer.parseInt(st.nextToken());
            int b = Integer.parseInt(st.nextToken());
            int v = Integer.parseInt(st.nextToken());
            System.out.print((v - b - 1) / (a - b) + 1);
            
        }catch(IOException e){
            System.out.println(e);
        }
    }
}