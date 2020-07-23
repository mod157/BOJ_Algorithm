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
            float avg = 0;
            double answer = 0;
            int idx = 0;
            StringTokenizer st;
            int[] values;
            int value = 0;
            for(int i = 0; i < n; i++){
                st = new StringTokenizer(bf.readLine());
                idx = Integer.parseInt(st.nextToken());
                avg = 0;
                answer = 0;
                values = new int[idx];
                for(int j = 0; j < idx; j++){
                    value = Integer.parseInt(st.nextToken());
                    avg += value;
                    values[j] = value;
                }

                avg = avg / idx;
                for(int j = 0; j < idx; j++){
                    if(values[j] > avg){
                        answer += 100;
                    }
                }
                sb.append(String.format("%.3f",  answer / idx) + "%\n");
            }
            System.out.print(sb.toString());
            
        }catch(IOException e){
            System.out.println(e);
        }
    }
}