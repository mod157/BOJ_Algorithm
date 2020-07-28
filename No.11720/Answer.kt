import java.io.*
import java.util.StringTokenizer
fun main(args: Array<String>) = with(BufferedReader(InputStreamReader(System.`in`))) {
   val n = readLine().toInt()
   var str = readLine()
   var sum : Int = 0
   for(i in 0 until n){
      sum += (str[i] - '0').toInt()
   }

   print(sum)
}