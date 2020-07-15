import java.io.*
import java.util.StringTokenizer
fun main(args: Array<String>) = with(BufferedReader(InputStreamReader(System.`in`))) {
   val n = readLine().toInt()
   var cnt = 0;
   var value = n;
   do{
      var a = (value * 0.1).toInt();
      var b = value % 10;
      value = b * 10 + (a + b) % 10
      cnt++
   }while(n != value)

   print(cnt)
}