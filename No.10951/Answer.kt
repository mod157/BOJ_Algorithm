import java.io.*
import java.util.StringTokenizer
fun main(args: Array<String>) = with(BufferedReader(InputStreamReader(System.`in`))) {
   while(true){
      val str = readLine();
      if(str == null || str == ""){
         break;
      }
      var st = StringTokenizer(str)
      println(st.nextToken().toInt() + st.nextToken().toInt())
   }
}