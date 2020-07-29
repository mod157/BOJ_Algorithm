import java.io.*
import java.util.*
import java.util.StringTokenizer
fun main(args: Array<String>) = with(BufferedReader(InputStreamReader(System.`in`))) {
   var s = readLine()
   var str  = s.reversed().split(" ");
   if(str[0].toInt() > str[1].toInt()){
      print(str[0])
   }else{
      print(str[1])
   }
}