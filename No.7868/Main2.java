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
            long p1 = Long.parseLong(st.nextToken());
            long p2 = Long.parseLong(st.nextToken());
            long p3 = Long.parseLong(st.nextToken());
            int dest = Integer.parseInt(st.nextToken());
            ArrayList<Long> arr = new ArrayList();
            long temp1 = p1;
            long temp2 = 0;
            long INF = 1000000000000000000L;
            long value = 0;

            arr.add(1L);
            while(p1<=INF&&p1>0){
                arr.add(p1);
                p1 = p1*temp1;
            }
            int len = arr.size();
    
            for(int i=0;i<len;i++){
                temp2 = p2;
                while(temp2<=INF&&temp2>0){
                    value = arr.get(i)*temp2;
                    if(value > 0 && value <= INF)
                        arr.add(value);
                    temp2 = temp2*p2;
                }
            }

            len = arr.size();
            for(int i=0;i<len;i++){
                temp2 = p3;
                while(temp2<=INF&&temp2>0){
                    value = arr.get(i)*temp2;
                    if(value > 0 && value <= INF)
                        arr.add(value);
                    temp2 = temp2*p3;
                }
            }
            Collections.sort(arr);
            System.out.println(arr.get(dest));
            
        }catch(IOException e){
            System.out.println(e);
        }
    }
}