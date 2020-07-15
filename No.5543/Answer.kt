import java.io.*
import java.util.StringTokenizer
fun main(args: Array<String>) = with(BufferedReader(InputStreamReader(System.`in`))) {
   var n = 0
   var min = 2001;
   var minsetValue = 0;
   for(i in 0..4){
      n = readLine().toInt()
      if(n < min){
         min = n;
      }
      if(i == 2){
         minsetValue = min - 50;
         min = 2001;
      }
   }
   
   minsetValue += min;
   print(minsetValue)
}