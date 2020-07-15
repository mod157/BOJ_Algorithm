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
            int n = Integer.parseInt(bf.readLine());
            int a = 0; int b = 0;
            StringTokenizer st;
            for(int i = 0; i < n; i++){
                st = new StringTokenizer(bf.readLine());
                a = Integer.parseInt(st.nextToken());
                b = Integer.parseInt(st.nextToken());
                sb.append(String.format("Case #%d: %d + %d = %d\n", i+1, a, b, a+b));
            }
            System.out.print(sb.toString());
        }catch(IOException e){
            System.out.println(e);
        }
    }
}