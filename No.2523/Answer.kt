import java.io.*
import java.util.StringTokenizer
fun main(args: Array<String>) = with(BufferedReader(InputStreamReader(System.`in`))) {
   val n = readLine().toInt()
   var sb = StringBuilder()
   for(i in 1..2*n-1){
      if( i <= n){
          for(j in 0 until i){
              sb.append("*");
          }
      }else{
         for(j in n*2 - i downTo 1){
              sb.append("*");
          } 
      }
      sb.append("\n");
  }
   print(sb.toString())
}