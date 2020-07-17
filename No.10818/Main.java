import java.io.*;
import java.util.StringTokenizer;
public class Main{
    public static void main(String[] args){
        new Main().Answer();
    }
    public void Answer(){
        try{
            int n = Integer.parseInt(bf.readLine());
            StringTokenizer st = new StringTokenizer(bf.readLine());
            int min = 1000001, max = -1000001;
            int[] arr = new int[n];
            for(int i = 0 ; i < n; i++){
                arr[i] = Integer.parseInt(st.nextToken());
            }
            for(int i = 0 ; i < n; i++){
                if(arr[i] > max){
                    max = arr[i];
                }
                if(arr[i] < min){
                    min = arr[i];
                }
            }
            System.out.print(min + " " + max);
            
        }catch(IOException e){
            System.out.println(e);
        }
    }
}