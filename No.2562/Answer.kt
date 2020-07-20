import java.io.*
import java.util.StringTokenizer
fun main(args: Array<String>) = with(BufferedReader(InputStreamReader(System.`in`))) {
   var max = 0;
   var idx = 0;
   for(i in 1..9){
      val n = readLine().toInt()
      if(n > max){
         max = n;
         idx = i;
      }
   }

   print(max.toString() + "\n" + idx)
}