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

            System.out.print(sb.toString());
            
        }catch(IOException e){
            System.out.println(e);
        }
    }

    public long sum(int[] a){
        long ans = 0;

        for(int i = 0; i < a.length; i += 3){
            ans += a[i];
            if(i+1 != a.length){
                ans += a[i+1];
            }
            if(i+2 != a.length){
                ans += a[i+2];
            }
        }

        return ans;
    }
}