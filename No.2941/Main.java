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
            String n = bf.readLine();
            String rx = "((c|s|z|dz)=)|((c|d)-)|((l|n)j)";
            System.out.print(n.replaceAll(rx, " ").length());
            
        }catch(IOException e){
            System.out.println(e);
        }
    }
}