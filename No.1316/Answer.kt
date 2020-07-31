import java.io.*
import java.util.*
import java.util.StringTokenizer
fun main(args: Array<String>) = with(BufferedReader(InputStreamReader(System.`in`))) {
   val n = readLine().toInt()
   var answer = n;
   var lastAlpha = 0;
   var s : CharArray;

   for(i in 0 until n){
       s = readLine().toCharArray();
       var isAlpha = BooleanArray(26);
       for(c in s){
           var ascii = c - 'a';
           if(!isAlpha[ascii]){
               isAlpha[ascii] = true;    
           }else if(lastAlpha != ascii){
               answer--;
               break;
           }

           lastAlpha = ascii;
       }
   }

   print(answer)
}