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
            int[][] hw = new int[15][15];
            for(int i = 0; i <= 14; i++){
                hw[0][i] = i + 1;
            }

            for(int i = 1; i <= 14; i++){
                for(int j = 0;  j <= 14; j++){
                    if(j == 0){
                        hw[i][j] = 1;
                        continue;
                    }
                    if(j == 1){
                        hw[i][j] = i + 2;
                        continue;
                    }
                    hw[i][j] = hw[i][j - 1] + hw[i - 1][j]; 
                }
            }

            int n = Integer.parseInt(bf.readLine());
            int a = 0;
            int b = 0;
            for(int i = 0; i < n; i++){
                a = Integer.parseInt(bf.readLine());
                b = Integer.parseInt(bf.readLine());
                sb.append(hw[a][b - 1] + "\n");
            }
            System.out.print(sb.toString());
            
        }catch(IOException e){
            System.out.println(e);
        }
    }
}