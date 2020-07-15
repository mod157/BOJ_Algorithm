import java.io.BufferedReader 
import java.io.InputStreamReader
import java.util.StringTokenizer
fun main(args: Array<String>) = with(BufferedReader(InputStreamReader(System.`in`))) {
   val read = StringTokenizer(readLine())
   val a = StringTokenizer(readLine())
   var n = read.nextToken().toInt()
   var x = read.nextToken().toInt()
   for(i in 0 until n){
      var s = a.nextToken().toInt()
      if(s < x){
         print(s.toString()+" ");
      }
   }
}