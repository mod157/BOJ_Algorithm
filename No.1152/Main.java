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
            String n = bf.readLine().trim();
            if(n.isEmpty()){
                System.out.print(0);
            }else{
                System.out.print(n.trim().split(" ").length);
            }
            
        }catch(IOException e){
            System.out.println(e);
        }
    }
}