import java.io.*
import java.util.StringTokenizer
fun main(args: Array<String>) = with(BufferedReader(InputStreamReader(System.`in`))) {
   var sum = 0;
   for(i in 1..5){
      var n = readLine().toInt()
      if(n < 40){
         n = 40
      }
      sum += n
   }

   print((sum * 0.2).toInt())
}