import java.io.*;
import java.util.*;
import java.util.StringTokenizer;
public class Main{
    public static StringBuilder sb = new StringBuilder();
    public static void main(String[] args){
        new Main().Answer();
    }
    public void Answer(){
        selfNumber(10000);
        System.out.print(sb.toString());
    }

    public void selfNumber(int n){
        HashSet<Integer> hs = new HashSet<Integer>();
        char[] temp;
        int let = 0;
        for(int i = 0 ; i < n; i++){
            let = 0;
            temp = (i+"").toCharArray();
            
            switch(temp.length){
                case 1:
                    let = temp[0] - '0';
                break;
                case 2:
                    let = temp[0] - '0' + temp[1] - '0';
                break;
                case 3:
                    let = temp[0] - '0' + temp[1] - '0' + temp[2] - '0';
                break;
                case 4:
                    let = temp[0] - '0' + temp[1] - '0' + temp[2] - '0' + temp[3] - '0';
                break;
            }
            hs.add(i + let);
        }

        for(int i = 1 ; i <= n; i++){
            if(!hs.contains(i)){
                sb.append(i+"\n");
            }
        }
    }
}