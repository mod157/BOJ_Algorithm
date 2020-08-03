import java.io.*;
import java.util.*;
import java.util.StringTokenizer;
public class Main{
    public static BufferedReader bf = new BufferedReader(new InputStreamReader(System.in));
    public static void main(String[] args){
        new Main().Answer();
    }
    public void Answer(){
        try{
            int a = Integer.parseInt(bf.readLine());
            int three = 0;
            int five = a/5;
            a %= 5;
            while(five >= 0){
                if(a % 3 == 0){
                    three = a /3;
                    a %= 3;
                    break;
                }
                five --;
                a += 5;
            }
            if(a == 0){
                System.out.print(five + three);
            }else{
                System.out.print(-1);
            }   
        }catch(IOException e){
            System.out.println(e);
        }
    }
}