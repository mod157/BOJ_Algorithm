import java.io.*
import java.util.StringTokenizer
fun main(args: Array<String>) = with(BufferedReader(InputStreamReader(System.`in`))) {
   val n = readLine().toInt()
   var sb = StringBuilder()
   for(i in 0 until n){
      var ab = StringTokenizer(readLine())
      var a = ab.nextToken()
      var b = ab.nextToken()
      sb.appendln("Case #${i+1}: ${a.toInt()+b.toInt()}")
   }
   print(sb.toString());
}