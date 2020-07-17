import java.io.*
import java.util.StringTokenizer
fun main(args: Array<String>) = with(BufferedReader(InputStreamReader(System.`in`))) {
   val n = readLine().toInt()
   var min = 1000001
   var max = -1000001;
   var values = StringTokenizer(readLine())
   for(i in 0 until n){
      var a = values.nextToken().toInt();
       if(a > max){
           max = a
       }
       if(a < min){
           min = a
       }
   }
   print(min.toString() + " " + max)
}