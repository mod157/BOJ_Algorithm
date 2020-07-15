import java.io.*;
import java.util.StringTokenizer;
public class Main{
    public static BufferedReader bf = new BufferedReader(new InputStreamReader(System.in));
    public static void main(String[] args){
        new Main().Answer();
    }
    public void Answer(){
        try{
            StringTokenizer n = new StringTokenizer(bf.readLine());
            int a = Integer.parseInt(n.nextToken());
            int b = Integer.parseInt(n.nextToken());
            int c = Integer.parseInt(n.nextToken());
            System.out.print(a >= b ? b >= c ? b : a >= c ? c : a : c >= b ? b : a >= c? a : c);
        }catch(IOException e){
            System.out.println(e);
        }
    }
}