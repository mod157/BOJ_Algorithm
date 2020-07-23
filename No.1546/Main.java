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
            StringTokenizer st = new StringTokenizer(bf.readLine());
            int val = 0;
            float value = 0f;
            int max = 0;
            for(int i = 0; i < n; i++){
                val = Integer.parseInt(st.nextToken());
                value += val;
                if(val > max){
                    max = val;
                }
            }
            System.out.print(value / (max * n) * 100);
            
        }catch(IOException e){
            System.out.println(e);
        }
    }
}