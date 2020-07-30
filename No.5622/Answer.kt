import java.io.*
import java.util.*
import java.util.StringTokenizer
fun main(args: Array<String>) = with(BufferedReader(InputStreamReader(System.`in`))) {
   val n = readLine()
   var answer : Int = 0
   for(i in n){
       answer += (i - 'A').toInt() / 3 + 3
       if(i.equals('S') || i.equals('V') || i.equals('Y') || i.equals('Z')){
           answer--
       }
   }
   print(answer)
}