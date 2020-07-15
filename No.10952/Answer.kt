import java.io.*
import java.util.StringTokenizer
fun main(args: Array<String>) = with(BufferedReader(InputStreamReader(System.`in`))) {
   var sb = StringBuilder()
   while(true){
      var st = StringTokenizer(readLine())
      var a = st.nextToken().toInt()
      var b = st.nextToken().toInt()
      if(a == 0 && b == 0){
         break;
      }
      sb.appendln((a + b).toString())
   }
   print(sb.toString())
}