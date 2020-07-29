import java.io.*
import java.util.StringTokenizer
fun main(args: Array<String>) = with(BufferedReader(InputStreamReader(System.`in`))) {
   val n = readLine().toInt()
   var sb = StringBuilder()
   for(i in 0 until n){
         var data = readLine().split(" ");
         var answer : String = ""
         for(j in 0 until data[1].length){
            for(k in 0 until Integer.parseInt(data[0])){
               answer += data[1][j]
            }
         }
         sb.appendln(answer)
   }
   print(sb.toString())
}