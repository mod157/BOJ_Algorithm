import java.util.Scanner
import java.io.BufferedReader 
import java.io.InputStreamReader
import java.util.StringTokenizer
fun main(args: Array<String>) = with(BufferedReader(InputStreamReader(System.`in`))) {
   val n = Integer.parseInt(readLine())
   var sb : StringBuilder = StringBuilder()
   for(i in 0 until n){
      var ab = StringTokenizer(readLine())
      sb.appendln(ab.nextToken().toInt() + ab.nextToken().toInt())
   }
   print(sb.toString())
}