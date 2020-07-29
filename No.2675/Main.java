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
            String[] data;
            String answer = "";
            for(int i = 0; i < n; i++){
                data = bf.readLine().split(" ");
                for(int j = 0; j < data[1].length(); j++){
                    for(int k = 0 ; k < Integer.parseInt(data[0]); k++){
                        answer += data[1].charAt(j);
                    }
                }
                sb.append(answer + "\n");
                answer = "";
            }
            System.out.print(sb.toString());
            
        }catch(IOException e){
            System.out.println(e);
        }
    }
}