import java.io.*
import java.util.StringTokenizer
fun main(args: Array<String>) = with(BufferedReader(InputStreamReader(System.`in`))) {
   val n = readLine().toInt()
   var sb = StringBuffer()
   for(i in 1 .. n){
      for(j in i until n){
         sb.append(" ")
      }
      for(j in 0 until i){
         sb.append("*")
      }
      sb.append("\n")
   }
   print(sb.toString())
}