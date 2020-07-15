import java.io.*;
import java.util.StringTokenizer;
public class Main{
    public static BufferedReader bf = new BufferedReader(new InputStreamReader(System.in));
    public static StringBuilder sb = new StringBuilder();
    public static void main(String[] args){
        new Main().Answer();
    }
    public void Answer(){
        try{
            StringTokenizer s = new StringTokenizer(bf.readLine());
            int n = Integer.parseInt(s.nextToken()); int x = Integer.parseInt(s.nextToken());
            s = new StringTokenizer(bf.readLine());
            int a;
            for(int i = 0; i < n; i++){
                a = Integer.parseInt(s.nextToken());
                if(a < x){
                    sb.append(a + " ");
                }
            }
            System.out.print(sb.toString().trim());
        }catch(IOException e){
            System.out.println(e);
        }
    }
}