import java.io.*;
import java.util.StringTokenizer;
public class Main{
    public static BufferedReader bf = new BufferedReader(new InputStreamReader(System.in));
    public static BufferedWriter bw = new BufferedWriter(new OutputStreamWriter(System.out));
    public static StringBuilder sb = new StringBuilder();
    public static void main(String[] args){
        new Main().Answer();
    }
    public void Answer(){
        try{
            int n = Integer.parseInt(bf.readLine());
            for(int i = 1 ; i <= n; i++){
                sb.append(i + "\n");
            }
            bw.write(sb.toString());
            bw.flush();
            bw.close();
            bf.close();
        }catch(IOException e){
            System.out.println(e);
        }
    }
}