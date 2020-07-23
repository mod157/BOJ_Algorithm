import java.io.*
import java.util.StringTokenizer
fun main(args: Array<String>) = with(BufferedReader(InputStreamReader(System.`in`))) {
   var cnt:Int = 0
   var list = MutableList(42, {0})
   for(i in 0 .. 9){
      val n = readLine().toInt() % 42
      if(list[n] == 0){
         list[n]++
         cnt++;
      }
   }
   print(cnt);
}