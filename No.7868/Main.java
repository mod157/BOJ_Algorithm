import java.io.*;
import java.lang.*;
import java.util.*;
import java.util.StringTokenizer;
public class Main{
    public static BufferedReader bf = new BufferedReader(new InputStreamReader(System.in));
    public static void main(String[] args){
        new Main().Answer();
    }
    public void Answer(){
        try{
            StringTokenizer st = new StringTokenizer(bf.readLine());
            long[] n = {Long.parseLong(st.nextToken()),Long.parseLong(st.nextToken()),Long.parseLong(st.nextToken()),Integer.parseInt(st.nextToken())};
            ArrayList<Long> values = new ArrayList();
            int p1 = 0, p2 = 0, p3 = 0;

            values.add(1L);
            for(int i = 1; i <= n[3]; i++){
                while(values.get(i-1) >= values.get(p1)*n[0]) p1++;
                while(values.get(i-1) >= values.get(p2)*n[1]) p2++;
                while(values.get(i-1) >= values.get(p3)*n[2]) p3++;
                values.add(min(values.get(p1)*n[0],values.get(p2)*n[1]));
                values.set(i, min(values.get(i), values.get(p3)*n[2]));
            }
            System.out.print(values.get((int)n[3]));
            
        }catch(IOException e){
            System.out.println(e);
        }
    }

    public long min(Long value1, Long value2){
        return value1 > value2 ? value2 : value1;
    }
}