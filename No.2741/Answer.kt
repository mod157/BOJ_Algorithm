import java.io.BufferedReader 
import java.io.InputStreamReader
import java.util.*
fun main(args: Array<String>) = with(BufferedReader(InputStreamReader(System.`in`))) {
   val n = readLine().toInt()
   var sb = StringBuilder();
   for(i in 1 .. n){
      sb.appendln(i.toInt())
   }
   print(sb.toString())
}