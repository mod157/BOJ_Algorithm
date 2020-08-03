import java.io.*
import java.util.*
import java.util.StringTokenizer
fun main(args: Array<String>) = with(BufferedReader(InputStreamReader(System.`in`))) {
   var st = StringTokenizer(readLine())
   var p1 = st.nextToken().toInt()
   var p2 = st.nextToken().toInt()
   var p3 = st.nextToken().toInt()
   var value = p3 - p2
   if(value > 0){
      var answer = p1 / value
      print(answer + 1)
   }else{
      print(-1)
   }
   
}