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
            int n = Integer.parseInt(bf.readLine());

            System.out.print(sb.toString());
            
        }catch(IOException e){
            System.out.println(e);
        }
    }
    
    public List<int> Eratos(int max){
        Boolean[] c = new Boolean[max + 1];
        List<int> list = new List<int>();
        for(int i=2; i<=max; i++){
            if(c[i] == false){
                // 추가
                list.Add(i);
                // i의 배수 지우기
                for(int j=i+i; j<=max; j+=i){
                    c[j]=true;
                }
            }
        }

        return list;
    }
}