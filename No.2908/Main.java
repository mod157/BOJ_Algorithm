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
            String s = new StringBuilder(bf.readLine()).reverse().toString();
            String[] answer = s.split(" ");
            System.out.print(Integer.parseInt(answer[0]) > Integer.parseInt(answer[1]) ? answer[0] : answer[1]);
        }catch(IOException e){
            System.out.println(e);
        }
    }
}