import java.io.*;
import java.util.StringTokenizer;
public class Main{
    public static BufferedReader bf = new BufferedReader(new InputStreamReader(System.in));
    public static void main(String[] args){
        new Main().Answer();
    }
    public void Answer(){
        try{
            String n = bf.readLine();
            System.out.print((int)n.charAt(0));
            
        }catch(IOException e){
            System.out.println(e);
        }
    }
}