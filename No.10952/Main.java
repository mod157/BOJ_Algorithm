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
            while(true){
                StringTokenizer st = new StringTokenizer(bf.readLine());
                int a = Integer.parseInt(st.nextToken());
                int b = Integer.parseInt(st.nextToken());
                if(a == 0 && b == 0){
                   break;
                }
                sb.append(a + b + "\n");
            }
            System.out.print(sb.toString());
        }catch(IOException e){
            System.out.println(e);
        }
    }
}