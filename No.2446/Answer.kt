import java.io.*
import java.util.StringTokenizer
fun main(args: Array<String>) = with(BufferedReader(InputStreamReader(System.`in`))) {
   val n = readLine().toInt()
   var sb = StringBuilder()
   for(i in 1..(n*2-1)){
      if(i <= n){
          for(k in  1 until i){
              sb.append(" ");
          }
          for(j in (n * 2) downTo (i * 2)){
              sb.append("*");
          }
      }else{
          for(k in (n*2 - 1) downTo i+1){
              sb.append(" ");
          }
          for(j in (n * 2) .. (i * 2)){
              sb.append("*");
          }
      }
      sb.append("\n");
  }
   print(sb.toString())
}