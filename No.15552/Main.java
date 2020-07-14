import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.*;
import java.util.Scanner;
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
            StringTokenizer st;
            for(int i = 0; i < n ; i++){
                st =  new StringTokenizer(bf.readLine());
                sb.append(Integer.parseInt(st.nextToken()) + Integer.parseInt(st.nextToken()) + "\n");
            }
            bw.write(sb.toString());
            bw.flush();
            bw.close();
            bf.close();
        }catch(IOException e){
            System.out.print(e);
        }
    }
}