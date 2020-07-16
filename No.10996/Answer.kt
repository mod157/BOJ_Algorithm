import java.io.*
import java.util.StringTokenizer
fun main(args: Array<String>) = with(BufferedReader(InputStreamReader(System.`in`))) {
   val n = readLine().toInt()
   var sb = StringBuilder()
   for(i in 1..n*2){
      if(i % 2 != 0){
          for(j in 0 until n){
             if(j % 2 != 0){
                sb.append(" ")
             }else{
                sb.append("*")
             }
          }
          sb.append("\n");
      }else{
         for(j in 0 until n){
            if(j % 2 == 0){
               sb.append(" ")
            }else{
               sb.append("*")
            }
         }
         sb.append("\n");
      }
  }
   print(sb.toString())
}