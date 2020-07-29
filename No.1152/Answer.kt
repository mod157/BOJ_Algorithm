import java.io.*
import java.util.*
import java.util.StringTokenizer
fun main(args: Array<String>) = with(BufferedReader(InputStreamReader(System.`in`))) {
   var n = readLine().trim()
   if(n.isEmpty()){
         print(0);
   }else{
         print(n.trim().split(" ").count());
   }
}