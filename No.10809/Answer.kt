import java.io.*
import java.util.StringTokenizer
fun main(args: Array<String>) = with(BufferedReader(InputStreamReader(System.`in`))) {
   var str = readLine()
   var n : Array<Int> = Array(26,{-1})
   var sb = StringBuilder()
   for(i in 0 until str.length){
      var idx = str[i] - 'a';
      if(n[idx].toInt() == -1){
          n[idx] = i;
      }
   }

   for(i in n){
         sb.append(i.toString() + " ");
   }
   print(sb.toString())
}