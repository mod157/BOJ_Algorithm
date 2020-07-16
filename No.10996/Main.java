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
            for(int i = 1; i <= n*2; i++){
                if(i % 2 != 0){
                    for(int j = 0; j < n; j++){
                        sb.append(j % 2 != 0 ? " " : "*");
                    }
                    sb.append("\n");
                }else{
                    for(int j = 0; j < n; j++){
                        sb.append(j % 2 == 0 ? " " : "*");
                    }
                    sb.append("\n");
                }
            }
            System.out.print(sb.toString());
            
        }catch(IOException e){
            System.out.println(e);
        }
    }
}