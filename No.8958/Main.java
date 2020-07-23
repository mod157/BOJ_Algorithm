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
            int size = Integer.parseInt(bf.readLine());
            int sum = 0;
            int num = 0;
            int length = 0;
            String str = "";
            for (int k = 0; k < size; k++) {
                str = bf.readLine().trim();
                length = str.length();
                sum = 0;
                 num = 0;
                for (int i = 0; i < length; i++) {
                    if (str.charAt(i) == 'O') {
                        sum += (++num);
                    } else {
                        num = 0;
                        continue;
                    }

                }
                System.out.println(sum);
            }
        }catch(IOException e){
            System.out.println(e);
        }
    }
}