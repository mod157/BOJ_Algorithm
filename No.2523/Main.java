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
            for(int i = 1; i<= 2*n-1; i++){
                if( i <= n){
                    for(int j = 0; j < i; j++){
                        sb.append("*");
                    }
                }else{
                   for(int j = n*2 - i; j > 0; j--){
                        sb.append("*");
                    } 
                }
                sb.append("\n");
            }
            System.out.print(sb.toString());
            
        }catch(IOException e){
            System.out.println(e);
        }
    }
}