import java.io.*;
import java.util.StringTokenizer;
public class Main{
    public static BufferedReader bf = new BufferedReader(new InputStreamReader(System.in));
    public static void main(String[] args){
        new Main().Answer();
    }
    public void Answer(){
        try{
            String s = "";
            StringTokenizer st;
            while((s = bf.readLine()) != null){
                st = new StringTokenizer(s);
                System.out.println(Integer.parseInt(st.nextToken()) + Integer.parseInt(st.nextToken()));
            }
        }catch(IOException e){
            System.out.println(e);
        }
    }
}